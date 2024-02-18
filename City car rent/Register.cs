namespace Car_rental_system
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            NameInput.Text = "";
            UserNameInput.Text = "";
            PhoneInput.Text = "";
            PasswordInput.Text = "";
        }
    }
}
