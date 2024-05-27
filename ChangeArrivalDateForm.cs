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
    public partial class ChangeArrivalDateForm : Form
    {
        public ChangeArrivalDateForm()
        {
            InitializeComponent();
            textBox_date.MaxLength = 10;
        }

        // Свойство для получения новой даты прилета
        public DateTime NewDate { get; private set; }

        private void button_OK_Click(object sender, EventArgs e)
        {
            // Проверка корректности даты
            if (IsValidDate(textBox_date.Text.Trim(), out DateTime parsedDate))
            {
                if (parsedDate.Year >= 1998 && parsedDate.Year <= 2024)
                {
                    NewDate = parsedDate;
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Год должен быть в диапазоне от 1998 до 2024.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Введите корректную дату в формате дд.мм.гггг.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool IsValidDate(string dateStr, out DateTime date)
        {
            date = DateTime.MinValue;
            if (DateTime.TryParseExact(dateStr, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out date))
            {
                if (date.Day >= 1 && date.Day <= 31 && date.Month >= 1 && date.Month <= 12)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
