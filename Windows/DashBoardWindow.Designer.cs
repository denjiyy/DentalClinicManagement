namespace DentalClinicManagement
{
    partial class DashBoardWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoardWindow));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            Pending = new Label();
            User = new Label();
            Patient = new Label();
            AppointmentCircle = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            label2 = new Label();
            UserCircle = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            label5 = new Label();
            label4 = new Label();
            PatientCircle = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            label3 = new Label();
            BackLabelDashBoard = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            AppointmentCircle.SuspendLayout();
            UserCircle.SuspendLayout();
            PatientCircle.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1087, 115);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 75);
            label1.Name = "label1";
            label1.Size = new Size(200, 40);
            label1.TabIndex = 1;
            label1.Text = "Dashboard";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(288, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Pending
            // 
            Pending.AutoSize = true;
            Pending.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Pending.ForeColor = Color.DodgerBlue;
            Pending.Location = new Point(107, 94);
            Pending.Name = "Pending";
            Pending.Size = new Size(93, 40);
            Pending.TabIndex = 6;
            Pending.Text = "Num";
            // 
            // User
            // 
            User.AutoSize = true;
            User.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            User.ForeColor = Color.Crimson;
            User.Location = new Point(107, 92);
            User.Name = "User";
            User.Size = new Size(93, 40);
            User.TabIndex = 7;
            User.Text = "Num";
            // 
            // Patient
            // 
            Patient.AutoSize = true;
            Patient.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Patient.ForeColor = Color.Navy;
            Patient.Location = new Point(107, 94);
            Patient.Name = "Patient";
            Patient.Size = new Size(93, 40);
            Patient.TabIndex = 7;
            Patient.Text = "Num";
            // 
            // AppointmentCircle
            // 
            AppointmentCircle.Controls.Add(label2);
            AppointmentCircle.Controls.Add(Pending);
            AppointmentCircle.FillColor = Color.FromArgb(200, 213, 218, 223);
            AppointmentCircle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AppointmentCircle.ForeColor = Color.White;
            AppointmentCircle.Location = new Point(12, 121);
            AppointmentCircle.Minimum = 0;
            AppointmentCircle.Name = "AppointmentCircle";
            AppointmentCircle.ProgressColor = Color.DodgerBlue;
            AppointmentCircle.ProgressColor2 = Color.DodgerBlue;
            AppointmentCircle.ShadowDecoration.CustomizableEdges = customizableEdges1;
            AppointmentCircle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            AppointmentCircle.Size = new Size(234, 234);
            AppointmentCircle.TabIndex = 8;
            AppointmentCircle.Text = "guna2CircleProgressBar4";
            AppointmentCircle.ValueChanged += AppointmentCircle_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(44, 71);
            label2.Name = "label2";
            label2.Size = new Size(147, 23);
            label2.TabIndex = 11;
            label2.Text = "Appointments";
            // 
            // UserCircle
            // 
            UserCircle.Controls.Add(label5);
            UserCircle.Controls.Add(label4);
            UserCircle.Controls.Add(User);
            UserCircle.FillColor = Color.FromArgb(200, 213, 218, 223);
            UserCircle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UserCircle.ForeColor = Color.White;
            UserCircle.Location = new Point(216, 361);
            UserCircle.Minimum = 0;
            UserCircle.Name = "UserCircle";
            UserCircle.ProgressColor = Color.Crimson;
            UserCircle.ProgressColor2 = Color.Crimson;
            UserCircle.ShadowDecoration.CustomizableEdges = customizableEdges2;
            UserCircle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            UserCircle.Size = new Size(234, 234);
            UserCircle.TabIndex = 9;
            UserCircle.Text = "guna2CircleProgressBar4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Crimson;
            label5.Location = new Point(93, 69);
            label5.Name = "label5";
            label5.Size = new Size(58, 23);
            label5.TabIndex = 12;
            label5.Text = "Users";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DodgerBlue;
            label4.Location = new Point(44, 69);
            label4.Name = "label4";
            label4.Size = new Size(0, 23);
            label4.TabIndex = 12;
            // 
            // PatientCircle
            // 
            PatientCircle.Controls.Add(label3);
            PatientCircle.Controls.Add(Patient);
            PatientCircle.FillColor = Color.FromArgb(200, 213, 218, 223);
            PatientCircle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PatientCircle.ForeColor = Color.White;
            PatientCircle.Location = new Point(436, 121);
            PatientCircle.Minimum = 0;
            PatientCircle.Name = "PatientCircle";
            PatientCircle.ProgressColor = Color.Navy;
            PatientCircle.ProgressColor2 = Color.Navy;
            PatientCircle.ShadowDecoration.CustomizableEdges = customizableEdges3;
            PatientCircle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            PatientCircle.Size = new Size(234, 234);
            PatientCircle.TabIndex = 10;
            PatientCircle.Text = "guna2CircleProgressBar4";
            PatientCircle.ValueChanged += PatientCircle_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(78, 71);
            label3.Name = "label3";
            label3.Size = new Size(86, 23);
            label3.TabIndex = 12;
            label3.Text = "Patients";
            // 
            // BackLabelDashBoard
            // 
            BackLabelDashBoard.ActiveLinkColor = Color.Black;
            BackLabelDashBoard.AutoSize = true;
            BackLabelDashBoard.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            BackLabelDashBoard.LinkColor = Color.Black;
            BackLabelDashBoard.Location = new Point(288, 607);
            BackLabelDashBoard.Name = "BackLabelDashBoard";
            BackLabelDashBoard.Size = new Size(82, 34);
            BackLabelDashBoard.TabIndex = 11;
            BackLabelDashBoard.TabStop = true;
            BackLabelDashBoard.Text = "Back";
            BackLabelDashBoard.LinkClicked += AdminLabelDashBoard_LinkClicked;
            // 
            // DashBoardWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(687, 650);
            Controls.Add(BackLabelDashBoard);
            Controls.Add(PatientCircle);
            Controls.Add(UserCircle);
            Controls.Add(AppointmentCircle);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "DashBoardWindow";
            Text = "Dashboard";
            Load += DashBoardWindow_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            AppointmentCircle.ResumeLayout(false);
            AppointmentCircle.PerformLayout();
            UserCircle.ResumeLayout(false);
            UserCircle.PerformLayout();
            PatientCircle.ResumeLayout(false);
            PatientCircle.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label Pending;
        private Label User;
        private Label Patient;
        private Guna.UI2.WinForms.Guna2CircleProgressBar AppointmentCircle;
        private Guna.UI2.WinForms.Guna2CircleProgressBar UserCircle;
        private Guna.UI2.WinForms.Guna2CircleProgressBar PatientCircle;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private LinkLabel BackLabelDashBoard;
    }
}