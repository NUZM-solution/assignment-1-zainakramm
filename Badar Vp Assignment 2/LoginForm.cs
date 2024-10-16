using System;
using System.Windows.Forms;

namespace LoginAndDataGridApp
{
    public partial class LoginForm : Form
    {
        private int attemptCount = 3; // Counter to track login attempts

        public LoginForm() // Constructor
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Clear text boxes on form load
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            string correctUsername = "Badar Ameer"; // Your username
            string correctPassword = "20011556-156"; // Your roll number

            if (txtUsername.Text == correctUsername && txtPassword.Text == correctPassword)
            {
                MessageBox.Show("Correct Login", "Login Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DataGridForm dataGridForm = new DataGridForm(); // Open DataGridForm
                dataGridForm.Show();
                this.Hide(); // Hide login form
            }
            else
            {
                attemptCount--; // Reduce attempt count by 1
                if (attemptCount > 0)
                {
                    MessageBox.Show($"Login Failed. Only {attemptCount} attempt(s) left.",
                                    "Login Status",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("All attempts exhausted! The application will now exit.",
                                    "Login Status",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    Environment.Exit(0); // Exit the application
                }
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            // Optional: Handle text changes if needed
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            // Optional: Handle password changes
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); // Close the application
        }

        // Clear button functionality
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear(); // Clear username field
            txtPassword.Clear(); // Clear password field
        }
    }
}
