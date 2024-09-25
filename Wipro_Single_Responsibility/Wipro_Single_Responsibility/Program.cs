using System;

namespace Wipro_Single_Responsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Connection objConnection = new Connection();

            
            objConnection.Dial("123-456-7890");

          
            char result = objConnection.Hangup();
            Console.WriteLine("Hangup returned: " + result);
        }
    }

    
    public interface IConnection
    {
        void Dial(string phone);
        char Hangup();
    }

  
    public interface IDataChannel
    {
        void Send(char c);
        char Recv();
    }

    
    public class Connection : IConnection
    {
        public void Dial(string phone)
        {
            
            Console.WriteLine("Dialing: " + phone);
        }

        public char Hangup()
        {
           
            char c = 'a';
            Console.WriteLine("Hanging up...");
            return c;
        }
    }

   
    public class DataChannel : IDataChannel
    {
        public void Send(char c)
        {
            
            Console.WriteLine("Sending data: " + c);
        }

        public char Recv()
        {
            
            char c = 'b';
            Console.WriteLine("Receiving data...");
            return c;
        }
    }
}
