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
    public partial class Dashboard : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\GYMManagamentSystem\GYMManagamentSystem\GYM.mdf;Integrated Security=True;Connect Timeout=30");

        public Dashboard()
        {
            InitializeComponent();
            displayCustomerData();
            ProgramTypeSet();
        }
        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }

            displayCustomerData();
            disableFields();
        }
        public void disableFields()
        {
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

            dataGridView1.DataSource = listData;

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                customer_id_textBox.Text = row.Cells[1].Value.ToString();
                full_name_textBox.Text = row.Cells[2].Value.ToString();
                phone_number_textBox.Text = row.Cells[3].Value.ToString();
                gender_comboBox.Text = row.Cells[4].Value.ToString();
                program_type_comboBox.Text = row.Cells[5].Value.ToString();
                age_textBox.Text = row.Cells[6].Value.ToString();
                weight_textBox.Text = row.Cells[7].Value.ToString();
                height_textBox.Text = row.Cells[8].Value.ToString();
            }
            disableFields();
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
                                if (!program_type_comboBox.Items.Contains(programname)) program_type_comboBox.Items.Add(programname);

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
        private void weight_textBox_TextChanged(object sender, EventArgs e) { }
        private void height_textBox_TextChanged(object sender, EventArgs e) { }
        private void phone_number_textBox_TextChanged(object sender, EventArgs e) { }
        private void full_name_textBox_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);

        private void phone_number_textBox_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        private void age_textBox_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        private void weight_textBox_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        private void height_textBox_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (customer_id_textBox.Text == ""
               || full_name_textBox.Text == ""
               || phone_number_textBox.Text == ""
               || gender_comboBox.Text == ""
               || program_type_comboBox.Text == ""
               || age_textBox.Text == ""
               || weight_textBox.Text == ""
               || height_textBox.Text == "")
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to DELETE " +
                    "Full name: " + full_name_textBox.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

                        string updatData = "DELETE FROM customer WHERE customer_id = @customer_id ";

                        using (SqlCommand cmd = new SqlCommand(updatData, connect))
                        {
                            cmd.Parameters.AddWithValue("@customer_id", customer_id_textBox.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayCustomerData();

                            MessageBox.Show("Update successfully!"
                                , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                            RefreshData();
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
                else
                {
                    MessageBox.Show("Cancelled."
                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            if (full_name_textBox.Text == ""
               || customer_id_textBox.Text == ""
               || phone_number_textBox.Text == ""
               || gender_comboBox.Text == ""
               || program_type_comboBox.Text == ""
               || age_textBox.Text == ""
               || weight_textBox.Text == ""
               || height_textBox.Text == "")
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE " +
                    "Full name: " + full_name_textBox.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

                        string insertData = "UPDATE customer SET fullname = @fullName,phone_number= @phone_number,gender=@gender,program_type=@program_type,age=@age,weight=@weight,height=@height WHERE customer_id = @customer_id ";

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@customer_id", customer_id_textBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@fullname", full_name_textBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@phone_number", phone_number_textBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@gender", gender_comboBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@program_type", program_type_comboBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@age", Convert.ToInt32(age_textBox.Text.ToString()));
                            cmd.Parameters.AddWithValue("@weight", Convert.ToInt32(weight_textBox.Text.ToString()));
                            cmd.Parameters.AddWithValue("@height", Convert.ToInt32(height_textBox.Text.ToString()));

                            cmd.ExecuteNonQuery();

                            displayCustomerData();

                            MessageBox.Show("Update successfully!"
                                , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                            RefreshData();
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
                else
                {
                    MessageBox.Show("Cancelled."
                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
        private void clearFields()
        {
            full_name_textBox.Text = "";
            customer_id_textBox.Text = "";
            phone_number_textBox.Text = "";
            age_textBox.Text = "";
            weight_textBox.Text = "";
            height_textBox.Text = "";
            gender_comboBox.SelectedIndex = -1;
            program_type_comboBox.SelectedIndex = -1;
        }
    }
}

