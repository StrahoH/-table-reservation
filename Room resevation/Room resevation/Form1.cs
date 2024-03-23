using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static WinFormsDemo.authenticate;


namespace Room_resevation
{
    public partial class Form1 : Form
    {
        private User authenticatedUser;
        public Form1(User user)
        {
            InitializeComponent();
            authenticatedUser = user; // Assign the authenticated user to the local variable

            // Additional initialization or actions based on the authenticated user can be added here
            // For example, you can set labels or perform other operations.
            usernameLabel.Text = $"Welcome, {authenticatedUser.Username}! Choose a table: ";
        }
        SqlConnection Conn = new SqlConnection(@"Data Source=DESKTOP-U7IUME5; Initial Catalog=Reservation; Integrated Security=True;");
     



        private void UpdateDataGridView()
        {
            try
            {
                Conn.Open();

                // Construct the SQL query with parameters for place, price, and type
                string query = "SELECT * FROM reservations WHERE Place = @place AND Price = @price AND Type = @type";
                SqlCommand cmd = new SqlCommand(query, Conn);
                cmd.Parameters.AddWithValue("@place", placebox.Text);
                cmd.Parameters.AddWithValue("@price", pricebox.Text);
                cmd.Parameters.AddWithValue("@type", typebox.Text);

                // Use SqlDataAdapter to fill a DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Display data from DataTable in your DataGridView
                showdata.DataSource = dt;
                if (showdata.Rows.Count == 0)
                {
                    button2.Enabled = false;
                }
                else
                {
                    button2.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable data = ((DataTable)showdata.DataSource).Copy();
            this.Hide(); // Hide the current form instead of closing it
            reservationForm reservationForm = new reservationForm(data, authenticatedUser.Username, authenticatedUser.Password); // Pass data to ReservationForm constructor if needed
            reservationForm.Show();
        }

    }
}

