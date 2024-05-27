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
    public partial class SelectStatusForm : Form
    {
        public SelectStatusForm()
        {
            InitializeComponent();

            comboBox_status_change.Items.Add("На аэродроме");
            comboBox_status_change.Items.Add("В ангаре");
            comboBox_status_change.Items.Add("На починке");
            comboBox_status_change.Items.Add("В полёте");

            // Устанавливаем первый элемент списка по умолчанию
            comboBox_status_change.SelectedIndex = 0;
        }

        // Свойство для получения выбранного статуса
        public string SelectedStatus { get; private set; }

        private void button_OK_Click(object sender, EventArgs e)
        {

            SelectedStatus = comboBox_status_change.SelectedItem.ToString();

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
