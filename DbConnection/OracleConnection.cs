using System;

namespace DbConnection
{
    public class OracleConnection : DbConnection
    {

        public OracleConnection(int timeout, string connectionString) : base(timeout, connectionString)
        {
            Console.WriteLine("Oracle Database Connection created.");
        }

        public override void Open()
        {
            System.Console.WriteLine($"Successfully Opened OracleConnection to {ConnectionString}, before {Timeout.TotalMilliseconds:F2}ms.");
        }

        public override void Close()
        {
            System.Console.WriteLine($"Successfully Closed OracleConnection to: {ConnectionString}");
        }
    }
}
