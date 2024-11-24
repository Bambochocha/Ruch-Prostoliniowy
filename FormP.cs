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
    public partial class FormP : Form
    {
        public FormP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double Vkońcowa = int.Parse(textBoxVkoncowa.Text);
                double V0 = int.Parse(textBoxV0.Text);
                double czas = int.Parse(textBoxCzas.Text);

                double przyspieszenie = (Vkońcowa - V0) / czas;

                przyspieszenie = Math.Round(przyspieszenie, 3);

                string komunikat = $"Wynik: {przyspieszenie} m/s2";

                labelWynik.Text = komunikat;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonMatematyka_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxVkoncowa.Text = string.Empty;
            textBoxV0.Text = string.Empty;
            textBoxCzas.Text = string.Empty;
            labelWynik.Text = "Wynik: ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormP2 form = new FormP2();
            form.ShowDialog();
        }
    }
}
