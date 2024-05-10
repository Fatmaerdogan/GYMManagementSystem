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
using System.Windows.Forms;

namespace GYMManagamentSystem
{
    internal class ProgramData
    {
        public int ID { set; get; } // 0
        public string ProgramName { set; get; } // 1
        public string MovementName { set; get; } // 2
        public int RepeatNumber { set; get; } // 3
        public int SetNumber { set; get; } // 4

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\GYMManagamentSystem\GYMManagamentSystem\GYM.mdf;Integrated Security=True;Connect Timeout=30");
        
        public List<ProgramData> programListData()
        {
            List<ProgramData> listdata = new List<ProgramData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM program";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            ProgramData pd = new ProgramData();
                            pd.ProgramName = reader["programname"].ToString();
                            pd.MovementName = reader["movementname"].ToString();
                            pd.RepeatNumber = (int)reader["repeats_number"];
                            pd.SetNumber = (int)reader["sets_number"];

                            listdata.Add(pd);
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
        public List<ProgramData> programCustomerListData(string _programname)
        {
            List<ProgramData> listdata = new List<ProgramData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM program";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {

                            ProgramData pd = new ProgramData();
                            if (reader["programname"].ToString() == _programname)
                            {
                                pd.ProgramName = reader["programname"].ToString();
                                pd.MovementName = reader["movementname"].ToString();
                                pd.RepeatNumber = (int)reader["repeats_number"];
                                pd.SetNumber = (int)reader["sets_number"];

                                listdata.Add(pd);
                            }

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

