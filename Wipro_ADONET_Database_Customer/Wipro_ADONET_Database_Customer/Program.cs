using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_ADONET_Database_Customer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SqlConnection con = new SqlConnection(
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Wipro2_20_08_2024;Integrated Security=True");
            start:
            string strSelectAllQuery = "Select * from Customer";
            Console.WriteLine("Enter 1.Select 2.Insert 3.Update 4.Delete");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    DisplayCustomerData(con, strSelectAllQuery);
                    break;
                case 2:
                    InsertCustomer(con);
                    break;
                default:
                    Console.WriteLine("Wrong choice");
                    break;
            }

            Console.WriteLine("Do you want to continue?(Y/N)");
            char ch1 = Convert.ToChar(Console.ReadLine());

            if (ch1 == 'Y' || ch1 == 'y')
            {
                goto start;
            }




            Console.ReadLine();
        }

        public static void UpdateCustomer()
        {

        }





        public static void InsertCustomer(SqlConnection con)
        {
            Console.WriteLine("Enter the Customer ID");
            int CustID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Customer Name");
            string CustName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the Customer Age");
            int CustAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Customer Gender");
            string CustGender = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the Customer City");
            string CustCity = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the Customer Email");
            string CustEmail = Convert.ToString(Console.ReadLine());

            string strInsertQuery = $"insert into Customer values('{CustID}','{CustName}','{CustAge}','{CustGender}','{CustCity}','{CustEmail}')";
            try
            {
                SqlCommand com = new SqlCommand(strInsertQuery,con);
                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();
                if (i != 0)
                {
                    Console.WriteLine(i+"Data saved");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }



        public static void DisplayCustomerData(SqlConnection con, string strSelectAllQuery)
        {

            SqlCommand cmd = new SqlCommand("Select * from Customer", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    int CustID = Convert.ToInt32(ds.Tables[0].Rows[i]["CustID"].ToString());
                    string CustName = ds.Tables[0].Rows[i]["CustName"].ToString();
                    int CustAge = Convert.ToInt32(ds.Tables[0].Rows[i]["CustAge"].ToString());
                    string CustGender = ds.Tables[0].Rows[i]["CustGender"].ToString();
                    string CustCity = ds.Tables[0].Rows[i]["CustCity"].ToString();
                    string CustEmail = ds.Tables[0].Rows[i]["CustEmail"].ToString();

                    
                    
                    Console.WriteLine($"CustID::{CustID}   CustName::{CustName}  CustAge::{CustAge}  CustGender::{CustGender}  CustCity::{CustCity}  CustEmail::{CustEmail}  ");

                }
            }

        }

    }
}
