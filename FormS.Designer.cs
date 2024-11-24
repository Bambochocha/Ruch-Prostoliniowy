namespace Szablon_Aplikacji
{
    partial class FormS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormS));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMasa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPrzyspieszenie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelWynik = new System.Windows.Forms.Label();
            this.buttonZamknij = new System.Windows.Forms.Button();
            this.buttonOblicz = new System.Windows.Forms.Button();
            this.buttonWyczysc = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj m (kg):";
            // 
            // textBoxMasa
            // 
            this.textBoxMasa.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxMasa.Location = new System.Drawing.Point(288, 38);
            this.textBoxMasa.Name = "textBoxMasa";
            this.textBoxMasa.Size = new System.Drawing.Size(152, 49);
            this.textBoxMasa.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "Podaj a (m/s2):";
            // 
            // textBoxPrzyspieszenie
            // 
            this.textBoxPrzyspieszenie.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPrzyspieszenie.Location = new System.Drawing.Point(306, 103);
            this.textBoxPrzyspieszenie.Name = "textBoxPrzyspieszenie";
            this.textBoxPrzyspieszenie.Size = new System.Drawing.Size(152, 49);
            this.textBoxPrzyspieszenie.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(905, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 41);
            this.label3.TabIndex = 4;
            this.label3.Text = "Wzór:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(877, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 41);
            this.label4.TabIndex = 5;
            this.label4.Text = "F = m * a";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(887, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 41);
            this.label5.TabIndex = 6;
            this.label5.Text = "F - Siła";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(877, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 41);
            this.label6.TabIndex = 7;
            this.label6.Text = "m - Masa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(816, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(287, 41);
            this.label7.TabIndex = 8;
            this.label7.Text = "a - Przyśpieszenie";
            // 
            // labelWynik
            // 
            this.labelWynik.AutoSize = true;
            this.labelWynik.BackColor = System.Drawing.Color.Transparent;
            this.labelWynik.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWynik.ForeColor = System.Drawing.Color.White;
            this.labelWynik.Location = new System.Drawing.Point(31, 185);
            this.labelWynik.Name = "labelWynik";
            this.labelWynik.Size = new System.Drawing.Size(132, 41);
            this.labelWynik.TabIndex = 9;
            this.labelWynik.Text = "Wynik: ";
            // 
            // buttonZamknij
            // 
            this.buttonZamknij.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonZamknij.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonZamknij.FlatAppearance.BorderSize = 5;
            this.buttonZamknij.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZamknij.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZamknij.ForeColor = System.Drawing.Color.White;
            this.buttonZamknij.Location = new System.Drawing.Point(940, 581);
            this.buttonZamknij.Name = "buttonZamknij";
            this.buttonZamknij.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonZamknij.Size = new System.Drawing.Size(220, 60);
            this.buttonZamknij.TabIndex = 10;
            this.buttonZamknij.Text = "Zamknij";
            this.buttonZamknij.UseVisualStyleBackColor = false;
            this.buttonZamknij.Click += new System.EventHandler(this.buttonMatematyka_Click);
            // 
            // buttonOblicz
            // 
            this.buttonOblicz.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonOblicz.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonOblicz.FlatAppearance.BorderSize = 5;
            this.buttonOblicz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOblicz.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOblicz.ForeColor = System.Drawing.Color.White;
            this.buttonOblicz.Location = new System.Drawing.Point(685, 581);
            this.buttonOblicz.Name = "buttonOblicz";
            this.buttonOblicz.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonOblicz.Size = new System.Drawing.Size(220, 60);
            this.buttonOblicz.TabIndex = 11;
            this.buttonOblicz.Text = "Oblicz";
            this.buttonOblicz.UseVisualStyleBackColor = false;
            this.buttonOblicz.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonWyczysc
            // 
            this.buttonWyczysc.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonWyczysc.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonWyczysc.FlatAppearance.BorderSize = 5;
            this.buttonWyczysc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWyczysc.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWyczysc.ForeColor = System.Drawing.Color.White;
            this.buttonWyczysc.Location = new System.Drawing.Point(430, 581);
            this.buttonWyczysc.Name = "buttonWyczysc";
            this.buttonWyczysc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonWyczysc.Size = new System.Drawing.Size(220, 60);
            this.buttonWyczysc.TabIndex = 12;
            this.buttonWyczysc.Text = "Wyczyść";
            this.buttonWyczysc.UseVisualStyleBackColor = false;
            this.buttonWyczysc.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(610, 544);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(550, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Aby obliczyć siłę ciężkości, w polu przyśpieszenie wpisz 9,81";
            // 
            // FormS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Szablon_Aplikacji.Properties.Resources.tlo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonWyczysc);
            this.Controls.Add(this.buttonOblicz);
            this.Controls.Add(this.buttonZamknij);
            this.Controls.Add(this.labelWynik);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPrzyspieszenie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMasa);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormS";
            this.Text = "Siła";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMasa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPrzyspieszenie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelWynik;
        private System.Windows.Forms.Button buttonZamknij;
        private System.Windows.Forms.Button buttonOblicz;
        private System.Windows.Forms.Button buttonWyczysc;
        private System.Windows.Forms.Label label8;
    }
}