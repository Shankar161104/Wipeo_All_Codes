using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_27_08_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=WiproDFA_26_08_2024;Integrated Security=True");
            CustomerOrderDetails("InnerJoinCustomerOrder", con);
            Console.ReadLine();

        }
        public static void CustomerOrderDetails(string InnerJoinprocedure, SqlConnection con)
        {
            using (SqlCommand cmd = new SqlCommand(InnerJoinprocedure, con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                List<CustomerOrder> lstCustomerOrder = new List<CustomerOrder>();

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        CustomerOrder objCustomerOrder = new CustomerOrder
                        {
                            CustomerId = Convert.ToInt32(row["CustomerId"]),
                            Name = row["Name"].ToString(),
                            Email = row["Email"].ToString(),
                            OrderHistory = row["OrderHistory"].ToString(),
                            Reviews = row["Reviews"].ToString(),
                            OrderProduct = row["OrderProduct"].ToString(),
                            TotalAmount = Convert.ToInt32(row["TotalAmount"]),
                        };
                        lstCustomerOrder.Add(objCustomerOrder);
                    }

                    Console.WriteLine("*********************************** Customer and Order Details *********************************************");
                    Console.WriteLine();
                    foreach (var type in lstCustomerOrder)
                    {
                        Console.WriteLine($"Customer Id:{type.CustomerId} Name:{type.Name} Email:{type.Email} Order History:{type.OrderHistory} Reviews:{type.Reviews} OrderProduct:{type.OrderProduct} Total Amount:{type.TotalAmount}");
                        Console.WriteLine("===========================================================================================================");
                    }
                }
                else
                {
                    Console.WriteLine("No records found.");
                }
            }
        }
    }
}
