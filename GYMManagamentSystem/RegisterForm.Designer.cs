namespace GYMManagamentSystem
{
    partial class RegisterForm
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
            this.signup_showpassword = new System.Windows.Forms.CheckBox();
            this.singup_login_button = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.Label();
            this.signup_password = new System.Windows.Forms.TextBox();
            this.signup_username = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.signin_button = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // signup_showpassword
            // 
            this.signup_showpassword.AutoSize = true;
            this.signup_showpassword.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.signup_showpassword.Location = new System.Drawing.Point(674, 400);
            this.signup_showpassword.Name = "signup_showpassword";
            this.signup_showpassword.Size = new System.Drawing.Size(146, 23);
            this.signup_showpassword.TabIndex = 20;
            this.signup_showpassword.Text = "Show Password";
            this.signup_showpassword.UseVisualStyleBackColor = true;
            this.signup_showpassword.CheckedChanged += new System.EventHandler(this.signup_showpassword_CheckedChanged);
            // 
            // singup_login_button
            // 
            this.singup_login_button.FlatAppearance.BorderSize = 0;
            this.singup_login_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(112)))));
            this.singup_login_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.singup_login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.singup_login_button.Location = new System.Drawing.Point(529, 468);
            this.singup_login_button.Name = "singup_login_button";
            this.singup_login_button.Size = new System.Drawing.Size(176, 57);
            this.singup_login_button.TabIndex = 19;
            this.singup_login_button.Text = "SIGNUP";
            this.singup_login_button.UseVisualStyleBackColor = true;
            this.singup_login_button.Click += new System.EventHandler(this.singup_login_button_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.password.Location = new System.Drawing.Point(422, 335);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(98, 19);
            this.password.TabIndex = 18;
            this.password.Text = "Password :";
            // 
            // signup_password
            // 
            this.signup_password.Location = new System.Drawing.Point(426, 368);
            this.signup_password.Name = "signup_password";
            this.signup_password.PasswordChar = '*';
            this.signup_password.Size = new System.Drawing.Size(392, 26);
            this.signup_password.TabIndex = 17;
            this.signup_password.TextChanged += new System.EventHandler(this.signup_password_TextChanged);
            // 
            // signup_username
            // 
            this.signup_username.Location = new System.Drawing.Point(426, 256);
            this.signup_username.Name = "signup_username";
            this.signup_username.Size = new System.Drawing.Size(392, 26);
            this.signup_username.TabIndex = 16;
            this.signup_username.TextChanged += new System.EventHandler(this.signup_username_TextChanged);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.username.Location = new System.Drawing.Point(422, 224);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(102, 19);
            this.username.TabIndex = 15;
            this.username.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(420, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 32);
            this.label2.TabIndex = 14;
            this.label2.Text = "REGISTER ACCOUNT";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(147)))), ((int)(((byte)(175)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.signin_button);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 608);
            this.panel1.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(108, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "PERSONEL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(106, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 39);
            this.label8.TabIndex = 12;
            this.label8.Text = "SYSTEM";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(53, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(253, 39);
            this.label9.TabIndex = 11;
            this.label9.Text = "MANAGEMENT";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(137, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 39);
            this.label10.TabIndex = 10;
            this.label10.Text = "GYM";
            // 
            // signin_button
            // 
            this.signin_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(147)))), ((int)(((byte)(175)))));
            this.signin_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.signin_button.Location = new System.Drawing.Point(24, 532);
            this.signin_button.Name = "signin_button";
            this.signin_button.Size = new System.Drawing.Size(323, 44);
            this.signin_button.TabIndex = 10;
            this.signin_button.Text = "SIGN IN";
            this.signin_button.UseVisualStyleBackColor = true;
            this.signin_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(76, 497);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(199, 19);
            this.label11.TabIndex = 10;
            this.label11.Text = "LOGIN YOUR ACCOUNT";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exit.Location = new System.Drawing.Point(824, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(27, 27);
            this.exit.TabIndex = 28;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(895, 608);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.signup_showpassword);
            this.Controls.Add(this.singup_login_button);
            this.Controls.Add(this.password);
            this.Controls.Add(this.signup_password);
            this.Controls.Add(this.signup_username);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox signup_showpassword;
        private System.Windows.Forms.Button singup_login_button;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox signup_password;
        private System.Windows.Forms.TextBox signup_username;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button signin_button;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label exit;
    }
}