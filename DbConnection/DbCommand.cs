using System;


namespace DbConnection
{
    public class DbCommand
    {
        private readonly string _command;

        private readonly DbConnection _dbConnection;

        public DbCommand(string command, DbConnection dbConnection)
        {
            if(dbConnection == null)
                throw new ArgumentNullException(command, $"Database must be provided, aborting execution.");

            if (string.IsNullOrWhiteSpace(command))
                throw new ArgumentNullException(command, $"Command is empty no execution was commited to connection {dbConnection}");

            this._command = command;
            this._dbConnection = dbConnection;
        }

        public void Execute()
        {
            _dbConnection.Open();
            Console.WriteLine($"Executing Command {_command} via {_dbConnection}.");
            _dbConnection.Close();
        }
    }
}
