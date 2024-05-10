namespace GYMManagamentSystem
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            this.back_button = new System.Windows.Forms.Button();
            this.gYMDataSet = new GYMManagamentSystem.GYMDataSet();
            this.gYMDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.update_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.full_name_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.phone_number_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.age_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.weight_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.height_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.program_type_comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gender_comboBox = new System.Windows.Forms.ComboBox();
            this.customer_id_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(87)))), ((int)(((byte)(70)))));
            this.back_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(87)))), ((int)(((byte)(70)))));
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.back_button.ForeColor = System.Drawing.Color.White;
            this.back_button.Location = new System.Drawing.Point(49, 12);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(170, 55);
            this.back_button.TabIndex = 23;
            this.back_button.Text = "BACK";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // gYMDataSet
            // 
            this.gYMDataSet.DataSetName = "GYMDataSet";
            this.gYMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gYMDataSetBindingSource
            // 
            this.gYMDataSetBindingSource.DataSource = this.gYMDataSet;
            this.gYMDataSetBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(49, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(919, 425);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // update_button
            // 
            this.update_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(87)))), ((int)(((byte)(70)))));
            this.update_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(87)))), ((int)(((byte)(70)))));
            this.update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_button.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button.ForeColor = System.Drawing.Color.White;
            this.update_button.Location = new System.Drawing.Point(799, 582);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(170, 55);
            this.update_button.TabIndex = 26;
            this.update_button.Text = "UPDATE";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(87)))), ((int)(((byte)(70)))));
            this.delete_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(87)))), ((int)(((byte)(70)))));
            this.delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_button.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button.ForeColor = System.Drawing.Color.White;
            this.delete_button.Location = new System.Drawing.Point(799, 521);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(170, 55);
            this.delete_button.TabIndex = 25;
            this.delete_button.Text = "DELETE";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // full_name_textBox
            // 
            this.full_name_textBox.Location = new System.Drawing.Point(140, 556);
            this.full_name_textBox.Name = "full_name_textBox";
            this.full_name_textBox.Size = new System.Drawing.Size(255, 26);
            this.full_name_textBox.TabIndex = 28;
            this.full_name_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.full_name_textBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(46, 559);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Full Name :";
            // 
            // phone_number_textBox
            // 
            this.phone_number_textBox.Location = new System.Drawing.Point(140, 588);
            this.phone_number_textBox.MaxLength = 10;
            this.phone_number_textBox.Name = "phone_number_textBox";
            this.phone_number_textBox.Size = new System.Drawing.Size(255, 26);
            this.phone_number_textBox.TabIndex = 30;
            this.phone_number_textBox.TextChanged += new System.EventHandler(this.phone_number_textBox_TextChanged);
            this.phone_number_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_number_textBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(11, 588);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Phone Number :";
            // 
            // age_textBox
            // 
            this.age_textBox.Location = new System.Drawing.Point(499, 524);
            this.age_textBox.Name = "age_textBox";
            this.age_textBox.Size = new System.Drawing.Size(255, 26);
            this.age_textBox.TabIndex = 32;
            this.age_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.age_textBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(442, 524);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Age :";
            // 
            // weight_textBox
            // 
            this.weight_textBox.Location = new System.Drawing.Point(499, 556);
            this.weight_textBox.Name = "weight_textBox";
            this.weight_textBox.Size = new System.Drawing.Size(255, 26);
            this.weight_textBox.TabIndex = 34;
            this.weight_textBox.TextChanged += new System.EventHandler(this.weight_textBox_TextChanged);
            this.weight_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.weight_textBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(426, 556);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Weight :";
            // 
            // height_textBox
            // 
            this.height_textBox.Location = new System.Drawing.Point(499, 587);
            this.height_textBox.Name = "height_textBox";
            this.height_textBox.Size = new System.Drawing.Size(255, 26);
            this.height_textBox.TabIndex = 36;
            this.height_textBox.TextChanged += new System.EventHandler(this.height_textBox_TextChanged);
            this.height_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.height_textBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(426, 587);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "Height :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(16, 619);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "Program Type :";
            // 
            // program_type_comboBox
            // 
            this.program_type_comboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.program_type_comboBox.FormattingEnabled = true;
            this.program_type_comboBox.Items.AddRange(new object[] {
            "None"});
            this.program_type_comboBox.Location = new System.Drawing.Point(140, 619);
            this.program_type_comboBox.Name = "program_type_comboBox";
            this.program_type_comboBox.Size = new System.Drawing.Size(255, 28);
            this.program_type_comboBox.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(417, 619);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Gender :";
            // 
            // gender_comboBox
            // 
            this.gender_comboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.gender_comboBox.FormattingEnabled = true;
            this.gender_comboBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.gender_comboBox.Location = new System.Drawing.Point(499, 619);
            this.gender_comboBox.Name = "gender_comboBox";
            this.gender_comboBox.Size = new System.Drawing.Size(255, 28);
            this.gender_comboBox.TabIndex = 39;
            // 
            // customer_id_textBox
            // 
            this.customer_id_textBox.Location = new System.Drawing.Point(140, 524);
            this.customer_id_textBox.Name = "customer_id_textBox";
            this.customer_id_textBox.Size = new System.Drawing.Size(255, 26);
            this.customer_id_textBox.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(28, 527);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Customer ID :";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(87)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1024, 686);
            this.Controls.Add(this.customer_id_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gender_comboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.program_type_comboBox);
            this.Controls.Add(this.height_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.weight_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.age_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.phone_number_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.full_name_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.back_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.BindingSource gYMDataSetBindingSource;
        private GYMDataSet gYMDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.TextBox full_name_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phone_number_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox age_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox weight_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox height_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox program_type_comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox gender_comboBox;
        private System.Windows.Forms.TextBox customer_id_textBox;
        private System.Windows.Forms.Label label1;
    }
}