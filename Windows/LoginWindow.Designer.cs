namespace DentalClinicManagement
{
    partial class LoginWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginWindow));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            UserName = new TextBox();
            label3 = new Label();
            UserPassword = new TextBox();
            AdminLabel = new LinkLabel();
            LoginButton = new Button();
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
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(122, 71);
            label1.Name = "label1";
            label1.Size = new Size(106, 40);
            label1.TabIndex = 1;
            label1.Text = "Login";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 145);
            label2.Name = "label2";
            label2.Size = new Size(149, 34);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // UserName
            // 
            UserName.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            UserName.Location = new Point(12, 182);
            UserName.Name = "UserName";
            UserName.Size = new Size(360, 41);
            UserName.TabIndex = 3;
            UserName.TextChanged += UserName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 262);
            label3.Name = "label3";
            label3.Size = new Size(142, 34);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // UserPassword
            // 
            UserPassword.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            UserPassword.Location = new Point(12, 299);
            UserPassword.Name = "UserPassword";
            UserPassword.PasswordChar = '*';
            UserPassword.Size = new Size(360, 41);
            UserPassword.TabIndex = 5;
            UserPassword.TextChanged += UserPassword_TextChanged;
            // 
            // AdminLabel
            // 
            AdminLabel.ActiveLinkColor = Color.Black;
            AdminLabel.AutoSize = true;
            AdminLabel.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            AdminLabel.LinkColor = Color.Black;
            AdminLabel.Location = new Point(137, 498);
            AdminLabel.Name = "AdminLabel";
            AdminLabel.Size = new Size(105, 34);
            AdminLabel.TabIndex = 6;
            AdminLabel.TabStop = true;
            AdminLabel.Text = "Admin";
            AdminLabel.LinkClicked += AdminLabel_LinkClicked;
            // 
            // LoginButton
            // 
            LoginButton.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            LoginButton.Location = new Point(12, 390);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(360, 66);
            LoginButton.TabIndex = 7;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // LoginWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(384, 541);
            Controls.Add(LoginButton);
            Controls.Add(AdminLabel);
            Controls.Add(UserPassword);
            Controls.Add(label3);
            Controls.Add(UserName);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "LoginWindow";
            Text = "Login";
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
        private Label label2;
        private TextBox UserName;
        private Label label3;
        private TextBox UserPassword;
        private LinkLabel AdminLabel;
        private Button LoginButton;
    }
}