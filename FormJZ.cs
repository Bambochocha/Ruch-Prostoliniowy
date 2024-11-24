using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szablon_Aplikacji
{
    public partial class FormJZ : Form
    {
        public FormJZ()
        {
            InitializeComponent();
        }

        private void buttonPredkoscKoncowa_Click(object sender, EventArgs e)
        {
            FormJZVkoncowa formJZVkoncowa = new FormJZVkoncowa();
            formJZVkoncowa.ShowDialog();
        }

        private void buttonZamknij_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonPredkoscKoncowaOpozniony_Click(object sender, EventArgs e)
        {
            FormJZVkoncowaO formJZVkoncowaO = new FormJZVkoncowaO();
            formJZVkoncowaO.ShowDialog();
        }

        private void buttonDroga_Click(object sender, EventArgs e)
        {
            FormJZDroga formJZDroga = new FormJZDroga();
            formJZDroga.ShowDialog();
        }

        private void buttonDrogaOpozniony_Click(object sender, EventArgs e)
        {
            FormJZDrogaO formJZDrogaO = new FormJZDrogaO();
            formJZDrogaO.ShowDialog();
        }
    }
}
