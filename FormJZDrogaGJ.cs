﻿using System;
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
    public partial class FormJZDrogaGJ : Form
    {
        public FormJZDrogaGJ()
        {
            InitializeComponent();
        }

        private void buttonOblicz_Click(object sender, EventArgs e)
        {
            try
            {
                double przyspieszenie = int.Parse(textBoxPrzyspieszenie.Text);
                double V0 = int.Parse(textBoxPredkosc0.Text);
                double czas = int.Parse(textBoxCzas.Text);

                double droga = (V0 * czas) + ((przyspieszenie * (czas * czas)) / 2);

                droga = Math.Round(droga, 3);

                string komunikat = $"Wynik: {droga} m/s";

                labelWynik.Text = komunikat;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonWyczysc_Click(object sender, EventArgs e)
        {
            textBoxCzas.Text = string.Empty;
            textBoxPrzyspieszenie.Text = string.Empty;
            textBoxPredkosc0.Text = string.Empty;
            labelWynik.Text = "Wynik: ";
        }

        private void buttonZamknij_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormJZDrogaGJ_Load(object sender, EventArgs e)
        {

        }
    }
}