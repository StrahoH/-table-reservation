using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Room_resevation
{
    public partial class regester : Form
    {
        public regester()
        {
            InitializeComponent();
        }
        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn logIn = new LogIn();
            logIn.Show();
        }

        private bool IsPasswordValid(string password)
        {
            return password.Length >= 8 &&
                   password.Any(char.IsUpper) &&
                   password.Any(char.IsDigit) &&
                   password.Any(ch => !char.IsLetterOrDigit(ch));
        }
      
        private void criteria(string password)
        {
            // Check if the password box is empty
            if (string.IsNullOrEmpty(password))
            {
                p8.Enabled = false;
                pn.Enabled = false;
                pc.Enabled = false;
                ps.Enabled = false;
                return;
            }

            // Enable the labels
            p8.Enabled = true;
            pn.Enabled = true;
            pc.Enabled = true;
            ps.Enabled = true;

            // Check password length
            if (password.Length < 8)
            {
                p8.ForeColor = Color.Red;
            }
            else
            {
                p8.ForeColor = Color.Green;
            }

            // Check for at least one number
            if (password.Any(char.IsDigit))
            {
                pn.ForeColor = Color.Green;
            }
            else
            {
                pn.ForeColor = Color.Red;
            }

            // Check for at least one capital letter
            if (password.Any(char.IsUpper))
            {
                pc.ForeColor = Color.Green;
            }
            else
            {
                pc.ForeColor = Color.Red;
            }

            // Check for at least one special character
            if (password.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                ps.ForeColor = Color.Green;
            }
            else
            {
                ps.ForeColor = Color.Red;
            }
        }
        private bool IsEmailValid(string email)
        {
            try
            {
                // Check for empty email address
                if (string.IsNullOrWhiteSpace(email))
                {
                    throw new Exception("Email address is empty.");
                }

                // Check for spaces
                if (email.Contains(" "))
                {
                    throw new Exception("Email address contains spaces.");
                }

                // Check for special characters
                string allowedChars = ".@!#$%&'*+-/=?^_`{|}~"; // Allowed special characters
                foreach (char ch in email)
                {
                    if (!(char.IsLetterOrDigit(ch) || allowedChars.Contains(ch)))
                    {
                        throw new Exception("Email address contains invalid characters.");
                    }
                }

                // Check for "@" symbol
                int atIndex = email.IndexOf('@');
                if (atIndex == -1 || atIndex == 0 || atIndex == email.Length - 1)
                {
                    throw new Exception("Email address is missing '@' symbol or incorrectly placed.");
                }

                // Check for "." after "@"
                int dotIndex = email.LastIndexOf('.');
                if (dotIndex == -1 || dotIndex < atIndex)
                {
                    throw new Exception("Email address is missing '.' after '@' symbol or incorrectly placed.");
                }

                return true;
            }
            catch (Exception ex)
            {
                // Catch any exceptions and return false with an explanation
                MessageBox.Show("Email validation failed: " + ex.Message);
                return false;
            }
        }


        private void Signin_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-U7IUME5; Initial Catalog=Reservation; Integrated Security=True";
            string selectQuery = "SELECT COUNT(1) FROM Guests WHERE name = @Name";
            string insertQuery = "INSERT INTO Guests (name, email, password) VALUES (@Name, @Email, @Password)";
            string username = name.Text;
            string Email = email.Text;
            string password = pass.Text;
            // Validate password
            if (!IsPasswordValid(password))
            {
                MessageBox.Show("Password must be at least 8 characters long and contain at least one uppercase letter, one number, and one special character.");
                return;
            }

            // Validate email
            if (!IsEmailValid(Email))
            {
                MessageBox.Show("Invalid email format. Please provide a valid email address.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
                selectCommand.Parameters.AddWithValue("@Name", username);

                try
                {
                    connection.Open();
                    int userCount = (int)selectCommand.ExecuteScalar();

                    if (userCount > 0)
                    {
                        MessageBox.Show("Username already exists. Please provide a different username.");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return;
                }

                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@Name", username);
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@Password", password);

                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show("Welcome, " + username + "!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            this.Hide();
        }

        private void pass_TextChanged_1(object sender, EventArgs e)
        {
            string password = pass.Text;
            criteria(password);
        }
    }
}
