using System;

namespace Wipro_Solid_ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ISqlDataProvider sqlProvider = new SqlDataClient();
            sqlProvider.OpenConnection();
            sqlProvider.CloseConnection();
            sqlProvider.ExecuteSqlCommand();

            
            IOracleDataProvider oracleProvider = new SqlDataClient(); 
            oracleProvider.OpenConnection();
            oracleProvider.CloseConnection();
            oracleProvider.ExecuteOralceCommand(); 

            Console.ReadLine();
        }
    }

    class SqlDataClient : ISqlDataProvider, IOracleDataProvider
    {
        public int OpenConnection()
        {
            Console.WriteLine("Sql Data Client Opened");
            return 1;
        }

        public int CloseConnection()
        {
            Console.WriteLine("Sql Data Client Closed");
            return 1;
        }

        public int ExecuteSqlCommand()
        {
            Console.WriteLine("Sql Command Executed");
            return 1;
        }

        
        public int ExecuteOralceCommand()
        {
            Console.WriteLine("Oracle Command Executed");
            return 1;
        }
    }

    interface IDataProvider
    {
        int OpenConnection();
        int CloseConnection();
    }

    interface ISqlDataProvider : IDataProvider
    {
        int ExecuteSqlCommand();
    }

    interface IOracleDataProvider : IDataProvider
    {
        int ExecuteOralceCommand();
    }
}
