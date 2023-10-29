namespace DentalClinicManagement.Windows
{
    partial class PerformStatusCheckWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerformStatusCheckWindow));
            Cancel = new LinkLabel();
            panel3 = new Panel();
            textBox1 = new TextBox();
            ExtractionButton = new Button();
            FillingButton = new Button();
            label7 = new Label();
            label11 = new Label();
            EnterTeeth = new TextBox();
            label12 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Cancel
            // 
            Cancel.ActiveLinkColor = Color.Black;
            Cancel.AutoSize = true;
            Cancel.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Cancel.LinkColor = Color.Black;
            Cancel.Location = new Point(172, 453);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(116, 34);
            Cancel.TabIndex = 23;
            Cancel.TabStop = true;
            Cancel.Text = "Cancel";
            Cancel.LinkClicked += Cancel_LinkClicked;
            // 
            // panel3
            // 
            panel3.Controls.Add(Cancel);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(ExtractionButton);
            panel3.Controls.Add(FillingButton);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(EnterTeeth);
            panel3.Location = new Point(12, 52);
            panel3.Name = "panel3";
            panel3.Size = new Size(477, 501);
            panel3.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(3, 215);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(466, 41);
            textBox1.TabIndex = 24;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // ExtractionButton
            // 
            ExtractionButton.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ExtractionButton.Location = new Point(125, 384);
            ExtractionButton.Name = "ExtractionButton";
            ExtractionButton.Size = new Size(208, 66);
            ExtractionButton.TabIndex = 33;
            ExtractionButton.Text = "Extraction";
            ExtractionButton.UseVisualStyleBackColor = true;
            ExtractionButton.Click += ExtractionButton_Click;
            // 
            // FillingButton
            // 
            FillingButton.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            FillingButton.Location = new Point(125, 312);
            FillingButton.Name = "FillingButton";
            FillingButton.Size = new Size(208, 66);
            FillingButton.TabIndex = 32;
            FillingButton.Text = "Fill";
            FillingButton.UseVisualStyleBackColor = true;
            FillingButton.Click += FillingButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.DodgerBlue;
            label7.Location = new Point(3, 172);
            label7.Name = "label7";
            label7.Size = new Size(92, 40);
            label7.TabIndex = 21;
            label7.Text = "Cost";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.DodgerBlue;
            label11.Location = new Point(3, 75);
            label11.Name = "label11";
            label11.Size = new Size(316, 40);
            label11.TabIndex = 16;
            label11.Text = "Enter tooth (1 - 32)";
            // 
            // EnterTeeth
            // 
            EnterTeeth.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            EnterTeeth.Location = new Point(3, 118);
            EnterTeeth.Multiline = true;
            EnterTeeth.Name = "EnterTeeth";
            EnterTeeth.Size = new Size(471, 41);
            EnterTeeth.TabIndex = 15;
            EnterTeeth.TextChanged += EnterTeeth_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(122, 9);
            label12.Name = "label12";
            label12.Size = new Size(368, 40);
            label12.TabIndex = 24;
            label12.Text = "Perform Status Check";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label12);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(494, 115);
            panel1.TabIndex = 34;
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
            // PerformStatusCheckWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(493, 560);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "PerformStatusCheckWindow";
            Text = "Select Dentist";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private LinkLabel Cancel;
        private Panel panel3;
        private Label label7;
        private Label label11;
        private TextBox EnterTeeth;
        private Button FillingButton;
        private Button ExtractionButton;
        private TextBox textBox1;
        private Label label12;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}