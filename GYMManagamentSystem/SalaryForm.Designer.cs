namespace GYMManagamentSystem
{
    partial class SalaryForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customer_id_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fullname_textBox = new System.Windows.Forms.TextBox();
            this.fullname_label = new System.Windows.Forms.Label();
            this.salary_textBox = new System.Windows.Forms.TextBox();
            this.Salary_label = new System.Windows.Forms.Label();
            this.update_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(318, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(498, 469);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // customer_id_textBox
            // 
            this.customer_id_textBox.Location = new System.Drawing.Point(50, 127);
            this.customer_id_textBox.Name = "customer_id_textBox";
            this.customer_id_textBox.Size = new System.Drawing.Size(216, 26);
            this.customer_id_textBox.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(46, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Customer ID :";
            // 
            // fullname_textBox
            // 
            this.fullname_textBox.Location = new System.Drawing.Point(50, 208);
            this.fullname_textBox.Name = "fullname_textBox";
            this.fullname_textBox.Size = new System.Drawing.Size(216, 26);
            this.fullname_textBox.TabIndex = 30;
            // 
            // fullname_label
            // 
            this.fullname_label.AutoSize = true;
            this.fullname_label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fullname_label.Location = new System.Drawing.Point(46, 175);
            this.fullname_label.Name = "fullname_label";
            this.fullname_label.Size = new System.Drawing.Size(88, 20);
            this.fullname_label.TabIndex = 29;
            this.fullname_label.Text = "Full Name :";
            // 
            // salary_textBox
            // 
            this.salary_textBox.Location = new System.Drawing.Point(50, 291);
            this.salary_textBox.Name = "salary_textBox";
            this.salary_textBox.Size = new System.Drawing.Size(216, 26);
            this.salary_textBox.TabIndex = 32;
            this.salary_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salary_textBox_KeyPress);
            // 
            // Salary_label
            // 
            this.Salary_label.AutoSize = true;
            this.Salary_label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Salary_label.Location = new System.Drawing.Point(46, 258);
            this.Salary_label.Name = "Salary_label";
            this.Salary_label.Size = new System.Drawing.Size(61, 20);
            this.Salary_label.TabIndex = 31;
            this.Salary_label.Text = "Salary :";
            // 
            // update_button
            // 
            this.update_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(87)))), ((int)(((byte)(70)))));
            this.update_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(87)))), ((int)(((byte)(70)))));
            this.update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_button.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button.ForeColor = System.Drawing.Color.White;
            this.update_button.Location = new System.Drawing.Point(62, 358);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(170, 55);
            this.update_button.TabIndex = 33;
            this.update_button.Text = "UPDATE";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // back_button
            // 
            this.back_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(87)))), ((int)(((byte)(70)))));
            this.back_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(87)))), ((int)(((byte)(70)))));
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.back_button.ForeColor = System.Drawing.Color.White;
            this.back_button.Location = new System.Drawing.Point(9, 12);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(170, 55);
            this.back_button.TabIndex = 35;
            this.back_button.Text = "BACK";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click_1);
            // 
            // clear_button
            // 
            this.clear_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(87)))), ((int)(((byte)(70)))));
            this.clear_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(87)))), ((int)(((byte)(70)))));
            this.clear_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_button.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_button.ForeColor = System.Drawing.Color.White;
            this.clear_button.Location = new System.Drawing.Point(62, 437);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(170, 55);
            this.clear_button.TabIndex = 36;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // SalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(869, 563);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.salary_textBox);
            this.Controls.Add(this.Salary_label);
            this.Controls.Add(this.fullname_textBox);
            this.Controls.Add(this.fullname_label);
            this.Controls.Add(this.customer_id_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalaryForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox customer_id_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fullname_textBox;
        private System.Windows.Forms.Label fullname_label;
        private System.Windows.Forms.TextBox salary_textBox;
        private System.Windows.Forms.Label Salary_label;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button clear_button;
    }
}