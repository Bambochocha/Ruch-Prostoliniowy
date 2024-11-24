namespace Szablon_Aplikacji
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonSila = new System.Windows.Forms.Button();
            this.buttonJednostajnyProstoliniowy = new System.Windows.Forms.Button();
            this.buttonJednostajnieZmienny = new System.Windows.Forms.Button();
            this.buttonPrzyspieszenie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonZamknij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSila
            // 
            this.buttonSila.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSila.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSila.FlatAppearance.BorderSize = 5;
            this.buttonSila.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSila.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSila.ForeColor = System.Drawing.Color.White;
            this.buttonSila.Location = new System.Drawing.Point(300, 253);
            this.buttonSila.Name = "buttonSila";
            this.buttonSila.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonSila.Size = new System.Drawing.Size(295, 60);
            this.buttonSila.TabIndex = 0;
            this.buttonSila.Text = "Siła";
            this.buttonSila.UseVisualStyleBackColor = false;
            this.buttonSila.Click += new System.EventHandler(this.buttonMatematyka_Click);
            // 
            // buttonJednostajnyProstoliniowy
            // 
            this.buttonJednostajnyProstoliniowy.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonJednostajnyProstoliniowy.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonJednostajnyProstoliniowy.FlatAppearance.BorderSize = 5;
            this.buttonJednostajnyProstoliniowy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonJednostajnyProstoliniowy.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonJednostajnyProstoliniowy.ForeColor = System.Drawing.Color.White;
            this.buttonJednostajnyProstoliniowy.Location = new System.Drawing.Point(300, 319);
            this.buttonJednostajnyProstoliniowy.Name = "buttonJednostajnyProstoliniowy";
            this.buttonJednostajnyProstoliniowy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonJednostajnyProstoliniowy.Size = new System.Drawing.Size(600, 60);
            this.buttonJednostajnyProstoliniowy.TabIndex = 1;
            this.buttonJednostajnyProstoliniowy.Text = "Ruch Jednostajny Prostoliniowy";
            this.buttonJednostajnyProstoliniowy.UseVisualStyleBackColor = false;
            this.buttonJednostajnyProstoliniowy.Click += new System.EventHandler(this.buttonFizyka_Click);
            // 
            // buttonJednostajnieZmienny
            // 
            this.buttonJednostajnieZmienny.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonJednostajnieZmienny.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonJednostajnieZmienny.FlatAppearance.BorderSize = 5;
            this.buttonJednostajnieZmienny.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonJednostajnieZmienny.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonJednostajnieZmienny.ForeColor = System.Drawing.Color.White;
            this.buttonJednostajnieZmienny.Location = new System.Drawing.Point(299, 385);
            this.buttonJednostajnieZmienny.Name = "buttonJednostajnieZmienny";
            this.buttonJednostajnieZmienny.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonJednostajnieZmienny.Size = new System.Drawing.Size(600, 60);
            this.buttonJednostajnieZmienny.TabIndex = 2;
            this.buttonJednostajnieZmienny.Text = "Ruch Jednostajnie zmienny";
            this.buttonJednostajnieZmienny.UseVisualStyleBackColor = false;
            this.buttonJednostajnieZmienny.Click += new System.EventHandler(this.buttonPolski_Click);
            // 
            // buttonPrzyspieszenie
            // 
            this.buttonPrzyspieszenie.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonPrzyspieszenie.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonPrzyspieszenie.FlatAppearance.BorderSize = 5;
            this.buttonPrzyspieszenie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrzyspieszenie.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPrzyspieszenie.ForeColor = System.Drawing.Color.White;
            this.buttonPrzyspieszenie.Location = new System.Drawing.Point(605, 253);
            this.buttonPrzyspieszenie.Name = "buttonPrzyspieszenie";
            this.buttonPrzyspieszenie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonPrzyspieszenie.Size = new System.Drawing.Size(295, 60);
            this.buttonPrzyspieszenie.TabIndex = 4;
            this.buttonPrzyspieszenie.Text = "Przyśpieszenie";
            this.buttonPrzyspieszenie.UseVisualStyleBackColor = false;
            this.buttonPrzyspieszenie.Click += new System.EventHandler(this.buttonPomoc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(403, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 60);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ruch Prostolinowy";
            // 
            // buttonZamknij
            // 
            this.buttonZamknij.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonZamknij.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonZamknij.FlatAppearance.BorderSize = 5;
            this.buttonZamknij.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZamknij.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZamknij.ForeColor = System.Drawing.Color.White;
            this.buttonZamknij.Location = new System.Drawing.Point(299, 451);
            this.buttonZamknij.Name = "buttonZamknij";
            this.buttonZamknij.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonZamknij.Size = new System.Drawing.Size(600, 60);
            this.buttonZamknij.TabIndex = 8;
            this.buttonZamknij.Text = "Zamknij";
            this.buttonZamknij.UseVisualStyleBackColor = false;
            this.buttonZamknij.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Szablon_Aplikacji.Properties.Resources.tlo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.buttonZamknij);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPrzyspieszenie);
            this.Controls.Add(this.buttonJednostajnieZmienny);
            this.Controls.Add(this.buttonJednostajnyProstoliniowy);
            this.Controls.Add(this.buttonSila);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Aplikacja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSila;
        private System.Windows.Forms.Button buttonJednostajnyProstoliniowy;
        private System.Windows.Forms.Button buttonJednostajnieZmienny;
        private System.Windows.Forms.Button buttonPrzyspieszenie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonZamknij;
    }
}

