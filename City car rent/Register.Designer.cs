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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            RegisterLabel = new Label();
            RegisterButton = new Button();
            UserNameLabel = new Label();
            PasswordLabel = new Label();
            UserNameInput = new TextBox();
            PasswordInput = new TextBox();
            ClearButton = new Guna.UI2.WinForms.Guna2Button();
            LoginButton = new Button();
            NameLabel = new Label();
            NameInput = new TextBox();
            PhoneInput = new TextBox();
            PhoneLabel = new Label();
            PassportImgButton = new Button();
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
            guna2PictureBox1.CustomizableEdges = customizableEdges1;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(23, 205);
            guna2PictureBox1.Margin = new Padding(3, 4, 3, 4);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2PictureBox1.Size = new Size(300, 211);
            guna2PictureBox1.TabIndex = 2;
            guna2PictureBox1.TabStop = false;
            // 
            // RegisterLabel
            // 
            RegisterLabel.AutoSize = true;
            RegisterLabel.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            RegisterLabel.ForeColor = Color.Red;
            RegisterLabel.Location = new Point(360, 63);
            RegisterLabel.Name = "RegisterLabel";
            RegisterLabel.Size = new Size(143, 29);
            RegisterLabel.TabIndex = 1;
            RegisterLabel.Text = "REGISTER";
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = Color.Red;
            RegisterButton.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            RegisterButton.ForeColor = Color.White;
            RegisterButton.Location = new Point(486, 516);
            RegisterButton.Margin = new Padding(3, 4, 3, 4);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(207, 49);
            RegisterButton.TabIndex = 2;
            RegisterButton.Text = "REGISTER";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            UserNameLabel.ForeColor = Color.Red;
            UserNameLabel.Location = new Point(360, 205);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(132, 29);
            UserNameLabel.TabIndex = 3;
            UserNameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordLabel.ForeColor = Color.Red;
            PasswordLabel.Location = new Point(360, 335);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(128, 29);
            PasswordLabel.TabIndex = 4;
            PasswordLabel.Text = "Password";
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
            ClearButton.CustomizableEdges = customizableEdges3;
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
            ClearButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ClearButton.Size = new Size(88, 34);
            ClearButton.TabIndex = 7;
            ClearButton.Text = "Clear";
            ClearButton.Click += ClearButton_Click;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.Red;
            LoginButton.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            LoginButton.ForeColor = Color.White;
            LoginButton.Location = new Point(486, 581);
            LoginButton.Margin = new Padding(3, 4, 3, 4);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(207, 49);
            LoginButton.TabIndex = 8;
            LoginButton.Text = "LOGIN";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            NameLabel.ForeColor = Color.Red;
            NameLabel.Location = new Point(360, 145);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(82, 29);
            NameLabel.TabIndex = 9;
            NameLabel.Text = "Name";
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
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            PhoneLabel.ForeColor = Color.Red;
            PhoneLabel.Location = new Point(360, 269);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(88, 29);
            PhoneLabel.TabIndex = 12;
            PhoneLabel.Text = "Phone";
            // 
            // PassportImgButton
            // 
            PassportImgButton.BackColor = Color.Red;
            PassportImgButton.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            PassportImgButton.ForeColor = Color.White;
            PassportImgButton.Location = new Point(360, 401);
            PassportImgButton.Margin = new Padding(3, 4, 3, 4);
            PassportImgButton.Name = "PassportImgButton";
            PassportImgButton.Size = new Size(438, 46);
            PassportImgButton.TabIndex = 13;
            PassportImgButton.Text = "Share your passpord image";
            PassportImgButton.UseVisualStyleBackColor = false;
            PassportImgButton.Click += PassportImgButton_Click;
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
            Controls.Add(PassportImgButton);
            Controls.Add(PhoneLabel);
            Controls.Add(PhoneInput);
            Controls.Add(NameInput);
            Controls.Add(NameLabel);
            Controls.Add(LoginButton);
            Controls.Add(ClearButton);
            Controls.Add(PasswordInput);
            Controls.Add(UserNameInput);
            Controls.Add(PasswordLabel);
            Controls.Add(UserNameLabel);
            Controls.Add(RegisterButton);
            Controls.Add(RegisterLabel);
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
        private System.Windows.Forms.Label RegisterLabel;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox UserNameInput;
        private System.Windows.Forms.TextBox PasswordInput;
        private Guna.UI2.WinForms.Guna2Button ClearButton;
        private Button LoginButton;
        private Label NameLabel;
        private TextBox NameInput;
        private TextBox PhoneInput;
        private Label PhoneLabel;
        private Button PassportImgButton;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
    }
}