using Microsoft.VisualBasic.ApplicationServices;
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
using static WinFormsDemo.authenticate;
namespace Room_resevation
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-U7IUME5; Initial Catalog=Reservation; Integrated Security=True";
            string username = uname.Text;
            string Password = password.Text;


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(1) FROM Guests WHERE name = @Username AND password = @Password";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", Password);

                try
                {
                    connection.Open();
                    int userCount = (int)command.ExecuteScalar();

                    if (userCount > 0)
                    {
                        WinFormsDemo.authenticate.User authenticatedUser = DatabaseManager.AuthenticateUser(username, Password);
                        MessageBox.Show("Login successful!");
                        this.Hide();
                        Form1 form = new Form1(authenticatedUser);
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password. Please try again.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
