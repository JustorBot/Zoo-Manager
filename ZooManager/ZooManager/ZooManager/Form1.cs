using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            progressBar1.Visible = false;
        }

        private void UsernameText_TextChanged(object sender, EventArgs e)
        {
            // Username is entered here
        }

        private void PasswordText_TextChanged(object sender, EventArgs e)
        {
            // Password goes here
            // Mask the password so other people can't see it
            PasswordTest.PasswordChar = '*';
        }

        private async void SignInBtn_Click(object sender, EventArgs e)
        {
            // Username = "Admin" and Password = "12345" are saved in a text file called Login.txt
            string username = "Admin";
            string password = "12345";

            string enteredUsername = UsernameText.Text;
            string enteredPassword = PasswordTest.Text;

            // Check if entered credentials are correct
            if (enteredUsername == username && enteredPassword == password)
            {
                // Show the progress bar
                progressBar1.Visible = true;

                // Animate the progress bar
                for (int i = 0; i <= 100; i++)
                {
                    progressBar1.Value = i;
                    await Task.Delay(5); // Simulated delay
                }

                // Simulate a loading time
                await Task.Delay(1000); // 3 seconds

                MessageBox.Show("Login successful!");

                // Open the Zoo Manager Form
                ZooManagerForm zooManagerForm = new ZooManagerForm();
                zooManagerForm.Show();

                // Close the current login form
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password. Please try again.");
            }

            // Hide the progress bar
            progressBar1.Visible = false;
        }

        private void SkipBtn_Click(object sender, EventArgs e)
        {
            // Exits the program
            Application.Exit();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
