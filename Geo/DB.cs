using System;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Windows.Forms;

public class DB
{
    OdbcConnection conn;
    public DB()
    {
        string connString = "Driver={MySQL ODBC 8.0 Unicode Driver};Server=localhost;Port=3307;Database=userinfo;Uid=root;Pwd=password";//"DSN=usersDBSys;User ID=root; Password=password;";//"Driver={MySQL ODBC 9.2 Unicode Driver};Server=localhost;Port=3307;Database=userinfo;Uid=root;Pwd=password";
        // To use this function I had to execute dotnet add package System.Data.Odbc in the project directory
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

    public int Add_user(string username, string password)
    {
        // To use this function I had to execute dotnet add package System.Data.Odbc in the project directory.
        if (this.conn.State != ConnectionState.Open)
        {
            this.conn.Open();
        }
        int affectedRows = 0;

        string insertSQL = "INSERT INTO users(Id, Uname, Password, Urank, Points, Role) VALUES(?,?,?,?,?,?);";
        OdbcCommand command = new OdbcCommand(insertSQL, this.conn);

        command.Parameters.AddWithValue("Id", username.GetHashCode());
        command.Parameters.AddWithValue("Uname", username);
        command.Parameters.AddWithValue("Password", password);
        command.Parameters.AddWithValue("Urank", 1);
        command.Parameters.AddWithValue("Points", 0);
        command.Parameters.AddWithValue("Role", 0);

        command.ExecuteNonQuery();
        this.conn.Close();
        if (affectedRows <= 0)
        {
            return -1;
        }
        return affectedRows;
    }

    public string get_Urank(string username)
    {
        string query = "SELECT Urank FROM users WHERE Uname = ?";
        OdbcCommand command = new OdbcCommand(query, this.conn);

        // Add the username to the prepared statement.
        command.Parameters.AddWithValue("", username);

        // Retrieve the data.
        var reader = command.ExecuteReader();
        if (reader.Read())
        {
            MessageBox.Show(reader.GetString(0));
        }
        return username;
    }
}
