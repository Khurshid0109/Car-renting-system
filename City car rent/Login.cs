﻿namespace Car_rental_system
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            UserNameInput.Text = "";
            PasswordInput.Text = "";
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

        }
    }
}
