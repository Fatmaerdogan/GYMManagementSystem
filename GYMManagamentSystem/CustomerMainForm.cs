using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class CustomerMainForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\GYMManagamentSystem\GYMManagamentSystem\GYM.mdf;Integrated Security=True;Connect Timeout=30");
        string customer_ID;
        int activeTemp;
        public CustomerMainForm(string value)
        {
            InitializeComponent();
            customer_ID = value;
            FormOpen();
        }

        private void qr_scanning_button_Click(object sender, EventArgs e)
        {
            QRScanningPanel qRScanningPanel = new QRScanningPanel(customer_ID,activeTemp);
            qRScanningPanel.Show();
            this.Hide();
        }
        private void FormOpen()
        {
            if (connect.State == ConnectionState.Closed)
            {

                try
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
                                if(customerID == customer_ID)
                                {
                                    string fullName = reader["fullname"].ToString();
                                    string phoneNumber = reader["phone_number"].ToString();
                                    string gender = reader["gender"].ToString();
                                    string programType = reader["program_type"].ToString();
                                    int age = Convert.ToInt32(reader["age"]);
                                    int weight = Convert.ToInt32(reader["weight"]);
                                    int height = Convert.ToInt32(reader["height"]);
                                    int salary = Convert.ToInt32(reader["salary"]);
                                    int active = Convert.ToInt32(reader["active"]);
                                    activeTemp = active;
                                    float calorie = 66.5f + (13.75f * weight) + (5 * height) - (6.77f * age);
                                    // Örnek olarak label'lara yazdırma
                                    customer_id_label.Text = "Customer ID : " + customerID;
                                    full_name_label.Text = "Full Name : " + fullName;
                                    phone_number_label.Text = "Phone Number : " + phoneNumber;
                                    gender_label.Text = "Gender : " + gender;
                                    age_label.Text = "Age : " + age.ToString();
                                    weight_label.Text = "Weight : " + weight.ToString();
                                    height_label.Text = "Height : " + height.ToString();
                                    active_status_label.Text = "Active Status : " +((active==0)?"Inactive" :"Active");
                                    amount_label.Text="Amount : "+salary.ToString();
                                    daily_calorie_rewuirement_label.Text= "Daily Calorie Rewuirement : "+calorie.ToString();

                                }
                               
                            }
                        }
                    }
                }
        
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }
     
        private void CustomerMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void program_button_Click(object sender, EventArgs e)
        {
            CustomerProgram customerForm = new CustomerProgram(customer_ID);
            customerForm.Show();
            this.Hide();
        }

        private void sign_out_button_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?"
               , "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
        }
    }
}
