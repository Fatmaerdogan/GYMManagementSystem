using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace GYMManagamentSystem
{
    public partial class CustomerProgram : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\GYMManagamentSystem\GYMManagamentSystem\GYM.mdf;Integrated Security=True;Connect Timeout=30");

        string customer_ID;
        public CustomerProgram(string value)
        {
            InitializeComponent();
            customer_ID = value;
            displayProgramData();
        }
        public void displayProgramData()
        {
            ProgramData pd = new ProgramData();
            List<ProgramData> listData = pd.programCustomerListData(GetProgramType());

            dataGridView1.DataSource = listData;

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            CustomerMainForm mainForm = new CustomerMainForm(customer_ID);
            mainForm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private string GetProgramType()
        {
            if (connect.State == ConnectionState.Closed)
            {

                    connect.Open();
                    string sqlQuery = "SELECT * FROM customer"; // Tüm CUSTOMER tablosundaki verileri al

                    using (SqlCommand command = new SqlCommand(sqlQuery, connect))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                            string customerID = reader["customer_id"].ToString();
                            if (customerID == customer_ID)
                                {
                                    string programType = reader["program_type"].ToString();
                                    return programType;
                                }

                            }
                        }
                    }
                connect.Close();
            }
            return null;
        }
    }
}
