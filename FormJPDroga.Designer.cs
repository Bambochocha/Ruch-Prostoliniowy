﻿namespace Szablon_Aplikacji
{
    partial class FormJPDroga
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJPDroga));
            this.labelWynik = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCzas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPredkosc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonZamknij = new System.Windows.Forms.Button();
            this.buttonOblicz = new System.Windows.Forms.Button();
            this.buttonWyczysc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWynik
            // 
            this.labelWynik.AutoSize = true;
            this.labelWynik.BackColor = System.Drawing.Color.Transparent;
            this.labelWynik.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWynik.ForeColor = System.Drawing.Color.White;
            this.labelWynik.Location = new System.Drawing.Point(27, 183);
            this.labelWynik.Name = "labelWynik";
            this.labelWynik.Size = new System.Drawing.Size(132, 41);
            this.labelWynik.TabIndex = 67;
            this.labelWynik.Text = "Wynik: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1256, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 41);
            this.label7.TabIndex = 66;
            this.label7.Text = "t - Czas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1246, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 41);
            this.label6.TabIndex = 65;
            this.label6.Text = "s - Droga";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1223, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 41);
            this.label5.TabIndex = 64;
            this.label5.Text = "V - Prędkość";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1248, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 41);
            this.label4.TabIndex = 63;
            this.label4.Text = "s = V * t";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1266, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 41);
            this.label3.TabIndex = 62;
            this.label3.Text = "Wzór:";
            // 
            // textBoxCzas
            // 
            this.textBoxCzas.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxCzas.Location = new System.Drawing.Point(289, 90);
            this.textBoxCzas.Name = "textBoxCzas";
            this.textBoxCzas.Size = new System.Drawing.Size(152, 49);
            this.textBoxCzas.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 41);
            this.label2.TabIndex = 60;
            this.label2.Text = "Podaj t (s):";
            // 
            // textBoxPredkosc
            // 
            this.textBoxPredkosc.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPredkosc.Location = new System.Drawing.Point(289, 25);
            this.textBoxPredkosc.Name = "textBoxPredkosc";
            this.textBoxPredkosc.Size = new System.Drawing.Size(152, 49);
            this.textBoxPredkosc.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 41);
            this.label1.TabIndex = 58;
            this.label1.Text = "Podaj V (m/s):";
            // 
            // buttonZamknij
            // 
            this.buttonZamknij.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonZamknij.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonZamknij.FlatAppearance.BorderSize = 5;
            this.buttonZamknij.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZamknij.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZamknij.ForeColor = System.Drawing.Color.White;
            this.buttonZamknij.Location = new System.Drawing.Point(1143, 766);
            this.buttonZamknij.Name = "buttonZamknij";
            this.buttonZamknij.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonZamknij.Size = new System.Drawing.Size(325, 75);
            this.buttonZamknij.TabIndex = 68;
            this.buttonZamknij.Text = "Zamknij";
            this.buttonZamknij.UseVisualStyleBackColor = false;
            this.buttonZamknij.Click += new System.EventHandler(this.buttonZamknij_Click);
            // 
            // buttonOblicz
            // 
            this.buttonOblicz.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonOblicz.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonOblicz.FlatAppearance.BorderSize = 5;
            this.buttonOblicz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOblicz.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOblicz.ForeColor = System.Drawing.Color.White;
            this.buttonOblicz.Location = new System.Drawing.Point(781, 766);
            this.buttonOblicz.Name = "buttonOblicz";
            this.buttonOblicz.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonOblicz.Size = new System.Drawing.Size(325, 75);
            this.buttonOblicz.TabIndex = 69;
            this.buttonOblicz.Text = "Oblicz";
            this.buttonOblicz.UseVisualStyleBackColor = false;
            this.buttonOblicz.Click += new System.EventHandler(this.buttonOblicz_Click);
            // 
            // buttonWyczysc
            // 
            this.buttonWyczysc.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonWyczysc.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonWyczysc.FlatAppearance.BorderSize = 5;
            this.buttonWyczysc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWyczysc.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWyczysc.ForeColor = System.Drawing.Color.White;
            this.buttonWyczysc.Location = new System.Drawing.Point(419, 766);
            this.buttonWyczysc.Name = "buttonWyczysc";
            this.buttonWyczysc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonWyczysc.Size = new System.Drawing.Size(325, 75);
            this.buttonWyczysc.TabIndex = 70;
            this.buttonWyczysc.Text = "Wyczyść";
            this.buttonWyczysc.UseVisualStyleBackColor = false;
            this.buttonWyczysc.Click += new System.EventHandler(this.buttonWyczysc_Click_1);
            // 
            // FormJPDroga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Szablon_Aplikacji.Properties.Resources.tlo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1482, 853);
            this.Controls.Add(this.buttonWyczysc);
            this.Controls.Add(this.buttonOblicz);
            this.Controls.Add(this.buttonZamknij);
            this.Controls.Add(this.labelWynik);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCzas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPredkosc);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormJPDroga";
            this.Text = "JP Droga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelWynik;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCzas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPredkosc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonZamknij;
        private System.Windows.Forms.Button buttonOblicz;
        private System.Windows.Forms.Button buttonWyczysc;
    }
}