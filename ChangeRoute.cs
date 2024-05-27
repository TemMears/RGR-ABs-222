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
    public partial class ChangeRoute : Form
    {
        public ChangeRoute()
        {
            InitializeComponent();
            textBox_route.MaxLength = 50;
        }
        // Свойство для получения нового маршрута
        public string NewRoute { get; private set; }

        private void button_OK_Click(object sender, EventArgs e)
        {

            NewRoute = textBox_route.Text.Trim();

            if (string.IsNullOrWhiteSpace(NewRoute))
            {
                MessageBox.Show("Введите новый маршрут.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
