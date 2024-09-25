using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Wipro_AOONET_22_08_2024
{
    public class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Wipro_21_08_2024;Integrated Security=True");

        start:
            Console.WriteLine("Enter \n1.Select Employees \n2.Insert Employee \n3.Update Employee \n4.Delete Employee \n5.Select Customers \n6.Insert Customer \n7.Update Customer \n8.Delete Customer \n9.Display Employee with Department");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    DisplayEmployeeData(con);
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
                case 5:
                    DisplayCustomerData(con);
                    break;
                case 6:
                    InsertCustomer(con);
                    break;
                case 7:
                    UpdateCustomer(con);
                    break;
                case 8:
                    DeleteCustomer(con);
                    break;
                case 9:
                    DisplayEmployeeDeptDetails(con);
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

            con.Close();
        }

        public static void DisplayEmployeeData(SqlConnection con)
        {
            var employees = new List<(int EmpID, string EmpName, decimal EmpSal, string EmpEmail, string EmpCity, int EmpAge, string EmpQualification, int DeptID)>();

            SqlCommand cmd = new SqlCommand("SelectEmployees", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                employees.Add((
                    Convert.ToInt32(row["EmpID"]),
                    row["EmpName"].ToString(),
                    Convert.ToDecimal(row["EmpSal"]),
                    row["EmpEmail"].ToString(),
                    row["EmpCity"].ToString(),
                    Convert.ToInt32(row["EmpAge"]),
                    row["EmpQualification"].ToString(),
                    Convert.ToInt32(row["DeptID"])
                ));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"EmpID: {emp.EmpID}, Name: {emp.EmpName}, Salary: {emp.EmpSal}, Email: {emp.EmpEmail}, City: {emp.EmpCity}, Age: {emp.EmpAge}, Qualification: {emp.EmpQualification}, DeptID: {emp.DeptID}");
            }
        }

        public static void InsertEmployee(SqlConnection con)
        {
            Console.WriteLine("Enter the Employee Name");
            string EmpName = Console.ReadLine();

            Console.WriteLine("Enter the Employee Salary");
            decimal EmpSal = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter the Employee Email");
            string EmpEmail = Console.ReadLine();

            Console.WriteLine("Enter the Employee City");
            string EmpCity = Console.ReadLine();

            Console.WriteLine("Enter the Employee Age");
            int EmpAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Employee Qualification");
            string EmpQualification = Console.ReadLine();

            Console.WriteLine("Enter the Department ID");
            int DeptID = Convert.ToInt32(Console.ReadLine());

            SqlCommand cmd = new SqlCommand("InsertEmployee1", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@EmpName", EmpName);
            cmd.Parameters.AddWithValue("@EmpSal", EmpSal);
            cmd.Parameters.AddWithValue("@EmpEmail", EmpEmail);
            cmd.Parameters.AddWithValue("@EmpCity", EmpCity);
            cmd.Parameters.AddWithValue("@EmpAge", EmpAge);
            cmd.Parameters.AddWithValue("@EmpQualification", EmpQualification);
            cmd.Parameters.AddWithValue("@DeptID", DeptID);

            try
            {
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                Console.WriteLine($"{rowsAffected} row(s) inserted.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public static void UpdateEmployee(SqlConnection con)
        {
            Console.WriteLine("Enter the Employee ID");
            int EmpID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the new Employee Name");
            string EmpName = Console.ReadLine();

            Console.WriteLine("Enter the new Employee Salary");
            decimal EmpSal = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter the new Employee Email");
            string EmpEmail = Console.ReadLine();

            Console.WriteLine("Enter the new Employee City");
            string EmpCity = Console.ReadLine();

            Console.WriteLine("Enter the new Employee Age");
            int EmpAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the new Employee Qualification");
            string EmpQualification = Console.ReadLine();

            Console.WriteLine("Enter the new Department ID");
            int DeptID = Convert.ToInt32(Console.ReadLine());

            SqlCommand cmd = new SqlCommand("UpdateEmployee", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@EmpID", EmpID);
            cmd.Parameters.AddWithValue("@EmpName", EmpName);
            cmd.Parameters.AddWithValue("@EmpSal", EmpSal);
            cmd.Parameters.AddWithValue("@EmpEmail", EmpEmail);
            cmd.Parameters.AddWithValue("@EmpCity", EmpCity);
            cmd.Parameters.AddWithValue("@EmpAge", EmpAge);
            cmd.Parameters.AddWithValue("@EmpQualification", EmpQualification);
            cmd.Parameters.AddWithValue("@DeptID", DeptID);

            try
            {
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                Console.WriteLine($"{rowsAffected} row(s) updated.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public static void DeleteEmployee(SqlConnection con)
        {
            Console.WriteLine("Enter the Employee ID of the record you want to delete");
            int EmpID = Convert.ToInt32(Console.ReadLine());

            SqlCommand cmd = new SqlCommand("DeleteEmployee", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@EmpID", EmpID);

            try
            {
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                Console.WriteLine($"{rowsAffected} row(s) deleted.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public static void DisplayCustomerData(SqlConnection con)
        {
            var customers = new List<(int CustID, string CustName, string CustAddress, string CustomerCountry)>();

            SqlCommand cmd = new SqlCommand("SelectCustomers", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                customers.Add((
                    Convert.ToInt32(row["CustID"]),
                    row["CustName"].ToString(),
                    row["CustAddress"].ToString(),
                    row["CustomerCountry"].ToString()
                ));
            }

            foreach (var cust in customers)
            {
                Console.WriteLine($"CustID: {cust.CustID}, Name: {cust.CustName}, Address: {cust.CustAddress}, Country: {cust.CustomerCountry}");
            }
        }

        public static void InsertCustomer(SqlConnection con)
        {
            Console.WriteLine("Enter the Customer Name");
            string CustName = Console.ReadLine();

            Console.WriteLine("Enter the Customer Address");
            string CustAddress = Console.ReadLine();

            Console.WriteLine("Enter the Customer Country");
            string CustomerCountry = Console.ReadLine();

            SqlCommand cmd = new SqlCommand("InsertCustomer", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@CustName", CustName);
            cmd.Parameters.AddWithValue("@CustAddress", CustAddress);
            cmd.Parameters.AddWithValue("@CustomerCountry", CustomerCountry);

            try
            {
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                Console.WriteLine($"{rowsAffected} row(s) inserted.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public static void UpdateCustomer(SqlConnection con)
        {
            Console.WriteLine("Enter the Customer ID");
            int CustID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the new Customer Name");
            string CustName = Console.ReadLine();

            Console.WriteLine("Enter the new Customer Address");
            string CustAddress = Console.ReadLine();

            Console.WriteLine("Enter the new Customer Country");
            string CustomerCountry = Console.ReadLine();

            SqlCommand cmd = new SqlCommand("UpdateCustomer", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@CustID", CustID);
            cmd.Parameters.AddWithValue("@CustName", CustName);
            cmd.Parameters.AddWithValue("@CustAddress", CustAddress);
            cmd.Parameters.AddWithValue("@CustomerCountry", CustomerCountry);

            try
            {
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                Console.WriteLine($"{rowsAffected} row(s) updated.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public static void DeleteCustomer(SqlConnection con)
        {
            Console.WriteLine("Enter the Customer ID of the record you want to delete");
            int CustID = Convert.ToInt32(Console.ReadLine());

            SqlCommand cmd = new SqlCommand("DeleteCustomer", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@CustID", CustID);

            try
            {
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                Console.WriteLine($"{rowsAffected} row(s) deleted.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public static void DisplayEmployeeDeptDetails(SqlConnection con)
        {
            var employeeDeptDetails = new List<(int EmpID, string EmpName, decimal EmpSal, string EmpEmail, string EmpCity, int EmpAge, string EmpQualification, int DeptID, string DeptName)>();

            SqlCommand cmd = new SqlCommand("EmpDeptDetails", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                employeeDeptDetails.Add((
                    Convert.ToInt32(row["EmpID"]),
                    row["EmpName"].ToString(),
                    Convert.ToDecimal(row["EmpSal"]),
                    row["EmpEmail"].ToString(),
                    row["EmpCity"].ToString(),
                    Convert.ToInt32(row["EmpAge"]),
                    row["EmpQualification"].ToString(),
                    Convert.ToInt32(row["DeptID"]),
                    row["DeptName"].ToString()
                ));
            }

            foreach (var item in employeeDeptDetails)
            {
                Console.WriteLine($"EmpID: {item.EmpID}, Name: {item.EmpName}, Salary: {item.EmpSal}, Email: {item.EmpEmail}, City: {item.EmpCity}, Age: {item.EmpAge}, Qualification: {item.EmpQualification}, DeptID: {item.DeptID}, DeptName: {item.DeptName}");
            }
        }
    }
}
