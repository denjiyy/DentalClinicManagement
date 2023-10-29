namespace DentalClinicManagement
{
    partial class AddTeethWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTeethWindow));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            teethCombobox = new ComboBox();
            addTooth = new Button();
            statusCombobox = new ComboBox();
            notesTextbox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            comboBox1 = new ComboBox();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 115);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(122, 71);
            label1.Name = "label1";
            label1.Size = new Size(185, 40);
            label1.TabIndex = 1;
            label1.Text = "Add Teeth";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // teethCombobox
            // 
            teethCombobox.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            teethCombobox.FormattingEnabled = true;
            teethCombobox.Location = new Point(12, 177);
            teethCombobox.Name = "teethCombobox";
            teethCombobox.Size = new Size(576, 41);
            teethCombobox.TabIndex = 2;
            teethCombobox.SelectedIndexChanged += teethCombobox_SelectedIndexChanged;
            // 
            // addTooth
            // 
            addTooth.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            addTooth.Location = new Point(201, 628);
            addTooth.Name = "addTooth";
            addTooth.Size = new Size(196, 59);
            addTooth.TabIndex = 3;
            addTooth.Text = "Add Tooth";
            addTooth.UseVisualStyleBackColor = true;
            addTooth.Click += addTooth_Click;
            // 
            // statusCombobox
            // 
            statusCombobox.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            statusCombobox.FormattingEnabled = true;
            statusCombobox.Location = new Point(12, 277);
            statusCombobox.Name = "statusCombobox";
            statusCombobox.Size = new Size(576, 41);
            statusCombobox.TabIndex = 4;
            statusCombobox.SelectedIndexChanged += statusCombobox_SelectedIndexChanged;
            // 
            // notesTextbox
            // 
            notesTextbox.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            notesTextbox.Location = new Point(12, 506);
            notesTextbox.Multiline = true;
            notesTextbox.Name = "notesTextbox";
            notesTextbox.Size = new Size(576, 116);
            notesTextbox.TabIndex = 5;
            notesTextbox.TextChanged += notesTextbox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(12, 234);
            label2.Name = "label2";
            label2.Size = new Size(319, 40);
            label2.TabIndex = 6;
            label2.Text = "Select tooth status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(12, 134);
            label3.Name = "label3";
            label3.Size = new Size(216, 40);
            label3.TabIndex = 7;
            label3.Text = "Select tooth";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DodgerBlue;
            label4.Location = new Point(12, 463);
            label4.Name = "label4";
            label4.Size = new Size(111, 40);
            label4.TabIndex = 8;
            label4.Text = "Notes";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Black;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.ForeColor = Color.Black;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(237, 690);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(116, 34);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Cancel";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 382);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(576, 41);
            comboBox1.TabIndex = 10;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.DodgerBlue;
            label5.Location = new Point(12, 339);
            label5.Name = "label5";
            label5.Size = new Size(229, 40);
            label5.TabIndex = 11;
            label5.Text = "Crown status";
            // 
            // AddTeethWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(600, 733);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(notesTextbox);
            Controls.Add(statusCombobox);
            Controls.Add(addTooth);
            Controls.Add(teethCombobox);
            Controls.Add(panel1);
            Name = "AddTeethWindow";
            Text = "Add Teeth";
            Load += AddTeethWindow_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private ComboBox teethCombobox;
        private Button addTooth;
        private ComboBox statusCombobox;
        private TextBox notesTextbox;
        private Label label2;
        private Label label3;
        private Label label4;
        private LinkLabel linkLabel1;
        private ComboBox comboBox1;
        private Label label5;
    }
}