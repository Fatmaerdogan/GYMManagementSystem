namespace GYMManagamentSystem
{
    partial class AddProgram
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
            this.back_button = new System.Windows.Forms.Button();
            this.add_program_button = new System.Windows.Forms.Button();
            this.add_movement_button = new System.Windows.Forms.Button();
            this.program_textBox = new System.Windows.Forms.TextBox();
            this.movement_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.set_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.repeat_textBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.back_button.Location = new System.Drawing.Point(12, 12);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(101, 40);
            this.back_button.TabIndex = 23;
            this.back_button.Text = "BACK";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // add_program_button
            // 
            this.add_program_button.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.add_program_button.Location = new System.Drawing.Point(83, 379);
            this.add_program_button.Name = "add_program_button";
            this.add_program_button.Size = new System.Drawing.Size(135, 42);
            this.add_program_button.TabIndex = 24;
            this.add_program_button.Text = "Add Program";
            this.add_program_button.UseVisualStyleBackColor = true;
            this.add_program_button.Click += new System.EventHandler(this.add_program_button_Click);
            // 
            // add_movement_button
            // 
            this.add_movement_button.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.add_movement_button.Location = new System.Drawing.Point(244, 379);
            this.add_movement_button.Name = "add_movement_button";
            this.add_movement_button.Size = new System.Drawing.Size(135, 42);
            this.add_movement_button.TabIndex = 25;
            this.add_movement_button.Text = "Add Movement";
            this.add_movement_button.UseVisualStyleBackColor = true;
            this.add_movement_button.Click += new System.EventHandler(this.add_movement_button_Click);
            // 
            // program_textBox
            // 
            this.program_textBox.Location = new System.Drawing.Point(83, 109);
            this.program_textBox.Name = "program_textBox";
            this.program_textBox.Size = new System.Drawing.Size(296, 26);
            this.program_textBox.TabIndex = 26;
            this.program_textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // movement_comboBox
            // 
            this.movement_comboBox.FormattingEnabled = true;
            this.movement_comboBox.Items.AddRange(new object[] {
            "Bench Press (Chest)",
            "Incline Bench Press (Chest)",
            "Chest Flyes (Dumbbell or Cable) (Chest)",
            "Push-Ups (Various Variations) (Chest)",
            "Cable Crossovers (Chest)",
            "Pull-Ups/Chin-Ups (Back)",
            "Bent-Over Rows (Back)",
            "Deadlifts (Back)",
            "Lat Pulldowns (Back)",
            "T-Bar Rows (Back)",
            "Overhead Press (Shoulder)",
            "Lateral Raises (Shoulder)",
            "Front Raises (Shoulder)",
            "Rear Delt Flyes (Shoulder)",
            "Arnold Press (Shoulder)",
            "Squats (Leg)",
            "Deadlifts (Leg)",
            "Lunges (Leg)",
            "Leg Press (Leg)",
            "Leg Curls (Leg)",
            "Barbell Bicep Curl (Forearm)",
            "Dumbbell Bicep Curl (Forearm)",
            "Preacher Curl (Forearm)",
            "Hammer Curl (Forearm)",
            "Cable Bicep Curl (Forearm)",
            "Tricep Dips (Back Arm)",
            "Tricep Pushdown (Back Arm)",
            "Close-Grip Bench Press (Back Arm)",
            "Skull Crushers (Back Arm)",
            "Overhead Tricep Extension (Back Arm)",
            "Treadmill (Cardio)",
            "Elliptical Trainer (Cardio)",
            "Cycling (Cardio)",
            "Stair Training (Cardio)",
            "Rope Work (Cardio)",
            "Rowing Machine (Cardio)"});
            this.movement_comboBox.Location = new System.Drawing.Point(83, 180);
            this.movement_comboBox.Name = "movement_comboBox";
            this.movement_comboBox.Size = new System.Drawing.Size(296, 28);
            this.movement_comboBox.TabIndex = 27;
            this.movement_comboBox.SelectedIndexChanged += new System.EventHandler(this.movement_comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(79, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "Name Of The Program";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(79, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "Type Of Movement";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(79, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "Number Of Sets";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // set_textBox
            // 
            this.set_textBox.Location = new System.Drawing.Point(83, 254);
            this.set_textBox.Name = "set_textBox";
            this.set_textBox.Size = new System.Drawing.Size(296, 26);
            this.set_textBox.TabIndex = 30;
            this.set_textBox.TextChanged += new System.EventHandler(this.set_textBox_TextChanged);
            this.set_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.set_textBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(79, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 19);
            this.label4.TabIndex = 33;
            this.label4.Text = "Number Of Repeats";
            // 
            // repeat_textBox
            // 
            this.repeat_textBox.Location = new System.Drawing.Point(83, 326);
            this.repeat_textBox.Name = "repeat_textBox";
            this.repeat_textBox.Size = new System.Drawing.Size(296, 26);
            this.repeat_textBox.TabIndex = 32;
            this.repeat_textBox.TextChanged += new System.EventHandler(this.repeat_textBox_TextChanged);
            this.repeat_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.repeat_textBox_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(411, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(554, 648);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AddProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(1000, 753);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.repeat_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.set_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.movement_comboBox);
            this.Controls.Add(this.program_textBox);
            this.Controls.Add(this.add_movement_button);
            this.Controls.Add(this.add_program_button);
            this.Controls.Add(this.back_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProgram";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button add_program_button;
        private System.Windows.Forms.Button add_movement_button;
        private System.Windows.Forms.TextBox program_textBox;
        private System.Windows.Forms.ComboBox movement_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox set_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox repeat_textBox;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}