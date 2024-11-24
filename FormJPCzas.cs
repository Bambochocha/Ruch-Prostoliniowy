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
    public partial class FormJPCzas : Form
    {
        public FormJPCzas()
        {
            InitializeComponent();
        }

        private void buttonOblicz_Click(object sender, EventArgs e)
        {
            try
            {
                double predkosc = int.Parse(textBoxPredkosc.Text);
                double droga = int.Parse(textBoxDroga.Text);

                double czas = droga / predkosc;

                czas = Math.Round(czas, 3);

                string komunikat = $"Wynik: {czas} m/s";

                labelWynik.Text = komunikat;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonWyczysc_Click(object sender, EventArgs e)
        {
            textBoxDroga.Text = string.Empty;
            textBoxPredkosc.Text = string.Empty;
            labelWynik.Text = "Wynik: ";
        }

        private void buttonZamknij_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
