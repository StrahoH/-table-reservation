using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Room_resevation
{
    public partial class reservationForm : Form
    {
        private DataTable _data;
        string username = "";
        string password = "";
        public reservationForm(DataTable data, string Username, string Password)
        {
            InitializeComponent();
            _data = data;
            datashow.DataSource = _data;
            foreach (DataRow row in _data.Rows)
            {
                comboBox1.Items.Add(row[0].ToString());
            }
            username = Username;
            password = Password;
        }

        private void Reserve_Click(object sender, EventArgs e)
        {
            int selectedRoomId = int.Parse(comboBox1.SelectedItem.ToString());
            DateTime date = dateTimePicker1.Value;


            string connectionString = @"Data Source=DESKTOP-U7IUME5; Initial Catalog=Reservation; Integrated Security=True";
            string insertQuery = "UPDATE Guests SET date = @Date, room_id = @RoomId WHERE name = @user AND password = @pass";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(insertQuery, connection);

                command.Parameters.AddWithValue("@Date", date);
                command.Parameters.AddWithValue("@RoomId", selectedRoomId);
                command.Parameters.AddWithValue("@user", username);
                command.Parameters.AddWithValue("@pass", password);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show(rowsAffected + " reservation(s) completed");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            this.Hide();
        }
    }
}
