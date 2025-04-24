using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Windows.Forms;
using BCrypt.Net;
using Org.BouncyCastle.Crypto.Generators;

public class DB
{
    string connString = "Driver={MySQL ODBC 8.0 Unicode Driver};Server=10.32.196.53;Port=3306;Database=userinfo;Uid=kaden;Pwd=HelloThere...";
    const string stringDefault = "";
    HashSet<string> accesibleColumns = new HashSet<string> { "Id", "Uname", "Urank", "Points", "Role" };
    Dictionary<string, int> validRoles = new Dictionary<string, int> { { "student", 0 }, { "teacher", 1 } };
    OdbcConnection conn;
    public DB()
    {
        this.conn = new System.Data.Odbc.OdbcConnection(connString);
        try
        {
            if (this.conn.State != ConnectionState.Open)
            {
                this.conn.Open();
            }
            this.Add_user("hello", "world");
            this.conn.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    /*
     * Name: Add_user
     * Purpose: Create a new user in the database.
     * Input:
     *  1.  username(string): the new user's username
     *  2.  password(string): the new user's password
     * Output:
     *  1. affectedRows (int): the number of affected rows in the database. If this value is 1, then the operation
     *      was successful, else it failed.
     *  Notes:
     *  4.24.25: Tested
     */
    public int Add_user(string username, string password)
    {
        // To use this function I had to execute dotnet add package System.Data.Odbc in the project directory.
        Check_Conn_State();
        int affectedRows = 0;

        // Check if the user alread exists
        if (Check_Username(username))
        {
            throw new ArgumentException("Username in use");
        }

        string insertSQL = "INSERT INTO users(Id, Uname, Password, Urank, Points, Role) VALUES(?,?,?,?,?,?);";
        OdbcCommand command = new OdbcCommand(insertSQL, this.conn);

        command.Parameters.AddWithValue("Id", username.GetHashCode());
        command.Parameters.AddWithValue("Uname", username);
        command.Parameters.AddWithValue("Password", BCrypt.Net.BCrypt.EnhancedHashPassword(password));
        command.Parameters.AddWithValue("Urank", 1);
        command.Parameters.AddWithValue("Points", 0);
        command.Parameters.AddWithValue("Role", 0);

        affectedRows = command.ExecuteNonQuery();
        this.conn.Close();
        if (affectedRows <= 0)
        {
            throw new Exception();
        }
        return affectedRows;
    }
    
    
    /*
     * Name: Get_Accessible_Field
     * Purpose: Get the value of a specified field based on a specified search field and value. This function cannot retrieve
     *      the password field. The method always accepts and returns a string, so any functions calling it must convert all
     *      integers as necessary.
     * Input:
     *  1. targetField (string): the field the method returns.
     *  2. searchField (string): the field the query searches by.
     *  3. value (string): the expected value of the searchField.
     * Output:
     *  1. returnValue (string): return value can be a string or integer, but it is returned as a string to simplify the process
     *      of returning values.
     * Notes: 
     * 4.21.25: Tested
     */
    public string Get_Accessible_Field(string targetField, string searchField, string value)
    {
        Check_Conn_State();
        string returnValue = stringDefault;
        if (accesibleColumns.Contains(targetField) && accesibleColumns.Contains(searchField))
        {
            string query = $"SELECT {targetField} FROM users WHERE {searchField} = ?";
            OdbcCommand command = new OdbcCommand(query, this.conn);

            // Add the username to the prepared statement.
            command.Parameters.AddWithValue("", value);

            // Retrieve the data.

            var reader = command.ExecuteReader();
            if (reader.Read())
            {
                returnValue = reader.GetString(0);
            }
        }
        return returnValue.ToString();
    }
    
    
    /*
     * Name: Set_Uname
     * Purpose: to change the username of a given user.
     * Input:
     *  1.  currUsrName (string): the username of the user before the change occurs
     *  2.  newUsrName (string): the name to which the username will be changed
     * Output:
     *  1. (bool): Whether the operation was successful
     * Notes:
     * 4.21.25: Tested
     */
    public bool Set_Uname(string currUsrName, string newUsrName)
    {
        // If the old username does not exist, break.
        this.Check_Username(currUsrName);

        // If the new username exists, break.
        if (this.Get_Accessible_Field("Uname", "Uname", newUsrName) != stringDefault)
        {
            throw new ArgumentException("New username is already in use");
        }

        string query = "UPDATE users SET Uname = ? WHERE Uname = ?";
        OdbcCommand command = new OdbcCommand(query, this.conn);

        command.Parameters.AddWithValue("", newUsrName);
        command.Parameters.AddWithValue("", currUsrName);

        int success = command.ExecuteNonQuery();
        MessageBox.Show(success.ToString());

        if (success > 0)
        {
            return true;
        }
        else
        {
            return false;
        }

    }


    /*
     * Name: Set_Urank
     * Purpose: to update the Urank field.
     * Input:
     *  1.  usrName (string): the username whose rank will be updated
     *  2.  rank (string): the new rank
     * Output:
     *  1. true or argument exception
     * Notes:
     * 4.22.25: Tested
     */
    public bool Set_Urank(string usrName, string rank)
    {
        // If the old username does not exist, break.
        this.Check_Username(usrName);

        string query = "UPDATE users SET Urank = ? WHERE Uname = ?";
        OdbcCommand command = new OdbcCommand(query, this.conn);

        command.Parameters.AddWithValue("", rank);
        command.Parameters.AddWithValue("", usrName);

        int success = command.ExecuteNonQuery();
        MessageBox.Show(success.ToString());

        if (success > 0)
        {
            return true;
        }
        else
        {
            throw new ArgumentException("Error setting rank");
        }
    }


    /*
     * Name: Set_Points
     * Purpose: To set a given user's points to a certain value. NOTE: this will remove their old score and replace it with an 
     *      unrelated one. If the goal is to add points to the user's current score, the Add_Points method should be used instead.
     * Input:
     *  1.  points (int): the number of points
     *  2.  usrName (string): the name of the user being affected
     * Output:
     *  1. success (bool): whether the opeation was successful
     * Notes:
     * 4.21.25: Tested
     */
    public bool Set_Points(int points, string usrName)
    {
        this.Check_Username(usrName);
        string query = "UPDATE users SET Points = ? WHERE Uname = ?";
        OdbcCommand command = new OdbcCommand(query, this.conn);

        command.Parameters.AddWithValue("", points);
        command.Parameters.AddWithValue("", usrName);

        int rowsAffected = command.ExecuteNonQuery();
        //MessageBox.Show(rowsAffected.ToString());

        bool success = false;
        if (rowsAffected > 0)
        {
            success = true;
            return success;
        }
        else
        {
            return success;
        }
    }
    
    
    /*
     * Name: Add_Points
     * Purpose: To add points to a user's current score.
     * Input: 
     *  1.  pointsToAdd (int): the number of points to be added to the current score
     *  2.  usrname (string): the user to be affected
     * Output:
     *  1.  success (bool): whether the operation was successful or not
     * Notes:
     * 4.21.25: Tested
     */
    public bool Add_Points(int pointsToAdd, string usrName)
    {
        if (pointsToAdd < 0)
        {
            throw new ArgumentException("Cannot add negative number to the score.");
        }
        this.Check_Username(usrName);

        string temp = this.Get_Accessible_Field("Points", "Uname", usrName);
        int totalPoints = int.Parse(temp) + pointsToAdd;

        string query = "UPDATE users SET Points = ? WHERE Uname = ?";
        OdbcCommand command = new OdbcCommand(query, this.conn);

        command.Parameters.AddWithValue("", totalPoints);
        command.Parameters.AddWithValue("", usrName);

        int rowsAffected = command.ExecuteNonQuery();
        //MessageBox.Show(rowsAffected.ToString());

        bool success = false;
        if (rowsAffected > 0)
        {
            success = true;
            return success;
        }
        else
        {
            return success;
        }
    }
    
    
    /*
     * Name: Set_Role
     * Purpose: To set the role value to a predefined value.
     * Input:
     *  1.  role (string): the name of a role
     *  2.  usrname (string): the name of the user to be updated
     * Output:
     *  1. success (bool): whether the operation was successful.
     * Notes:
     * 4.21.25: Tested
     */
    public bool Set_Role(string role, string usrName)
    {
        // If the old username does not exist, break.
        this.Check_Username(usrName);

        // If the role is invalid, break.
        if (validRoles.ContainsKey(role.ToLower()) != true)
        {
            throw new ArgumentException("Invalid role");
        }

        string query = "UPDATE users SET Role = ? WHERE Uname = ?";
        OdbcCommand command = new OdbcCommand(query, this.conn);

        command.Parameters.AddWithValue("", validRoles[role]);
        command.Parameters.AddWithValue("", usrName);

        int success = command.ExecuteNonQuery();
        MessageBox.Show(success.ToString());

        if (success > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    /*
     * Name: Check_Password
     * Purpose: To provide a means of verifying a password without returning it to the client.
     * Input:  
     *  1.  username (string): the username whose password you are checking
     *  2.  password (string): the password you are checking it against.
     * Output:
     *  1. valid (bool): whether the credentials were correct.
     * Notes:
     * 4.22.25: Tested
     */
    public bool Check_Password(string username, string password)
    {
        Check_Conn_State();
        bool valid = false;

        string query = "SELECT Password FROM users WHERE Uname = ?";
        OdbcCommand command = new OdbcCommand(query, this.conn);

        // Add the username to the prepared statement.
        command.Parameters.AddWithValue("", username);

        var reader = command.ExecuteReader();

        if (reader.Read())
        {
            string hash = reader.GetString(0);
            if (BCrypt.Net.BCrypt.EnhancedVerify(password, hash))
            {
                valid = true;
            }
            return valid;
        }
        else
        {
            throw new ArgumentException("Invalid credential combination");
        }
    }
    
    
    /*
     * Name: Change_Password
     * Purpose: To provide a way to change the password
     * Input:
     *  1.  usrName (string): the username whose password will be updated
     *  2.  currPassword (string): the user's current password
     *  3.  newPassword (string): the user's new password
     * Output:
     *  1. true or argument exception
     * Notes:
     * 4.22.25: Tested
     */
    public bool Change_Password(string usrName, string currPassword, string newPassword)
    {
        this.Check_Username(usrName);

        if(Check_Password(usrName, currPassword))
        {
            string query = "UPDATE users SET Password = ? WHERE Uname = ?";
            OdbcCommand command = new OdbcCommand(query, this.conn);

            command.Parameters.AddWithValue("", BCrypt.Net.BCrypt.EnhancedHashPassword(newPassword));
            command.Parameters.AddWithValue("", usrName);

            int success = command.ExecuteNonQuery();
            MessageBox.Show(success.ToString());
            return true;
        }
        else
        {
            throw new ArgumentException("Could not update the password");
        }
    }
    
    
    /*
     * Name: Check_Conn_State
     * Purpose: To check the status of the connection and open it if is closed. This is to prevent errors due to opening an already
     *      open connection.
     * Input: None
     * Output: None
     * Notes:
     * 4.22.25: Tested
     */
    private void Check_Conn_State()
    {
        if (this.conn.State != ConnectionState.Open)
        {
            this.conn.Open();
        }
    }
    
    
    /*
     * Name: Check_Username
     * Purpose: to verify the existence of a username
     * Input:
     *  1.  username (string): the username to verify
     * Output:
     *  1.  Either returns true or throws an exception
     */
    private bool Check_Username(string username)
    {
        // If the old username does not exist, break.
        if (this.Get_Accessible_Field("Uname", "Uname", username) == stringDefault)
        {
            throw new ArgumentException("User does not exist");
        }
        return true;
    }
}
