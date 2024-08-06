using City_car_rent;
using City_car_rent.Service.DTOs.CustomerDto;
using City_car_rent.Service.Helpers;
using City_car_rent.Service.Interfaces.Customers;
using System.Text.RegularExpressions;

namespace Car_rental_system
{
    public partial class Register : Form
    {
        private readonly ICustomerService _userService;
        private CustomerPostModel user = new CustomerPostModel();
        public Register()
        {
            InitializeComponent();
            _userService = Program.GetService<ICustomerService>();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void RegisterButton_Click(object sender, EventArgs e)
        {
            try
            {
                user.FirstName = FirstNameInput.Text;
                user.LastName = LastNameInput.Text;
                user.PhoneNumber = PhoneInput.Text;
                user.Password = PasswordInput.Text;

                if (ValidateInputs(user))
                {
                    await _userService.AddAsync(user);


                }
            }
            catch (CustomException ex)
            {
                MessageBox.Show("Exception occured during registration:" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected exception occurred: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            LastNameInput.Text = "";
            FirstNameInput.Text = "";
            PhoneInput.Text = "";
            PasswordInput.Text = "";
        }

        private void PassportImgButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select license Image",
                Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif",
                Multiselect = false
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file path
                string imagePath = openFileDialog.FileName;
                user.DriverLicense = imagePath;
                // Now, you can use the imagePath as needed (e.g., save it, display it, etc.)
                MessageBox.Show($"Selected Image: {imagePath}", "Image Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ValidateInputs(CustomerPostModel user)
        {
            bool valid = true;

            if (string.IsNullOrWhiteSpace(user.FirstName) || string.IsNullOrWhiteSpace(user.LastName))
            {
                MessageBox.Show("Invalid name. Please enter both first name and last name correctly.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }

            // input validation for phone number
            if (!Regex.IsMatch(user.PhoneNumber, @"^\+998\d{9}$"))
            {
                MessageBox.Show("Invalid phone number. Please enter a valid phone number starting with +998.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }

            // input validation for password
            if (user.Password.Length < 6 || !Regex.IsMatch(user.Password, @"\d") || !Regex.IsMatch(user.Password, "[a-zA-Z]"))
            {
                MessageBox.Show("Invalid password. Password must be at least 6 characters long and contain at least one letter .",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valid = false;
            }

            if (!string.IsNullOrEmpty(user.DriverLicense) && File.Exists(user.DriverLicense))
            {
                string wwwRootPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "wwwroot");
                string passportImagePath = Path.Combine(wwwRootPath, "PassportImage");

                // Ensure the PassportImage folder exists, if not, create it
                if (!Directory.Exists(passportImagePath))
                {
                    Directory.CreateDirectory(passportImagePath);
                }

                string fileName = Path.GetFileName(user.DriverLicense);
                string destinationPath = Path.Combine(passportImagePath, fileName);

                File.Copy(user.DriverLicense, destinationPath, true);

                // Now,destinationPath contains the path where the file is saved in PassportImage folder
                user.DriverLicense = destinationPath; 
            }
            else
            {
                MessageBox.Show("Please select a valid passport image file first.");
                valid = false;
            }
            return valid;
        }
    }
}
