using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Szablon_Aplikacji
{
    public partial class FormP2 : Form
    {
        public FormP2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double sila = int.Parse(textBoxSila.Text);
                double masa = int.Parse(textBoxMasa.Text);

                double przyspieszenie = sila / masa;

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
            textBoxSila.Text = string.Empty;
            textBoxMasa.Text = string.Empty;
            labelWynik.Text = "Wynik: ";
        }
    }
}
