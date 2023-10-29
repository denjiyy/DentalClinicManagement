namespace DentalClinicManagement
{
    partial class PatientWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientWindow));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            panel2 = new Panel();
            BirthdateText = new DateTimePicker();
            EditButton = new Button();
            DeleteButton = new Button();
            GenderBox = new ComboBox();
            AllergiesText = new TextBox();
            label17 = new Label();
            label16 = new Label();
            label13 = new Label();
            label14 = new Label();
            PhoneText = new TextBox();
            AddressText = new TextBox();
            label12 = new Label();
            NameText = new TextBox();
            SaveButtonTreatment = new Button();
            label11 = new Label();
            PatientDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            label15 = new Label();
            FilterByPatientTextBox = new TextBox();
            BackLabel = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PatientDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(BackLabel);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(341, 771);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(137, 89);
            label3.Name = "label3";
            label3.Size = new Size(113, 34);
            label3.TabIndex = 4;
            label3.Text = "Patient";
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
            label10.BackColor = Color.White;
            label10.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.DodgerBlue;
            label10.Location = new Point(347, 9);
            label10.Name = "label10";
            label10.Size = new Size(134, 40);
            label10.TabIndex = 7;
            label10.Text = "Patient";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(BirthdateText);
            panel2.Controls.Add(EditButton);
            panel2.Controls.Add(DeleteButton);
            panel2.Controls.Add(GenderBox);
            panel2.Controls.Add(AllergiesText);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(PhoneText);
            panel2.Controls.Add(AddressText);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(NameText);
            panel2.Controls.Add(SaveButtonTreatment);
            panel2.Controls.Add(label11);
            panel2.Location = new Point(347, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(1146, 322);
            panel2.TabIndex = 6;
            // 
            // BirthdateText
            // 
            BirthdateText.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            BirthdateText.Format = DateTimePickerFormat.Short;
            BirthdateText.Location = new Point(836, 18);
            BirthdateText.Name = "BirthdateText";
            BirthdateText.Size = new Size(295, 41);
            BirthdateText.TabIndex = 26;
            // 
            // EditButton
            // 
            EditButton.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            EditButton.Location = new Point(187, 244);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(243, 66);
            EditButton.TabIndex = 25;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteButton.Location = new Point(685, 244);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(243, 66);
            DeleteButton.TabIndex = 24;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // GenderBox
            // 
            GenderBox.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            GenderBox.FormattingEnabled = true;
            GenderBox.Items.AddRange(new object[] { "Male", "Female" });
            GenderBox.Location = new Point(837, 77);
            GenderBox.Name = "GenderBox";
            GenderBox.Size = new Size(295, 41);
            GenderBox.TabIndex = 23;
            // 
            // AllergiesText
            // 
            AllergiesText.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            AllergiesText.Location = new Point(837, 128);
            AllergiesText.Multiline = true;
            AllergiesText.Name = "AllergiesText";
            AllergiesText.Size = new Size(295, 107);
            AllergiesText.TabIndex = 22;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.DodgerBlue;
            label17.Location = new Point(682, 131);
            label17.Name = "label17";
            label17.Size = new Size(149, 40);
            label17.TabIndex = 21;
            label17.Text = "Allergies";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.DodgerBlue;
            label16.Location = new Point(685, 77);
            label16.Name = "label16";
            label16.Size = new Size(145, 40);
            label16.TabIndex = 20;
            label16.Text = "Gender";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.DodgerBlue;
            label13.Location = new Point(610, 18);
            label13.Name = "label13";
            label13.Size = new Size(220, 40);
            label13.TabIndex = 19;
            label13.Text = "Date of Birth";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.DodgerBlue;
            label14.Location = new Point(12, 75);
            label14.Name = "label14";
            label14.Size = new Size(123, 40);
            label14.TabIndex = 18;
            label14.Text = "Phone";
            // 
            // PhoneText
            // 
            PhoneText.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneText.Location = new Point(135, 78);
            PhoneText.Name = "PhoneText";
            PhoneText.Size = new Size(295, 41);
            PhoneText.TabIndex = 17;
            PhoneText.TextChanged += textBox1_TextChanged;
            // 
            // AddressText
            // 
            AddressText.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            AddressText.Location = new Point(162, 125);
            AddressText.Multiline = true;
            AddressText.Name = "AddressText";
            AddressText.Size = new Size(268, 110);
            AddressText.TabIndex = 16;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.DodgerBlue;
            label12.Location = new Point(12, 131);
            label12.Name = "label12";
            label12.Size = new Size(144, 40);
            label12.TabIndex = 15;
            label12.Text = "Address";
            // 
            // NameText
            // 
            NameText.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            NameText.Location = new Point(135, 17);
            NameText.Name = "NameText";
            NameText.Size = new Size(295, 41);
            NameText.TabIndex = 13;
            NameText.TextChanged += NameText_TextChanged;
            // 
            // SaveButtonTreatment
            // 
            SaveButtonTreatment.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            SaveButtonTreatment.Location = new Point(436, 244);
            SaveButtonTreatment.Name = "SaveButtonTreatment";
            SaveButtonTreatment.Size = new Size(243, 66);
            SaveButtonTreatment.TabIndex = 11;
            SaveButtonTreatment.Text = "Save";
            SaveButtonTreatment.UseVisualStyleBackColor = true;
            SaveButtonTreatment.Click += SaveButtonTreatment_Click;
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
            // PatientDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            PatientDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            PatientDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            PatientDGV.ColumnHeadersHeight = 4;
            PatientDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            PatientDGV.DefaultCellStyle = dataGridViewCellStyle3;
            PatientDGV.GridColor = Color.FromArgb(231, 229, 255);
            PatientDGV.Location = new Point(347, 446);
            PatientDGV.Name = "PatientDGV";
            PatientDGV.RowHeadersVisible = false;
            PatientDGV.RowHeadersWidth = 51;
            PatientDGV.RowTemplate.Height = 29;
            PatientDGV.Size = new Size(1146, 313);
            PatientDGV.TabIndex = 14;
            PatientDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            PatientDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            PatientDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            PatientDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            PatientDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            PatientDGV.ThemeStyle.BackColor = Color.White;
            PatientDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            PatientDGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            PatientDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            PatientDGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PatientDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            PatientDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            PatientDGV.ThemeStyle.HeaderStyle.Height = 4;
            PatientDGV.ThemeStyle.ReadOnly = false;
            PatientDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            PatientDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            PatientDGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PatientDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            PatientDGV.ThemeStyle.RowsStyle.Height = 29;
            PatientDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            PatientDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            PatientDGV.CellContentClick += PatientDGV_CellContentClick;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.DodgerBlue;
            label15.Location = new Point(783, 377);
            label15.Name = "label15";
            label15.Size = new Size(226, 34);
            label15.TabIndex = 13;
            label15.Text = "Filter by Patient";
            // 
            // FilterByPatientTextBox
            // 
            FilterByPatientTextBox.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FilterByPatientTextBox.Location = new Point(742, 414);
            FilterByPatientTextBox.Name = "FilterByPatientTextBox";
            FilterByPatientTextBox.Size = new Size(310, 26);
            FilterByPatientTextBox.TabIndex = 12;
            FilterByPatientTextBox.TextChanged += FilterByPatientTextBox_TextChanged;
            // 
            // BackLabel
            // 
            BackLabel.ActiveLinkColor = Color.White;
            BackLabel.AutoSize = true;
            BackLabel.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            BackLabel.LinkColor = Color.White;
            BackLabel.Location = new Point(12, 725);
            BackLabel.Name = "BackLabel";
            BackLabel.Size = new Size(82, 34);
            BackLabel.TabIndex = 7;
            BackLabel.TabStop = true;
            BackLabel.Text = "Back";
            BackLabel.LinkClicked += BackLabel_LinkClicked;
            // 
            // PatientWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1505, 771);
            Controls.Add(PatientDGV);
            Controls.Add(label15);
            Controls.Add(FilterByPatientTextBox);
            Controls.Add(label10);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "PatientWindow";
            Text = "Patient";
            Load += PatientWindow_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PatientDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label10;
        private Panel panel2;
        private TextBox AddressText;
        private Label label12;
        private TextBox NameText;
        private Button SaveButtonTreatment;
        private Label label11;
        private Guna.UI2.WinForms.Guna2DataGridView PatientDGV;
        private Label label15;
        private TextBox FilterByPatientTextBox;
        private Label label14;
        private TextBox PhoneText;
        private TextBox AllergiesText;
        private Label label17;
        private Label label16;
        private Label label13;
        private ComboBox GenderBox;
        private Button EditButton;
        private Button DeleteButton;
        private DateTimePicker BirthdateText;
        private LinkLabel BackLabel;
    }
}