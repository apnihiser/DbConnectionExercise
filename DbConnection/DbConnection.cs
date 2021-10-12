using System;

namespace DbConnection
{
    // X BASE CLASS
    // X They have a connection string
    // X They can be opened
    // X They can be closed
    // X Timeout attribute
    // X prop 1: ConnectionString : string
    // X prop 2: Timeout : TimeSpan
    // X Will not be an a valid state if it doesn't have a connection string. Pass in contructor.
    // X What do if connection string is null, or empty string? Exception
    // Method 1: Opening connection left to derivitive classes, make abstract
    // Method 2: close connection left to derivitive classes, make abstract

    public abstract class DbConnection
    {
        public TimeSpan Timeout { get; private set; }
        public string ConnectionString { get; private set; }

        public DbConnection(int timeout, string connectionString)
        {
            if (String.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentNullException(connectionString, "No connection string was created.");
            else
            {
                this.Timeout = new TimeSpan(timeout);
                this.ConnectionString = connectionString;
                Console.WriteLine("Database Connection template created.");
            }
        }

        public abstract void Open();

        public abstract void Close();
    }
}
