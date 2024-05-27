using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace FlightCrane
{
    public partial class Registration_OK : Form
    {
        public Registration_OK()
        {
            InitializeComponent();
            textBox_login.MaxLength = 30;
            textBox_password.MaxLength = 30;
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
            string login = textBox_login.Text.Trim();
            string pass = textBox_password.Text.Trim();
            DateTime currentDateTime = DateTime.Now;
            try
            {
                // Генерация соли
                string salt = BCrypt.Net.BCrypt.GenerateSalt();
                // Хэширование пароля с солью
                string passwordHash = BCrypt.Net.BCrypt.HashPassword(pass, salt);
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO Users (login, password_hash, last_session_date, is_blocked, last_password_change_date) 
                                     VALUES (@login, @password_hash, @last_session_date, @is_blocked, @last_password_change_date)";
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@login", login);
                        command.Parameters.AddWithValue("@password_hash", passwordHash);
                        command.Parameters.AddWithValue("@last_session_date", currentDateTime);
                        command.Parameters.AddWithValue("@is_blocked", false);
                        command.Parameters.AddWithValue("@last_password_change_date", currentDateTime);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Пользователь успешно зарегистрирован", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Не удалось зарегистрировать пользователя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Ошибка при выполнении запроса: {ex.Message}");
            }
        }
    }
}
