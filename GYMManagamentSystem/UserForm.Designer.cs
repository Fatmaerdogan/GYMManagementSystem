namespace GYMManagamentSystem
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.customer_login_showpassword = new System.Windows.Forms.CheckBox();
            this.customer_login_button = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.Label();
            this.customer_login_id = new System.Windows.Forms.TextBox();
            this.customer_login_username = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.personel_button = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(108, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "CUSTOMER";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(106, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 39);
            this.label6.TabIndex = 12;
            this.label6.Text = "SYSTEM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(53, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 39);
            this.label5.TabIndex = 11;
            this.label5.Text = "MANAGEMENT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(137, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 39);
            this.label4.TabIndex = 10;
            this.label4.Text = "GYM";
            // 
            // customer_login_showpassword
            // 
            this.customer_login_showpassword.AutoSize = true;
            this.customer_login_showpassword.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customer_login_showpassword.Location = new System.Drawing.Point(652, 359);
            this.customer_login_showpassword.Name = "customer_login_showpassword";
            this.customer_login_showpassword.Size = new System.Drawing.Size(96, 23);
            this.customer_login_showpassword.TabIndex = 17;
            this.customer_login_showpassword.Text = "Show ID";
            this.customer_login_showpassword.UseVisualStyleBackColor = true;
            this.customer_login_showpassword.CheckedChanged += new System.EventHandler(this.customer_login_showpassword_CheckedChanged);
            // 
            // customer_login_button
            // 
            this.customer_login_button.BackColor = System.Drawing.Color.White;
            this.customer_login_button.FlatAppearance.BorderSize = 0;
            this.customer_login_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(112)))));
            this.customer_login_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.customer_login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customer_login_button.Location = new System.Drawing.Point(507, 427);
            this.customer_login_button.Name = "customer_login_button";
            this.customer_login_button.Size = new System.Drawing.Size(176, 57);
            this.customer_login_button.TabIndex = 16;
            this.customer_login_button.Text = "LOGIN";
            this.customer_login_button.UseVisualStyleBackColor = false;
            this.customer_login_button.Click += new System.EventHandler(this.customer_login_button_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.password.Location = new System.Drawing.Point(400, 294);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(122, 19);
            this.password.TabIndex = 15;
            this.password.Text = "Customer ID :";
            // 
            // customer_login_id
            // 
            this.customer_login_id.Location = new System.Drawing.Point(404, 327);
            this.customer_login_id.Name = "customer_login_id";
            this.customer_login_id.PasswordChar = '*';
            this.customer_login_id.Size = new System.Drawing.Size(392, 26);
            this.customer_login_id.TabIndex = 14;
            // 
            // customer_login_username
            // 
            this.customer_login_username.Location = new System.Drawing.Point(404, 215);
            this.customer_login_username.Name = "customer_login_username";
            this.customer_login_username.Size = new System.Drawing.Size(392, 26);
            this.customer_login_username.TabIndex = 13;
            this.customer_login_username.TextChanged += new System.EventHandler(this.customer_login_username_TextChanged);
            this.customer_login_username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.customer_login_username_KeyPress);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.username.Location = new System.Drawing.Point(400, 183);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(101, 19);
            this.username.TabIndex = 12;
            this.username.Text = "Full Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(398, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "LOGIN ACCOUNT";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(147)))), ((int)(((byte)(175)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.personel_button);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 593);
            this.panel1.TabIndex = 10;
            // 
            // personel_button
            // 
            this.personel_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(147)))), ((int)(((byte)(175)))));
            this.personel_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.personel_button.Location = new System.Drawing.Point(31, 518);
            this.personel_button.Name = "personel_button";
            this.personel_button.Size = new System.Drawing.Size(323, 44);
            this.personel_button.TabIndex = 15;
            this.personel_button.Text = "PERSONEL ENTRY";
            this.personel_button.UseVisualStyleBackColor = true;
            this.personel_button.Click += new System.EventHandler(this.personel_button_Click);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exit.Location = new System.Drawing.Point(859, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(27, 27);
            this.exit.TabIndex = 18;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(41, 487);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(422, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "SWITCH TO PERSONEL ACCOUNT";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(898, 593);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.customer_login_showpassword);
            this.Controls.Add(this.customer_login_button);
            this.Controls.Add(this.password);
            this.Controls.Add(this.customer_login_id);
            this.Controls.Add(this.customer_login_username);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox customer_login_showpassword;
        private System.Windows.Forms.Button customer_login_button;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox customer_login_id;
        private System.Windows.Forms.TextBox customer_login_username;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Button personel_button;
        private System.Windows.Forms.Label label3;
    }
}