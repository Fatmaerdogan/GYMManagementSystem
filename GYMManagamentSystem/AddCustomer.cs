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
    public partial class AddCustomer : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\GYMManagamentSystem\GYMManagamentSystem\GYM.mdf;Integrated Security=True;Connect Timeout=30");

        string LastCustomerData;
        public AddCustomer()
        {
            InitializeComponent();
            displayCustomerData();
            ProgramTypeSet();
            disableFields();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void disableFields()
        {
            customer_id_textBox.Text = LastCustomerData;
            customer_id_textBox.Enabled = false;
        }
        private void back_button_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
        public void displayCustomerData()
        {
            CustomerData ed = new CustomerData();
            List<CustomerData> listData = ed.customerListData();
            LastCustomerData = "CID" + listData.Count;
        }
        private void add_button_Click(object sender, EventArgs e)
        {
            if (customer_id_textBox.Text == ""
               || full_name_textBox.Text == ""
               || phone_number_textBox.Text == ""
               || age_textBox.Text == ""
               || weight_textBox.Text == ""
               || height_textBox.Text == ""
               || program_type_comboBox.Text == ""
               || salary_textBox.Text == ""
               || gender_comboBox.Text == "")
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                       string checkEmID = "SELECT COUNT(*) FROM customer WHERE customer_id = @cid";

                        using (SqlCommand checkEm = new SqlCommand(checkEmID, connect))
                        {
                            
                            checkEm.Parameters.AddWithValue("@cid", LastCustomerData);
                            int count = (int)checkEm.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(customer_id_textBox.Text.Trim() + " is already taken"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO customer " +
                                    "(customer_id, fullname,phone_number, gender, program_type, age, weight, height, salary,active) " +
                                    "VALUES(@customer_id, @fullName, @phone_number, @gender, @program_type, @age, @weight, @height, @salary,@active)";

                              

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@customer_id", LastCustomerData);
                                    cmd.Parameters.AddWithValue("@fullname", full_name_textBox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@phone_number", phone_number_textBox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@gender", gender_comboBox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@program_type", program_type_comboBox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@age", Convert.ToInt32(age_textBox.Text.ToString()));
                                    cmd.Parameters.AddWithValue("@weight", Convert.ToInt32(weight_textBox.Text.ToString()));
                                    cmd.Parameters.AddWithValue("@height", Convert.ToInt32(height_textBox.Text.ToString()));
                                    cmd.Parameters.AddWithValue("@salary", Convert.ToInt32(salary_textBox.Text.ToString()));
                                    cmd.Parameters.AddWithValue("@active", 0);

                                    cmd.ExecuteNonQuery();

                                    displayCustomerData();

                                    MessageBox.Show("Added successfully!"
                                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    clearFields();
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
        }
        private void clearFields()
        {
            customer_id_textBox.Text = "";
            full_name_textBox.Text = "";
            phone_number_textBox.Text = "";
            age_textBox.Text = "";
            weight_textBox.Text = "";
            height_textBox.Text = "";
            salary_textBox.Text = "";
            gender_comboBox.SelectedIndex = -1;
            program_type_comboBox.SelectedIndex = -1;
        }
        public void ProgramTypeSet()
        {
            if (connect.State == ConnectionState.Closed)
            {

                try
                {
                    connect.Open();
                    string sqlQuery = "SELECT * FROM program"; 

                    using (SqlCommand command = new SqlCommand(sqlQuery, connect))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string programname = reader["programname"].ToString();
                                if (!program_type_comboBox.Items.Contains( programname)) program_type_comboBox.Items.Add(programname);
                                
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
 
        private void clear_button_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void program_type_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void customer_id_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void full_name_textBox_TextChanged(object sender, EventArgs e){}
        private void weight_textBox_TextChanged(object sender, EventArgs e) { }
        private void full_name_textBox_KeyPress(object sender, KeyPressEventArgs e)=>e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)&& !char.IsSeparator(e.KeyChar);

        private void phone_number_textBox_KeyPress(object sender, KeyPressEventArgs e)=>e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        private void age_textBox_KeyPress(object sender, KeyPressEventArgs e)=> e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        private void weight_textBox_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        private void height_textBox_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        private void salary_textBox_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
    }
}
