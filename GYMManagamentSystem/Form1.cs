﻿using System;
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
namespace GYMManagamentSystem
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\GYMManagamentSystem\GYMManagamentSystem\GYM.mdf;Integrated Security=True;Connect Timeout=30");

        public Form1()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showpassword.Checked ? '\0' : '*';
        }

        private void login_signup_button_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (login_username.Text == "Salon1"
              && login_password.Text == "123456")
            {
                MessageBox.Show("Login successfully!"
                                    , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MainForm mForm = new MainForm();
                mForm.Show();
                this.Hide();
            }
            else { 
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
                /* if (connect.State == ConnectionState.Closed)
                 {
                     try
                     {
                         connect.Open();

                         string selectData = "SELECT * FROM users WHERE username = @username " +
                             "AND password = @password";

                         using (SqlCommand cmd = new SqlCommand(selectData, connect))
                         {
                             cmd.Parameters.AddWithValue("@username", login_username.Text.Trim());
                             cmd.Parameters.AddWithValue("@password", login_password.Text.Trim());

                             SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                             DataTable table = new DataTable();
                             adapter.Fill(table);

                             if (table.Rows.Count >= 1)
                             {
                                 MessageBox.Show("Login successfully!"
                                     , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                 MainForm mForm = new MainForm();
                                 mForm.Show();
                                 this.Hide();
                             }
                             else
                             {
                                 MessageBox.Show("Incorrect Username/Password"
                                     , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

             */
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void customer_button_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.Show();
            this.Hide();
        }
    }
}