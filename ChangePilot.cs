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
    public partial class ChangePilot : Form
    {
        public ChangePilot()
        {
            InitializeComponent();
            textBox_pilot.MaxLength = 30;
        }
        // Свойство для получения нового пилота
        public string NewPilot { get; private set; }

        private void button_OK_Click(object sender, EventArgs e)
        {
            NewPilot = textBox_pilot.Text.Trim();

            if (string.IsNullOrWhiteSpace(NewPilot))
            {
                MessageBox.Show("Введите имя нового пилота.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
