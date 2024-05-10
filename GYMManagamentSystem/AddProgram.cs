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
    public partial class AddProgram : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\GYMManagamentSystem\GYMManagamentSystem\GYM.mdf;Integrated Security=True;Connect Timeout=30");

        public AddProgram()
        {
            InitializeComponent();
            displayProgramData();
        }
        public void displayProgramData()
        {
            ProgramData pd = new ProgramData();
            List<ProgramData> listData = pd.programListData();

            dataGridView1.DataSource = listData;

        }
        private void back_button_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void movement_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void set_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void repeat_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_program_button_Click(object sender, EventArgs e)
        {
            if (set_textBox.Text == ""
             || repeat_textBox.Text == ""
             || movement_comboBox.Text == ""
             || program_textBox.Text == "")
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
                        string checkEmID = "SELECT COUNT(*) FROM program ";

                        using (SqlCommand checkEm = new SqlCommand(checkEmID, connect))
                        {

                            DateTime today = DateTime.Today;
                            string insertData = "INSERT INTO program " +
                                "(programname, movementname, sets_number,repeats_number) " +
                               "VALUES(@programname, @movementname, @sets_number ,@repeats_number)";



                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@programname", program_textBox.Text.Trim());
                                cmd.Parameters.AddWithValue("@movementname", movement_comboBox.Text.Trim());
                                cmd.Parameters.AddWithValue("@repeats_number", Convert.ToInt32(repeat_textBox.Text.ToString()));
                                cmd.Parameters.AddWithValue("@sets_number", Convert.ToInt32(set_textBox.Text.ToString()));

                                cmd.ExecuteNonQuery();

                                displayProgramData();

                                MessageBox.Show("Added successfully!"
                                    , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();
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

        private void add_movement_button_Click(object sender, EventArgs e)
        {
            if (set_textBox.Text == ""
            || repeat_textBox.Text == ""
            || movement_comboBox.Text == ""
            || program_textBox.Text == "")
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
                        string checkEmID = "SELECT COUNT(*) FROM program ";

                        using (SqlCommand checkEm = new SqlCommand(checkEmID, connect))
                        {

                            DateTime today = DateTime.Today;
                            string insertData = "INSERT INTO program " +
                                "(programname, movementname, sets_number,repeats_number) " +
                               "VALUES(@programname, @movementname, @sets_number ,@repeats_number)";



                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@programname", program_textBox.Text.Trim());
                                cmd.Parameters.AddWithValue("@movementname", movement_comboBox.Text.Trim());
                                cmd.Parameters.AddWithValue("@repeats_number", Convert.ToInt32(repeat_textBox.Text.ToString()));
                                cmd.Parameters.AddWithValue("@sets_number", Convert.ToInt32(set_textBox.Text.ToString()));

                                cmd.ExecuteNonQuery();

                                displayProgramData();

                                MessageBox.Show("Added successfully!"
                                    , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();
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
            set_textBox.Text = "";
            repeat_textBox.Text = "";
            movement_comboBox.SelectedIndex = -1;
            program_textBox.Text = "";
        }

        private void set_textBox_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        private void repeat_textBox_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
