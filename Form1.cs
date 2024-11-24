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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMatematyka_Click(object sender, EventArgs e)
        {
            FormS formS = new FormS();
            formS.ShowDialog();
        }

        private void buttonPomoc_Click(object sender, EventArgs e)
        {
            FormP formP = new FormP();
            formP.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonPolski_Click(object sender, EventArgs e)
        {
            FormJZ formJZ = new FormJZ();
            formJZ.ShowDialog();
        }

        private void buttonFizyka_Click(object sender, EventArgs e)
        {
            FormJP formJP = new FormJP();
            formJP.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
