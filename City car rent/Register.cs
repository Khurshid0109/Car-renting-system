using City_car_rent;
using City_car_rent.Service.Helpers;
using System.Text.RegularExpressions;
using City_car_rent.Service.DTOs.UserDtos;
using City_car_rent.Service.Interfaces.Users;

namespace Car_rental_system
{
    public partial class Register : Form
    {
        private readonly IUserService _userService;
        private UserPostModel user = new UserPostModel();
        public Register()
        {
            InitializeComponent();
            _userService = Program.GetService<IUserService>();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void RegisterButton_Click(object sender, EventArgs e)
        {
            try
            {
                user.Name = NameInput.Text;
                user.Username = UserNameInput.Text;
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
            NameInput.Text = "";
            UserNameInput.Text = "";
            PhoneInput.Text = "";
            PasswordInput.Text = "";
        }

        private void PassportImgButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select Passport Image",
                Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif",
                Multiselect = false
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file path
                string imagePath = openFileDialog.FileName;
                user.PassportImg = imagePath;
                // Now, you can use the imagePath as needed (e.g., save it, display it, etc.)
                MessageBox.Show($"Selected Image: {imagePath}", "Image Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ValidateInputs(UserPostModel user)
        {
            bool valid = true;
            // input validation for name
            string[] nameParts = user.Name.Split(' ');

            if (nameParts.Length != 2 || string.IsNullOrWhiteSpace(nameParts[0]) || string.IsNullOrWhiteSpace(nameParts[1]))
            {
                MessageBox.Show("Invalid name. Please enter both first name and last name separated by a space.",
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

            // input validation for username
            if (!Regex.IsMatch(user.Username, "^[a-zA-Z]+[a-zA-Z0-9]*$"))
            {
                MessageBox.Show("Invalid username. Please enter a valid username.", "Validation Error",
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

            if (!string.IsNullOrEmpty(user.PassportImg) && File.Exists(user.PassportImg))
            {
                string wwwRootPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "wwwroot");
                string passportImagePath = Path.Combine(wwwRootPath, "PassportImage");

                // Ensure the PassportImage folder exists, if not, create it
                if (!Directory.Exists(passportImagePath))
                {
                    Directory.CreateDirectory(passportImagePath);
                }

                string fileName = Path.GetFileName(user.PassportImg);
                string destinationPath = Path.Combine(passportImagePath, fileName);

                File.Copy(user.PassportImg, destinationPath, true);

                // Now,destinationPath contains the path where the file is saved in PassportImage folder
                user.PassportImg = destinationPath; 
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
