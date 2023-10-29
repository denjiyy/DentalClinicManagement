namespace DentalClinicManagement
{
    partial class AdminLoginWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLoginWindow));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            LoginButton = new Button();
            CancelLabel = new LinkLabel();
            AdminPassword = new TextBox();
            label3 = new Label();
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
            panel1.Size = new Size(385, 115);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(122, 71);
            label1.Name = "label1";
            label1.Size = new Size(219, 40);
            label1.TabIndex = 1;
            label1.Text = "Admin Login";
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
            // LoginButton
            // 
            LoginButton.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            LoginButton.Location = new Point(12, 246);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(360, 66);
            LoginButton.TabIndex = 13;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // CancelLabel
            // 
            CancelLabel.ActiveLinkColor = Color.Black;
            CancelLabel.AutoSize = true;
            CancelLabel.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            CancelLabel.LinkColor = Color.Black;
            CancelLabel.Location = new Point(137, 354);
            CancelLabel.Name = "CancelLabel";
            CancelLabel.Size = new Size(116, 34);
            CancelLabel.TabIndex = 12;
            CancelLabel.TabStop = true;
            CancelLabel.Text = "Cancel";
            CancelLabel.LinkClicked += CancelLabel_LinkClicked;
            // 
            // AdminPassword
            // 
            AdminPassword.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            AdminPassword.Location = new Point(12, 155);
            AdminPassword.Name = "AdminPassword";
            AdminPassword.PasswordChar = '*';
            AdminPassword.Size = new Size(360, 41);
            AdminPassword.TabIndex = 11;
            AdminPassword.TextChanged += AdminPassword_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 118);
            label3.Name = "label3";
            label3.Size = new Size(142, 34);
            label3.TabIndex = 10;
            label3.Text = "Password";
            // 
            // AdminLoginWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(384, 394);
            Controls.Add(LoginButton);
            Controls.Add(CancelLabel);
            Controls.Add(AdminPassword);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AdminLoginWindow";
            Text = "Administrator Login";
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
        private Button LoginButton;
        private LinkLabel CancelLabel;
        private TextBox AdminPassword;
        private Label label3;
    }
}