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
    public partial class FormS : Form
    {
        public FormS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double masa = int.Parse(textBoxMasa.Text);
                double przyspieszenie = int.Parse(textBoxPrzyspieszenie.Text);

                double sila = masa * przyspieszenie;

                sila = Math.Round(sila, 3);

                string komunikat = $"Wynik: {sila} N";

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
            textBoxMasa.Text = string.Empty;
            textBoxPrzyspieszenie.Text = string.Empty;
            labelWynik.Text = "Wynik: ";
        }
    }
}
