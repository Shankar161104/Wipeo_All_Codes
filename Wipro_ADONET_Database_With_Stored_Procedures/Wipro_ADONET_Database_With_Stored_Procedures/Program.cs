using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_ADONET_Database_With_Stored_Procedures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Wipro_Procedure_20_08_2024;Integrated Security=True");
            start:
            string strSelectAllQuery = "SelectStudentDetails";
            Console.WriteLine("Enter 1.Select 2.Insert 3.Update 4.Delete");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    SelectStudent(con,strSelectAllQuery);
                    break;
                case 2:
                    InsertStudent(con);
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

        public static void InsertStudent(SqlConnection con)
        {
            Console.WriteLine("Enter the Student Name");
            string stuName= Console.ReadLine();
            
           
            Console.WriteLine("Enter the Student Email");
            
            string stuEmail = Console.ReadLine(); 
            Console.WriteLine("Enter the Student Age");
            int stuAge= Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter the Student Contact");
            
            string stuContact= Console.ReadLine();



            try
            {
                SqlCommand com = new SqlCommand("InsertStudentDetails", con);
                com.CommandType = CommandType.StoredProcedure;
                SqlParameter paramter = new SqlParameter();

                paramter.ParameterName = "@StudentName";

                paramter.SqlDbType = SqlDbType.NVarChar;

                paramter.Value = stuName;

                com.Parameters.Add(paramter);

                com.Parameters.AddWithValue("@StudentEmail", stuEmail);

                com.Parameters.AddWithValue("@StudentAge", stuAge);
                com.Parameters.AddWithValue("@StudentMobile", stuContact);


                con.Open();

                int i = com.ExecuteNonQuery();

                con.Close();

                if (i != 0)

                {
                    Console.WriteLine(i + "Data Saved");

                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }




          
      }


        public static void SelectStudent(SqlConnection con, string strSelectAllQuery)
        {
            SqlCommand cmd = new SqlCommand("SelectStudentDetails",con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0) 
            { 
               for(int i = 0; i < ds.Tables.Count; i++)
                {
                    int StudentID = Convert.ToInt32(ds.Tables[0].Rows[i]["StudentID"].ToString());
                    string StudentName = ds.Tables[0].Rows[i]["StudentName"].ToString();
                    string StudentEmail = ds.Tables[0].Rows[i]["StudentEmail"].ToString();
                    int StudentAge = Convert.ToInt32(ds.Tables[0].Rows[i]["StudentAge"].ToString());
                    string StudentMobile = ds.Tables[0].Rows[i]["StudentMobile"].ToString();

                    Console.WriteLine($"StudentID::{StudentID}   StudentName::{StudentName}   StudentEmail::{StudentEmail}  StudentAge::{StudentAge}   StudentMobile::{StudentMobile}");


                }
            
            }

        }
    }
}
