using System;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

public class DB
{
    OdbcConnection conn;
    public DB()
    {
        string connString = "DSN=usersDBSys;User ID=root; Password=password;";
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
}
