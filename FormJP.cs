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
    public partial class FormJP : Form
    {
        public FormJP()
        {
            InitializeComponent();
        }

        private void buttonZamknij_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonPredkosc_Click(object sender, EventArgs e)
        {
            FormJPPredkosc formJPPredkosc = new FormJPPredkosc();
            formJPPredkosc.ShowDialog();
        }

        private void buttonDroga_Click(object sender, EventArgs e)
        {
            FormJPDroga formJPDroga = new FormJPDroga();
            formJPDroga.ShowDialog();
        }

        private void buttonCzas_Click(object sender, EventArgs e)
        {
            FormJPCzas formJPCzas = new FormJPCzas();
            formJPCzas.ShowDialog();
        }
    }
}
