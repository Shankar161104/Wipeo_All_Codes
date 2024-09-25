using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Singleton_Practice
{
    public sealed class Logger
    {
        // Static instance of the Logger class
        private static Logger instance;

        // Private constructor to prevent instantiation
        private Logger()
        {
        }

        // Public method to get the single instance of the Logger class
        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }

        // Method to log a message
        public void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }

        public int Addition(int a,int b)
        {
            return a + b;
        }

        public string OpenConnection()
        {
            return "Connection Opened";
        }

        public string CloseConnection()
        {
            return "Connection Closed";
        }
    }
}
