using System;


namespace DbConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(":~$ Run command on SQL DB");
                var sqlConnection = new SqlConnection(1000, "db005");
                var dbSqlCommand = new DbCommand("SELECT * FROM Customer", sqlConnection);
                dbSqlCommand.Execute();

                Console.WriteLine("\n:> Run command on ORA DB");
                var oraConnection = new OracleConnection(1000, "exa04");
                var dbOraCommand = new DbCommand("DELETE * FROM Company", oraConnection);
                dbOraCommand.Execute();
            }
            catch (Exception err)
            {
                Console.WriteLine(err); ;
            }


        }
    }
}
