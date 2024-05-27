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

namespace FlightCrane
{
    public partial class ForgotPassword : Form
    {

        public ForgotPassword()
        {
            InitializeComponent();
            textBox_NewPassword.Visible = false;
            button_ChangePassword.Visible = false;
            textBox_login.MaxLength = 30;
            textBox_NewPassword.MaxLength = 30;
            textBox_UID.MaxLength = 15;
        }


        private void button_OK_Click(object sender, EventArgs e)
        {
            string uid = textBox_UID.Text.Trim();
            string login = textBox_login.Text.Trim();

            if (ValidateUser(uid, login))
            {
                textBox_UID.Visible = false;
                textBox_login.Visible = false;
                textBox_NewPassword.Visible = true;
                button_ChangePassword.Visible = true;
                button_OK.Visible = false;
            }
            else
            {
                MessageBox.Show("Неверный UID или логин", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateUser(string uid, string login)
        {
            // Параметры подключения
            string host = "217.71.129.139";
            string database = "aero";
            string user = "postgres";
            //string password = "Malidivi6"; Password={password};
            int port = 4671; // Стандартный порт PostgreSQL

            // Строка подключения
            string connectionString = $"Host={host};Database={database};Username={user};Port={port}";


            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Users WHERE login = @login";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@login", login);
                    int userCount = Convert.ToInt32(command.ExecuteScalar());
                    if (userCount == 0)
                    {
                        return false;
                    }
                }

                query = "SELECT COUNT(*) FROM Workers WHERE uid = @uid";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@uid", uid);
                    int workerCount = Convert.ToInt32(command.ExecuteScalar());
                    if (workerCount == 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private void UpdatePassword(string uid, string login, string newPasswordHash)
        {
            string host = "217.71.129.139";
            string database = "aero";
            string user = "postgres";
            //string password = "Malidivi6"; Password={password};
            int port = 4671; // Стандартный порт PostgreSQL

            // Строка подключения
            string connectionString = $"Host={host};Database={database};Username={user};Port={port}";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE Users SET password_hash = @newPasswordHash, last_password_change_date = @currentDateTime WHERE login = @login";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@newPasswordHash", newPasswordHash);
                    command.Parameters.AddWithValue("@currentDateTime", DateTime.Now);
                    command.Parameters.AddWithValue("@login", login);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void button_ChangePassword_Click(object sender, EventArgs e)
        {
            string newPassword = textBox_NewPassword.Text.Trim();

            // Проверка наличия символов в новом пароле
            if (string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Введите новый пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Хэширование нового пароля
            string newPasswordHash = BCrypt.Net.BCrypt.HashPassword(newPassword);

            // Обновление пароля в базе данных
            UpdatePassword(textBox_UID.Text.Trim(), textBox_login.Text.Trim(), newPasswordHash);

            MessageBox.Show("Пароль успешно изменен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
