using System;
using Npgsql;

namespace FlightCrane
{
    public partial class Registration : Form
    {

        public Registration()
        {
            InitializeComponent();
            textBox_UID.MaxLength = 15;
            textBox_Code.MaxLength = 15;
        }

        private void button_registration_Click(object sender, EventArgs e)
        {
            // Параметры подключения
            string host = "217.71.129.139";
            string database = "aero";
            string user = "air";
            string password = "Malidivi6";
            int port = 4671; // Стандартный порт PostgreSQL

            string connectionString = $"Host={host};Database={database};Username={user};Port={port}";

            try
            {

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string uid = textBox_UID.Text.Trim();
                    string code = textBox_Code.Text.Trim();

                    string query = "SELECT COUNT(*) FROM workers WHERE uid = @uid AND authenticity_code = @code";
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@uid", uid);
                        command.Parameters.AddWithValue("@code", code);

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if (count > 0)
                        {
                            Registration_OK registrationOKForm = new Registration_OK();
                            registrationOKForm.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Пользователь не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Ошибка при подключении: {ex.Message}");
            }
        }
    }
}



