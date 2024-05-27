using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace FlightCrane
{
    public partial class Addition : Form
    {
        // Параметры подключения
        string host = "217.71.129.139";
        string database = "aero";
        string user = "air";
        string password = "Malidivi6";
        int port = 4671; // Стандартный порт PostgreSQL

        public Addition()
        {
            InitializeComponent();

            comboBox_status.Size = new Size(206, 41);

            comboBox_status.Items.Add("На аэродроме");
            comboBox_status.Items.Add("В ангаре");
            comboBox_status.Items.Add("На починке");
            comboBox_status.Items.Add("В полёте");
            comboBox_status.SelectedIndex = 0;

            textBox_num.MaxLength = 10;
            textBox_model.MaxLength = 30;
            textBox_company.MaxLength = 30;
            textBox_pilot.MaxLength = 30;
            textBox_passengers.MaxLength = 3;
            textBox_arrival.MaxLength = 10; // формат дд.мм.гггг - 10 символов
            textBox_departure.MaxLength = 10; // формат дд.мм.гггг - 10 символов
            textBox_year.MaxLength = 4;
            textBox_country.MaxLength = 30;
            textBox_route.MaxLength = 50;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            // Строка подключения
            string connectionString = $"Host={host};Database={database};Username={user};Port={port}";

            string num = textBox_num.Text.Trim();
            string model = textBox_model.Text.Trim();
            string company = textBox_company.Text.Trim();
            string pilot = textBox_pilot.Text.Trim();

            int passengers;
            if (!int.TryParse(textBox_passengers.Text.Trim(), out passengers))
            {
                MessageBox.Show("Введите корректное число пассажиров", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string status = comboBox_status.SelectedItem?.ToString();

            if (comboBox_status.SelectedIndex == -1)
            {
                MessageBox.Show("Пожалуйста, выберите статус из выпадающего списка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            DateTime arrival_date;
            DateTime departure_date;
            if (!ValidateDate(textBox_arrival.Text.Trim(), out arrival_date) ||
                !ValidateDate(textBox_departure.Text.Trim(), out departure_date))
            {
                MessageBox.Show("Введите корректные даты в формате дд.мм.гггг. День должен быть в диапазоне 00-31, месяц 01-12, год 1998-2024", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int year_of_commission;
            if (!int.TryParse(textBox_year.Text.Trim(), out year_of_commission) || year_of_commission < 1998 || year_of_commission > 2024)
            {
                MessageBox.Show("Введите корректный год ввода в эксплуатацию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string country = textBox_country.Text.Trim();
            string route = textBox_route.Text.Trim();

            if (string.IsNullOrEmpty(num) || string.IsNullOrEmpty(model) || string.IsNullOrEmpty(company) || string.IsNullOrEmpty(pilot) ||
                string.IsNullOrEmpty(status) || string.IsNullOrEmpty(country) || string.IsNullOrEmpty(route))
            {
                MessageBox.Show("Пожалуйста, заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Создание соединения
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"INSERT INTO Airplanes (tail_number, model, company, pilot, status, passengers, arrival_date, departure_date, year_of_commission, country, route) 
                                     VALUES (@tail_number, @model, @company, @pilot, @status, @passengers, @arrival_date, @departure_date, @year_of_commission, @country, @route)";

                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@tail_number", num);
                        command.Parameters.AddWithValue("@model", model);
                        command.Parameters.AddWithValue("@company", company);
                        command.Parameters.AddWithValue("@pilot", pilot);
                        command.Parameters.AddWithValue("@status", status);
                        command.Parameters.AddWithValue("@passengers", passengers);
                        command.Parameters.AddWithValue("@arrival_date", arrival_date);
                        command.Parameters.AddWithValue("@departure_date", departure_date);
                        command.Parameters.AddWithValue("@year_of_commission", year_of_commission);
                        command.Parameters.AddWithValue("@country", country);
                        command.Parameters.AddWithValue("@route", route);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Самолёт успешно добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Не удалось добавить самолёт", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Ошибка при выполнении запроса: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidateDate(string dateStr, out DateTime date)
        {
            date = DateTime.MinValue;
            if (DateTime.TryParseExact(dateStr, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out date))
            {
                int day = date.Day;
                int month = date.Month;
                int year = date.Year;

                if (day >= 1 && day <= 31 && month >= 1 && month <= 12 && year >= 1998 && year <= 2024)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
