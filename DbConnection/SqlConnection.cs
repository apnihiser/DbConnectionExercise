using System;

namespace DbConnection
{
    public class SqlConnection : DbConnection
    {

        public SqlConnection(int timeout, string connectionString) : base(timeout, connectionString)
        {
            Console.WriteLine("SQL Database Connection created.");
        }

        public override void Open()
        {
            System.Console.WriteLine($"Successfully Opened SQLConnection to {ConnectionString}, before {Timeout.TotalMilliseconds:F2}ms.");
        }

        public override void Close()
        {
            System.Console.WriteLine($"Successfully Closed SQLConnection to: {ConnectionString}");
        }
    }
}
