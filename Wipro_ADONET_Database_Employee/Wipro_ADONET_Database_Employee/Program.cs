using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_ADONET_Database_Employee
{
    public class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Wipro_20_08_2024;Integrated Security=True");
        start:
            string strSelectAllQuery = "Select * from Employee";
            Console.WriteLine("Enter 1.Select 2.Insert 3.Update 4.Delete");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    DisplayEmployeeData(con, strSelectAllQuery);
                    break;
                case 2:
                    InsertEmployee(con);
                    break;
                case 3:
                    UpdateEmployee(con);
                    break;
                case 4:
                    DeleteEmployee(con);
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

        public static void DeleteEmployee(SqlConnection con)
        {
            Console.WriteLine("Enter the Employee ID of the record you want to delete");
            int EmpID = Convert.ToInt32(Console.ReadLine());
            string strSelectOneQuery = $"select * from Employee where EmpID={EmpID}";
            DisplayEmployeeData(con, strSelectOneQuery);
            Console.WriteLine("Do you want to update?(Y/N)");
            char ch1 = Convert.ToChar(Console.ReadLine());
            if (ch1 == 'Y' || ch1 == 'y')
            {
                string strDeleteQuery = $"delete from Employee where EmpID={EmpID}";
                try
                {
                    SqlCommand com = new SqlCommand(strDeleteQuery, con);
                    con.Open();
                    int i = com.ExecuteNonQuery();
                    con.Close();
                    if (i != 0)
                    {
                        Console.WriteLine(i + "Data deleted EmpID::" + EmpID);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }









        public static void UpdateEmployee(SqlConnection con)
        {
            Console.WriteLine("Enter the Employee ID");
            int EmpID = Convert.ToInt32(Console.ReadLine());
            string strSelectOneQuery = $"select * from Employee where EmpID={EmpID}";
            DisplayEmployeeData(con, strSelectOneQuery);
            Console.WriteLine("Do you want to update?(Y/N)");
            char ch1 = Convert.ToChar(Console.ReadLine());

            if (ch1 == 'Y' || ch1 == 'y')
            {
                Console.WriteLine("Enter the Employee Name");
                string EmpName = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter the Employee Address");
                string EmpAddress = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter the Employee Contact");
                string EmpContact = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter the Employee Salary");
                float EmpSalary = float.Parse(Console.ReadLine());
                string strUpdateQuery = $"update Employee set EmpName='{EmpName}',EmpAddress='{EmpAddress}', EmpContact='{EmpContact}',  EmpSalary='{EmpSalary}' where EmpID='{EmpID}'";
                try
                {
                    SqlCommand com = new SqlCommand(strUpdateQuery, con);
                    con.Open();
                    int i = com.ExecuteNonQuery();
                    con.Close();
                    if (i != 0)
                    {
                        Console.WriteLine(i + "Data updated");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


            }
        }









        public static void DisplayEmployeeData(SqlConnection con, string strSelectAllQuery)
        {

            SqlCommand cmd = new SqlCommand("Select * from Employee", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    int EmpID = Convert.ToInt32(ds.Tables[0].Rows[i]["EmpId"].ToString());
                    string EmpName = ds.Tables[0].Rows[i]["EmpName"].ToString();
                    string EmpAddress = ds.Tables[0].Rows[i]["EmpAddress"].ToString();
                    string EmpContact = ds.Tables[0].Rows[i]["EmpContact"].ToString();
                    decimal EmpSalary = Convert.ToDecimal(ds.Tables[0].Rows[i]["EmpSalary"].ToString());
                    Console.WriteLine($"EmpID::{EmpID}   EmpName::{EmpName}  EmpAddress::{EmpAddress}  EmpContact::{EmpContact}  EmpSalary::{EmpSalary}");
                }
            }

        }

        public static void InsertEmployee(SqlConnection con)
        {

            Console.WriteLine("Enter the Employee Name");
            string EmpName = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter the Employee Address");
            string EmpAddress = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter the Employee Contact");
            string EmpContact = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter the Employee Salary");
            float EmpSalary = float.Parse(Console.ReadLine());

            string strInsertQuery = $"insert into Employee values('{EmpName}','{EmpAddress}','{EmpContact}','{EmpSalary}')";
            try
            {
                SqlCommand com = new SqlCommand(strInsertQuery, con);
                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();
                if (i != 0)
                {
                    Console.WriteLine(i + "Data saved");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
