using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace GYMManagamentSystem
{
    internal class CustomerData
    {
        public int ID { set; get; } // 0
        public string CustomerID { set; get; } // 1
        public string FullName { set; get; } // 2
        public string PhoneNumber { set; get; } // 2
        public string Gender { set; get; } // 3
        public string ProgramType { set; get; } // 4
        public int Age { set; get; } // 5
        public int Weight { set; get; } // 6
        public int Height { set; get; } // 6
        public int Salary { set; get; } // 7
        public string Active { set; get; } // 8


        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\GYMManagamentSystem\GYMManagamentSystem\GYM.mdf;Integrated Security=True;Connect Timeout=30");


        public List<CustomerData> customerListData()
        {
            List<CustomerData> listdata = new List<CustomerData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM customer";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            CustomerData cd = new CustomerData();
                            cd.ID = (int)reader["id"];
                            cd.CustomerID = reader["customer_id"].ToString();
                            cd.FullName = reader["fullname"].ToString();
                            cd.PhoneNumber = reader["phone_number"].ToString();
                            cd.Gender = reader["gender"].ToString();
                            cd.ProgramType = reader["program_type"].ToString();
                            cd.Age = (int)reader["age"];
                            cd.Weight = (int)reader["weight"];
                            cd.Height = (int)reader["height"];
                            cd.Salary = (int)reader["salary"];
                            cd.Active = (((int)reader["active"] == 0) ? "Inactive" : "Active");

                            listdata.Add(cd);
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listdata;
        }

      
    }
}