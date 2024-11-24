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
    public partial class FormJPPredkosc : Form
    {
        public FormJPPredkosc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double droga = int.Parse(textBoxDroga.Text);
                double czas = int.Parse(textBoxCzas.Text);

                double predkosc = droga / czas;

                predkosc = Math.Round(predkosc, 3);

                string komunikat = $"Wynik: {predkosc} m/s";

                labelWynik.Text = komunikat;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonZamknij_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonWyczysc_Click(object sender, EventArgs e)
        {
            textBoxCzas.Text = string.Empty;
            textBoxDroga.Text = string.Empty;
            labelWynik.Text = "Wynik: ";
        }
    }
}
