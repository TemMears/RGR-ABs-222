using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;


namespace FlightCrane
{
    public partial class Work : Form
    {
        // Параметры подключения
        string host = "217.71.129.139";
        string database = "aero";
        string user = "air";
        string password = "Malidivi6";
        int port = 4671; // Стандартный порт PostgreSQL

        public Work()
        {
            InitializeComponent();

            pictureBox_air.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;

            this.Load += Work_Load; // Добавление обработчика события Load

        }

        private void Work_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Выход из приложения при закрытии формы
            Application.Exit();
        }

        private void Work_Load(object sender, EventArgs e)
        {
            LoadData();

            dataGridView_air.Columns[0].Visible = false;

            dataGridView_air.Columns["tail_number"].HeaderText = "Борт. номер";
            dataGridView_air.Columns["model"].HeaderText = "Модель";
            dataGridView_air.Columns["company"].HeaderText = "Компания";
            dataGridView_air.Columns["pilot"].HeaderText = "Пилот";
            dataGridView_air.Columns["status"].HeaderText = "Состояние";
            dataGridView_air.Columns["passengers"].HeaderText = "Пассажиры";
            dataGridView_air.Columns["arrival_date"].HeaderText = "Дата прилёта";
            dataGridView_air.Columns["departure_date"].HeaderText = "Дата отлёта";
            dataGridView_air.Columns["year_of_commission"].HeaderText = "Год ввода в экспл.";
            dataGridView_air.Columns["country"].HeaderText = "Страна";
            dataGridView_air.Columns["route"].HeaderText = "Маршрут";
        }

        private void LoadData()
        {
            try
            {
                // Строка подключения
                string connectionString = $"Host={host};Database={database};Username={user};Port={port}";

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Airplanes";
                    //адаптер данных
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection);

                    //для хранения данных
                    DataSet dataSet = new DataSet();

                    adapter.Fill(dataSet, "Airplanes");

                    // Устанавливаем источник данных для dataGridView_air
                    dataGridView_air.DataSource = dataSet.Tables["Airplanes"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void добавитьОбъектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addition addition = new Addition();
            // Открываем форму добавления как диалоговое окно
            if (addition.ShowDialog() == DialogResult.OK)
            {
                // После закрытия формы обновляем данные в таблице
                LoadData();
            }
        }

        private void удалитьОбъектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Проверяем, выбран ли хотя бы один самолет для удаления
            if (dataGridView_air.SelectedRows.Count > 0)
            {
                try
                {
                    // Получаем airplane_id выбранного самолета
                    int airplaneId = (int)dataGridView_air.SelectedRows[0].Cells["airplane_id"].Value;

                    // Строка подключения
                    string connectionString = $"Host={host};Database={database};Username={user};Port={port}";

                    using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "DELETE FROM Airplanes WHERE airplane_id = @airplaneId";

                        using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@airplaneId", airplaneId);

                            int rowsAffected = command.ExecuteNonQuery();

                            // Проверяем, был ли удален хотя бы один самолет
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Самолет успешно удален", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("Не удалось удалить самолет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении самолета: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите самолет для удаления", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void состояниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Строка подключения
            string connectionString = $"Host={host};Database={database};Username={user};Port={port}";

            // Проверяем, выбран ли хотя бы один самолёт в DataGridView
            if (dataGridView_air.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите самолёт для изменения статуса.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SelectStatusForm selectStatusForm = new SelectStatusForm();

            if (selectStatusForm.ShowDialog() == DialogResult.OK)
            {
                // новый статус
                string newStatus = selectStatusForm.SelectedStatus;

                List<int> airplaneIds = new List<int>();

                // Получаем идентификаторы выбранных самолетов
                foreach (DataGridViewRow row in dataGridView_air.SelectedRows)
                {
                    int airplaneId = Convert.ToInt32(row.Cells[0].Value);
                    airplaneIds.Add(airplaneId);
                }

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE Airplanes SET status = @newStatus WHERE airplane_id = @airplaneId";

                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@newStatus", newStatus);

                        // Обновляем статус для каждого выбранного самолета
                        foreach (int airplaneId in airplaneIds)
                        {
                            command.Parameters.AddWithValue("@airplaneId", airplaneId);
                            command.ExecuteNonQuery();
                            command.Parameters.RemoveAt("@airplaneId");
                        }
                    }
                }


            }
        }

        private void обновитьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void маршрутToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Проверяем, выбран ли хотя бы один самолёт в DataGridView
            if (dataGridView_air.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите самолёт для изменения маршрута.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ChangeRoute routeForm = new ChangeRoute();
            if (routeForm.ShowDialog() == DialogResult.OK)
            {
                //новый маршрут
                string newRoute = routeForm.NewRoute;

                // Получаем ID выбранного самолета
                int selectedRowIndex = dataGridView_air.SelectedRows[0].Index;
                int airplaneId = Convert.ToInt32(dataGridView_air.Rows[selectedRowIndex].Cells["airplane_id"].Value);

                try
                {
                    // Строка подключения
                    string connectionString = $"Host={host};Database={database};Username={user};Port={port}";

                    using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "UPDATE Airplanes SET route = @newRoute WHERE airplane_id = @airplaneId";
                        using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@newRoute", newRoute);
                            command.Parameters.AddWithValue("@airplaneId", airplaneId);
                            command.ExecuteNonQuery();
                        }
                    }

                    dataGridView_air.Rows[selectedRowIndex].Cells["route"].Value = newRoute;

                    MessageBox.Show($"Маршрут успешно изменён на '{newRoute}'.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при обновлении маршрута: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void пилотToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView_air.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите самолёт для изменения пилота.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ChangePilot pilotForm = new ChangePilot();
            if (pilotForm.ShowDialog() == DialogResult.OK)
            {

                string newPilot = pilotForm.NewPilot;

                int selectedRowIndex = dataGridView_air.SelectedRows[0].Index;
                int airplaneId = Convert.ToInt32(dataGridView_air.Rows[selectedRowIndex].Cells["airplane_id"].Value);

                try
                {
                    // Строка подключения
                    string connectionString = $"Host={host};Database={database};Username={user};Port={port}";

                    // Обновляем пилота в базе данных
                    using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "UPDATE Airplanes SET pilot = @newPilot WHERE airplane_id = @airplaneId";
                        using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@newPilot", newPilot);
                            command.Parameters.AddWithValue("@airplaneId", airplaneId);
                            command.ExecuteNonQuery();
                        }
                    }

                    // Обновляем пилота в DataGridView
                    dataGridView_air.Rows[selectedRowIndex].Cells["pilot"].Value = newPilot;

                    MessageBox.Show($"Пилот успешно изменён на '{newPilot}'.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при обновлении пилота: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void датаПрилётаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // выбран ли хотя бы один самолёт в DataGridView
            if (dataGridView_air.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите самолёт для изменения даты прилёта.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ChangeArrivalDateForm arrivalDateForm = new ChangeArrivalDateForm();
            if (arrivalDateForm.ShowDialog() == DialogResult.OK)
            {
                DateTime newArrivalDate = arrivalDateForm.NewDate;

                // Получаем ID выбранного самолета
                int selectedRowIndex = dataGridView_air.SelectedRows[0].Index;
                int airplaneId = Convert.ToInt32(dataGridView_air.Rows[selectedRowIndex].Cells["airplane_id"].Value);

                try
                {
                    // Строка подключения
                    string connectionString = $"Host={host};Database={database};Username={user};Port={port}";

                    // Обновляем дату прилета в базе данных
                    using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "UPDATE Airplanes SET arrival_date = @newArrivalDate WHERE airplane_id = @airplaneId";
                        using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@newArrivalDate", newArrivalDate);
                            command.Parameters.AddWithValue("@airplaneId", airplaneId);
                            command.ExecuteNonQuery();
                        }
                    }

                    // Обновляем дату прилета в DataGridView
                    dataGridView_air.Rows[selectedRowIndex].Cells["arrival_date"].Value = newArrivalDate;

                    MessageBox.Show($"Дата прилёта успешно изменена на '{newArrivalDate:dd.MM.yyyy}'.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при обновлении даты прилёта: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void датаОтлётаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Проверяем, выбран ли хотя бы один самолёт в DataGridView
            if (dataGridView_air.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите самолёт для изменения даты отлёта.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ChangeArrivalDateForm departureDateForm = new ChangeArrivalDateForm();
            if (departureDateForm.ShowDialog() == DialogResult.OK)
            {
                // Получаем новую дату отлета
                DateTime newDepartureDate = departureDateForm.NewDate;

                // Получаем ID выбранного самолета
                int selectedRowIndex = dataGridView_air.SelectedRows[0].Index;
                int airplaneId = Convert.ToInt32(dataGridView_air.Rows[selectedRowIndex].Cells["airplane_id"].Value);

                try
                {
                    // Строка подключения
                    string connectionString = $"Host={host};Database={database};Username={user};Port={port}";

                    // Обновляем дату отлета в базе данных
                    using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "UPDATE Airplanes SET departure_date = @newDepartureDate WHERE airplane_id = @airplaneId";
                        using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@newDepartureDate", newDepartureDate);
                            command.Parameters.AddWithValue("@airplaneId", airplaneId);
                            command.ExecuteNonQuery();
                        }
                    }

                    // Обновляем дату отлета в DataGridView
                    dataGridView_air.Rows[selectedRowIndex].Cells["departure_date"].Value = newDepartureDate;

                    MessageBox.Show($"Дата отлёта успешно изменена на '{newDepartureDate:dd.MM.yyyy}'.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при обновлении даты отлёта: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void создатьОтчётToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Строка подключения
                string connectionString = $"Host={host};Database={database};Username={user};Port={port}";

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Airplanes ORDER BY " +
                                   "CASE " +
                                   "WHEN status = 'На взлётной полосе' THEN 1 " +
                                   "WHEN status = 'В ангаре' THEN 2 " +
                                   "WHEN status = 'На починке' THEN 3 " +
                                   "WHEN status = 'В полёте' THEN 4 " +
                                   "ELSE 5 " +
                                   "END";

                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet, "Airplanes");

                    // Получаем путь к рабочему столу
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string filePath = Path.Combine(desktopPath, "Отчет_по_самолетам.docx");

                    using (var document = DocX.Create(filePath))
                    {
                        document.InsertParagraph("Отчёт по самолётам").FontSize(20).Bold().Alignment = Alignment.center;

                        DataTable table = dataSet.Tables["Airplanes"];
                        var statusGroups = table.AsEnumerable()
                            .GroupBy(row => row.Field<string>("status"))
                            .OrderBy(g => g.Key)
                            .ToList();

                        foreach (var group in statusGroups)
                        {
                            // Добавляем статус
                            document.InsertParagraph($"Статус: {group.Key}").FontSize(14).Bold();

                            foreach (var row in group)
                            {
                                string tailNumber = row.Field<string>("tail_number");
                                string model = row.Field<string>("model");
                                string company = row.Field<string>("company");
                                string pilot = row.Field<string>("pilot");
                                int passengers = row.Field<int>("passengers");
                                string arrivalDate = row.Field<DateTime?>("arrival_date")?.ToString("dd.MM.yyyy") ?? "N/A";
                                string departureDate = row.Field<DateTime?>("departure_date")?.ToString("dd.MM.yyyy") ?? "N/A";
                                int yearOfCommission = row.Field<int>("year_of_commission");
                                string country = row.Field<string>("country");
                                string route = row.Field<string>("route");

                                // Добавляем бортовой номер
                                document.InsertParagraph($"Бортовой номер: {tailNumber}").FontSize(13).Bold();

                                // Добавляем детали самолёта
                                document.InsertParagraph($"• Модель: {model}").FontSize(12);
                                document.InsertParagraph($"• Компания: {company}").FontSize(12);
                                document.InsertParagraph($"• Пилот: {pilot}").FontSize(12);
                                document.InsertParagraph($"• Пассажиры: {passengers}").FontSize(12);
                                document.InsertParagraph($"• Дата прилёта: {arrivalDate}").FontSize(12);
                                document.InsertParagraph($"• Дата отлёта: {departureDate}").FontSize(12);
                                document.InsertParagraph($"• Год ввода в эксплуатацию: {yearOfCommission}").FontSize(12);
                                document.InsertParagraph($"• Страна: {country}").FontSize(12);
                                document.InsertParagraph($"• Маршрут: {route}").FontSize(12);
                            }
                        }

                        document.Save();
                    }

                    MessageBox.Show("Отчёт успешно создан и сохранён как 'Отчет_по_самолетам.docx'", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании отчёта: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void общаяТаблицаВсехСамолётовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox_air.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;

            dataGridView_air.Visible = true;
            LoadData();
        }

        private void LoadAbsentPlanesData()
        {
            try
            {
                // Строка подключения
                string connectionString = $"Host={host};Database={database};Username={user};Port={port}";

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Airplanes WHERE status = 'В полёте'";

                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection);

                    DataSet dataSet = new DataSet();

                    adapter.Fill(dataSet, "Airplanes");

                    dataGridView_air.DataSource = dataSet.Tables["Airplanes"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void таблицаОтсутствующихСамолётовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox_air.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;

            dataGridView_air.Visible = true;
            // Загружаем данные только для самолетов со статусом "В полёте"
            LoadAbsentPlanesData();

        }

        private void основнаяТаблицаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox_air.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;

            dataGridView_air.Visible = true;
            try
            {
                // Строка подключения
                string connectionString = $"Host={host};Database={database};Username={user};Port={port}";

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Airplanes WHERE status != 'В полёте'";

                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection);

                    DataSet dataSet = new DataSet();

                    adapter.Fill(dataSet, "Airplanes");

                    dataGridView_air.DataSource = dataSet.Tables["Airplanes"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void интерактивныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView_air.Visible = false;


            // Получаем количество самолётов в каждом статусе
            int onRunwayCount = GetAirplaneCountByStatus("На аэродроме");
            int inHangarCount = GetAirplaneCountByStatus("В ангаре");
            int underMaintenanceCount = GetAirplaneCountByStatus("На починке");

            SetPictureBoxVisibility(onRunwayCount, 1, 5);
            SetPictureBoxVisibility(inHangarCount, 6, 9);
            SetPictureBoxVisibility(inHangarCount, 14, 17, 4); // С учётом смещения
            SetPictureBoxVisibility(underMaintenanceCount, 10, 13);

            pictureBox_air.Visible = true;
        }

        private int GetAirplaneCountByStatus(string status)
        {
            int count = 0;
            try
            {
                // Строка подключения
                string connectionString = $"Host={host};Database={database};Username={user};Port={port}";

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Airplanes WHERE status = @status";

                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@status", status);
                        count = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return count;
        }

        private void SetPictureBoxVisibility(int count, int startIndex, int endIndex, int offset = 0)
        {
            // Показываем нужное количество PictureBox
            for (int i = startIndex; i < startIndex + count && i <= endIndex; i++)
            {
                PictureBox pb = Controls.Find($"pictureBox{i + offset}", true).FirstOrDefault() as PictureBox;
                if (pb != null)
                {
                    pb.Visible = true;
                }
            }
        }
    }
}