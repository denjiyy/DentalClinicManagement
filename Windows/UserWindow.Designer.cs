namespace DentalClinicManagement
{
    partial class UserWindow
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserWindow));
            panel1 = new Panel();
            label4 = new Label();
            label9 = new Label();
            pictureBox7 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            UserPanel = new Panel();
            UserPassword = new TextBox();
            UserPhone = new TextBox();
            UserName = new TextBox();
            DeleteUser = new Button();
            EditUser = new Button();
            SaveButtonUser = new Button();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            UserDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            label15 = new Label();
            FilterByPatientTextBox = new TextBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            UserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(341, 771);
            panel1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(80, 658);
            label4.Name = "label4";
            label4.Size = new Size(124, 34);
            label4.TabIndex = 17;
            label4.Text = "Patients";
            label4.Click += label4_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(80, 725);
            label9.Name = "label9";
            label9.Size = new Size(110, 34);
            label9.TabIndex = 16;
            label9.Text = "Logout";
            label9.Click += label9_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(12, 703);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(61, 56);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 15;
            pictureBox7.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(137, 89);
            label3.Name = "label3";
            label3.Size = new Size(80, 34);
            label3.TabIndex = 4;
            label3.Text = "Users";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(137, 49);
            label2.Name = "label2";
            label2.Size = new Size(108, 40);
            label2.TabIndex = 3;
            label2.Text = "Clinic";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(137, 9);
            label1.Name = "label1";
            label1.Size = new Size(126, 40);
            label1.TabIndex = 2;
            label1.Text = "Dental";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.DodgerBlue;
            label10.Location = new Point(347, 9);
            label10.Name = "label10";
            label10.Size = new Size(83, 40);
            label10.TabIndex = 5;
            label10.Text = "User";
            // 
            // UserPanel
            // 
            UserPanel.Controls.Add(UserPassword);
            UserPanel.Controls.Add(UserPhone);
            UserPanel.Controls.Add(UserName);
            UserPanel.Controls.Add(DeleteUser);
            UserPanel.Controls.Add(EditUser);
            UserPanel.Controls.Add(SaveButtonUser);
            UserPanel.Controls.Add(label13);
            UserPanel.Controls.Add(label12);
            UserPanel.Controls.Add(label11);
            UserPanel.Location = new Point(347, 52);
            UserPanel.Name = "UserPanel";
            UserPanel.Size = new Size(1146, 322);
            UserPanel.TabIndex = 4;
            // 
            // UserPassword
            // 
            UserPassword.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            UserPassword.Location = new Point(619, 61);
            UserPassword.Name = "UserPassword";
            UserPassword.Size = new Size(360, 41);
            UserPassword.TabIndex = 16;
            // 
            // UserPhone
            // 
            UserPhone.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            UserPhone.Location = new Point(12, 175);
            UserPhone.Name = "UserPhone";
            UserPhone.Size = new Size(360, 41);
            UserPhone.TabIndex = 15;
            UserPhone.TextChanged += UserPhone_TextChanged;
            // 
            // UserName
            // 
            UserName.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            UserName.Location = new Point(12, 61);
            UserName.Name = "UserName";
            UserName.Size = new Size(360, 41);
            UserName.TabIndex = 14;
            // 
            // DeleteUser
            // 
            DeleteUser.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteUser.Location = new Point(738, 247);
            DeleteUser.Name = "DeleteUser";
            DeleteUser.Size = new Size(296, 66);
            DeleteUser.TabIndex = 13;
            DeleteUser.Text = "Delete";
            DeleteUser.UseVisualStyleBackColor = true;
            DeleteUser.Click += DeleteUser_Click;
            // 
            // EditUser
            // 
            EditUser.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            EditUser.Location = new Point(134, 247);
            EditUser.Name = "EditUser";
            EditUser.Size = new Size(296, 66);
            EditUser.TabIndex = 12;
            EditUser.Text = "Edit";
            EditUser.UseVisualStyleBackColor = true;
            EditUser.Click += EditUser_Click;
            // 
            // SaveButtonUser
            // 
            SaveButtonUser.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            SaveButtonUser.Location = new Point(436, 247);
            SaveButtonUser.Name = "SaveButtonUser";
            SaveButtonUser.Size = new Size(296, 66);
            SaveButtonUser.TabIndex = 11;
            SaveButtonUser.Text = "Save";
            SaveButtonUser.UseVisualStyleBackColor = true;
            SaveButtonUser.Click += SaveButtonUser_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.DodgerBlue;
            label13.Location = new Point(12, 132);
            label13.Name = "label13";
            label13.Size = new Size(123, 40);
            label13.TabIndex = 7;
            label13.Text = "Phone";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.DodgerBlue;
            label12.Location = new Point(619, 18);
            label12.Name = "label12";
            label12.Size = new Size(169, 40);
            label12.TabIndex = 6;
            label12.Text = "Password";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.DodgerBlue;
            label11.Location = new Point(12, 18);
            label11.Name = "label11";
            label11.Size = new Size(117, 40);
            label11.TabIndex = 4;
            label11.Text = "Name";
            // 
            // UserDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            UserDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            UserDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            UserDGV.ColumnHeadersHeight = 4;
            UserDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            UserDGV.DefaultCellStyle = dataGridViewCellStyle3;
            UserDGV.GridColor = Color.FromArgb(231, 229, 255);
            UserDGV.Location = new Point(347, 447);
            UserDGV.Name = "UserDGV";
            UserDGV.RowHeadersVisible = false;
            UserDGV.RowHeadersWidth = 51;
            UserDGV.RowTemplate.Height = 29;
            UserDGV.Size = new Size(1146, 312);
            UserDGV.TabIndex = 10;
            UserDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            UserDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            UserDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            UserDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            UserDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            UserDGV.ThemeStyle.BackColor = Color.White;
            UserDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            UserDGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            UserDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            UserDGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UserDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            UserDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            UserDGV.ThemeStyle.HeaderStyle.Height = 4;
            UserDGV.ThemeStyle.ReadOnly = false;
            UserDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            UserDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            UserDGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UserDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            UserDGV.ThemeStyle.RowsStyle.Height = 29;
            UserDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            UserDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            UserDGV.CellContentClick += UserDGV_CellContentClick;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.DodgerBlue;
            label15.Location = new Point(815, 377);
            label15.Name = "label15";
            label15.Size = new Size(226, 34);
            label15.TabIndex = 9;
            label15.Text = "Filter by Patient";
            // 
            // FilterByPatientTextBox
            // 
            FilterByPatientTextBox.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FilterByPatientTextBox.Location = new Point(747, 415);
            FilterByPatientTextBox.Name = "FilterByPatientTextBox";
            FilterByPatientTextBox.Size = new Size(360, 26);
            FilterByPatientTextBox.TabIndex = 8;
            FilterByPatientTextBox.TextChanged += FilterByPatientTextBox_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 636);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(61, 56);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // UserWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1505, 771);
            Controls.Add(UserDGV);
            Controls.Add(label15);
            Controls.Add(FilterByPatientTextBox);
            Controls.Add(label10);
            Controls.Add(UserPanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "UserWindow";
            Text = "Users";
            Load += UserWindow_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            UserPanel.ResumeLayout(false);
            UserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label9;
        private PictureBox pictureBox7;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label10;
        private Panel UserPanel;
        private Button DeleteUser;
        private Button EditUser;
        private Button SaveButtonUser;
        private Label label13;
        private Label label12;
        private Label label11;
        private Guna.UI2.WinForms.Guna2DataGridView UserDGV;
        private Label label15;
        private TextBox FilterByPatientTextBox;
        private TextBox UserPassword;
        private TextBox UserPhone;
        private TextBox UserName;
        private Label label4;
        private PictureBox pictureBox2;
    }
}