namespace Car_rental_system
{
    partial class Register
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            label5 = new Label();
            button1 = new Button();
            label6 = new Label();
            label7 = new Label();
            UserNameInput = new TextBox();
            PasswordInput = new TextBox();
            ClearButton = new Guna.UI2.WinForms.Guna2Button();
            button2 = new Button();
            label8 = new Label();
            NameInput = new TextBox();
            PhoneInput = new TextBox();
            label9 = new Label();
            PassportImg = new Button();
            npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(guna2PictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(354, 655);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Lime;
            label4.Location = new Point(55, 581);
            label4.Name = "label4";
            label4.Size = new Size(207, 31);
            label4.TabIndex = 6;
            label4.Text = "Wonderfull price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Lime;
            label3.Location = new Point(119, 526);
            label3.Name = "label3";
            label3.Size = new Size(206, 31);
            label3.TabIndex = 5;
            label3.Text = "Quality Guaranty";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(55, 472);
            label2.Name = "label2";
            label2.Size = new Size(196, 31);
            label2.TabIndex = 4;
            label2.Text = "Various options";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(75, 61);
            label1.Name = "label1";
            label1.Size = new Size(174, 32);
            label1.TabIndex = 3;
            label1.Text = "Rent car city";
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.CustomizableEdges = customizableEdges5;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(23, 205);
            guna2PictureBox1.Margin = new Padding(3, 4, 3, 4);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2PictureBox1.Size = new Size(300, 211);
            guna2PictureBox1.TabIndex = 2;
            guna2PictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(360, 63);
            label5.Name = "label5";
            label5.Size = new Size(143, 29);
            label5.TabIndex = 1;
            label5.Text = "REGISTER";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(486, 516);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(207, 49);
            button1.TabIndex = 2;
            button1.Text = "REGISTER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(360, 205);
            label6.Name = "label6";
            label6.Size = new Size(132, 29);
            label6.TabIndex = 3;
            label6.Text = "Username";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(360, 335);
            label7.Name = "label7";
            label7.Size = new Size(128, 29);
            label7.TabIndex = 4;
            label7.Text = "Password";
            label7.Click += label7_Click;
            // 
            // UserNameInput
            // 
            UserNameInput.BackColor = Color.Silver;
            UserNameInput.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            UserNameInput.Location = new Point(512, 205);
            UserNameInput.Margin = new Padding(3, 4, 3, 4);
            UserNameInput.Multiline = true;
            UserNameInput.Name = "UserNameInput";
            UserNameInput.Size = new Size(286, 36);
            UserNameInput.TabIndex = 5;
            // 
            // PasswordInput
            // 
            PasswordInput.BackColor = Color.Silver;
            PasswordInput.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordInput.Location = new Point(512, 335);
            PasswordInput.Margin = new Padding(3, 4, 3, 4);
            PasswordInput.Multiline = true;
            PasswordInput.Name = "PasswordInput";
            PasswordInput.Size = new Size(286, 36);
            PasswordInput.TabIndex = 6;
            // 
            // ClearButton
            // 
            ClearButton.CustomizableEdges = customizableEdges7;
            ClearButton.DisabledState.BorderColor = Color.DarkGray;
            ClearButton.DisabledState.CustomBorderColor = Color.DarkGray;
            ClearButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ClearButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ClearButton.FillColor = Color.Red;
            ClearButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ClearButton.ForeColor = Color.White;
            ClearButton.Location = new Point(757, 0);
            ClearButton.Margin = new Padding(3, 4, 3, 4);
            ClearButton.Name = "ClearButton";
            ClearButton.ShadowDecoration.CustomizableEdges = customizableEdges8;
            ClearButton.Size = new Size(88, 34);
            ClearButton.TabIndex = 7;
            ClearButton.Text = "Clear";
            ClearButton.Click += ClearButton_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(486, 581);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(207, 49);
            button2.TabIndex = 8;
            button2.Text = "LOGIN";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(360, 145);
            label8.Name = "label8";
            label8.Size = new Size(82, 29);
            label8.TabIndex = 9;
            label8.Text = "Name";
            // 
            // NameInput
            // 
            NameInput.AutoCompleteSource = AutoCompleteSource.RecentlyUsedList;
            NameInput.BackColor = Color.Silver;
            NameInput.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            NameInput.Location = new Point(512, 145);
            NameInput.Margin = new Padding(3, 4, 3, 4);
            NameInput.Multiline = true;
            NameInput.Name = "NameInput";
            NameInput.PlaceholderText = "FullName";
            NameInput.Size = new Size(286, 36);
            NameInput.TabIndex = 10;
            NameInput.UseWaitCursor = true;
            // 
            // PhoneInput
            // 
            PhoneInput.BackColor = Color.Silver;
            PhoneInput.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            PhoneInput.Location = new Point(512, 269);
            PhoneInput.Margin = new Padding(3, 4, 3, 4);
            PhoneInput.Multiline = true;
            PhoneInput.Name = "PhoneInput";
            PhoneInput.PlaceholderText = "+998 *** ** **";
            PhoneInput.Size = new Size(286, 36);
            PhoneInput.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(360, 269);
            label9.Name = "label9";
            label9.Size = new Size(88, 29);
            label9.TabIndex = 12;
            label9.Text = "Phone";
            // 
            // PassportImg
            // 
            PassportImg.BackColor = Color.Red;
            PassportImg.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            PassportImg.ForeColor = Color.White;
            PassportImg.Location = new Point(360, 401);
            PassportImg.Margin = new Padding(3, 4, 3, 4);
            PassportImg.Name = "PassportImg";
            PassportImg.Size = new Size(438, 46);
            PassportImg.TabIndex = 13;
            PassportImg.Text = "Share your passpord image";
            PassportImg.UseVisualStyleBackColor = false;
            // 
            // npgsqlCommandBuilder1
            // 
            npgsqlCommandBuilder1.QuotePrefix = "\"";
            npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(847, 655);
            Controls.Add(PassportImg);
            Controls.Add(label9);
            Controls.Add(PhoneInput);
            Controls.Add(NameInput);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(ClearButton);
            Controls.Add(PasswordInput);
            Controls.Add(UserNameInput);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Register_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox UserNameInput;
        private System.Windows.Forms.TextBox PasswordInput;
        private Guna.UI2.WinForms.Guna2Button ClearButton;
        private Button button2;
        private Label label8;
        private TextBox NameInput;
        private TextBox PhoneInput;
        private Label label9;
        private Button PassportImg;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
    }
}