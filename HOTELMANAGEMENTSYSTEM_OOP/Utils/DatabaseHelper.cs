using HOTELMANAGEMENTSYSTEM_OOP.Utils;
using System;
using System.Data.SQLite;
using System.IO;


public static class DatabaseHelper
{
    public static void InitializeDatabase()
    {
        try
        {
            if (!File.Exists(DatabaseConfig.ConnectionString))
            {
                SQLiteConnection.CreateFile(DatabaseConfig.ConnectionString);

                using (SQLiteConnection connection = new SQLiteConnection(DatabaseConfig.ConnectionString))
                {
                    connection.Open();
                    
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error initializing database: {ex.Message}");
        }
    }
}

