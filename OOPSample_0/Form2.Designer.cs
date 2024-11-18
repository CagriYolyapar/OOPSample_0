namespace OOPSample_0
{
    partial class Form2
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
            this.LstFilmler = new System.Windows.Forms.ListBox();
            this.LstYonetmenler = new System.Windows.Forms.ListBox();
            this.BtnYonetmenEkle = new System.Windows.Forms.Button();
            this.BtnFilmEkle = new System.Windows.Forms.Button();
            this.TxtIsim = new System.Windows.Forms.TextBox();
            this.TxtSoyIsim = new System.Windows.Forms.TextBox();
            this.lblYonetmen = new System.Windows.Forms.Label();
            this.LblFilm = new System.Windows.Forms.Label();
            this.TxtFilm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LstFilmler
            // 
            this.LstFilmler.FormattingEnabled = true;
            this.LstFilmler.ItemHeight = 16;
            this.LstFilmler.Location = new System.Drawing.Point(616, 26);
            this.LstFilmler.Name = "LstFilmler";
            this.LstFilmler.Size = new System.Drawing.Size(302, 436);
            this.LstFilmler.TabIndex = 0;
            // 
            // LstYonetmenler
            // 
            this.LstYonetmenler.FormattingEnabled = true;
            this.LstYonetmenler.ItemHeight = 16;
            this.LstYonetmenler.Location = new System.Drawing.Point(177, 26);
            this.LstYonetmenler.Name = "LstYonetmenler";
            this.LstYonetmenler.Size = new System.Drawing.Size(302, 436);
            this.LstYonetmenler.TabIndex = 0;
            // 
            // BtnYonetmenEkle
            // 
            this.BtnYonetmenEkle.Location = new System.Drawing.Point(177, 487);
            this.BtnYonetmenEkle.Name = "BtnYonetmenEkle";
            this.BtnYonetmenEkle.Size = new System.Drawing.Size(119, 23);
            this.BtnYonetmenEkle.TabIndex = 1;
            this.BtnYonetmenEkle.Text = "Yonetmen Ekle";
            this.BtnYonetmenEkle.UseVisualStyleBackColor = true;
            // 
            // BtnFilmEkle
            // 
            this.BtnFilmEkle.Location = new System.Drawing.Point(642, 487);
            this.BtnFilmEkle.Name = "BtnFilmEkle";
            this.BtnFilmEkle.Size = new System.Drawing.Size(169, 27);
            this.BtnFilmEkle.TabIndex = 2;
            this.BtnFilmEkle.Text = "Film Ekle";
            this.BtnFilmEkle.UseVisualStyleBackColor = true;
            // 
            // TxtIsim
            // 
            this.TxtIsim.Location = new System.Drawing.Point(13, 64);
            this.TxtIsim.Name = "TxtIsim";
            this.TxtIsim.Size = new System.Drawing.Size(100, 22);
            this.TxtIsim.TabIndex = 3;
            // 
            // TxtSoyIsim
            // 
            this.TxtSoyIsim.Location = new System.Drawing.Point(13, 120);
            this.TxtSoyIsim.Name = "TxtSoyIsim";
            this.TxtSoyIsim.Size = new System.Drawing.Size(100, 22);
            this.TxtSoyIsim.TabIndex = 3;
            // 
            // lblYonetmen
            // 
            this.lblYonetmen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblYonetmen.Location = new System.Drawing.Point(10, 203);
            this.lblYonetmen.Name = "lblYonetmen";
            this.lblYonetmen.Size = new System.Drawing.Size(126, 69);
            this.lblYonetmen.TabIndex = 4;
            // 
            // LblFilm
            // 
            this.LblFilm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblFilm.Location = new System.Drawing.Point(924, 212);
            this.LblFilm.Name = "LblFilm";
            this.LblFilm.Size = new System.Drawing.Size(126, 60);
            this.LblFilm.TabIndex = 4;
            // 
            // TxtFilm
            // 
            this.TxtFilm.Location = new System.Drawing.Point(927, 77);
            this.TxtFilm.Name = "TxtFilm";
            this.TxtFilm.Size = new System.Drawing.Size(100, 22);
            this.TxtFilm.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 578);
            this.Controls.Add(this.LblFilm);
            this.Controls.Add(this.lblYonetmen);
            this.Controls.Add(this.TxtSoyIsim);
            this.Controls.Add(this.TxtFilm);
            this.Controls.Add(this.TxtIsim);
            this.Controls.Add(this.BtnFilmEkle);
            this.Controls.Add(this.BtnYonetmenEkle);
            this.Controls.Add(this.LstYonetmenler);
            this.Controls.Add(this.LstFilmler);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstFilmler;
        private System.Windows.Forms.ListBox LstYonetmenler;
        private System.Windows.Forms.Button BtnYonetmenEkle;
        private System.Windows.Forms.Button BtnFilmEkle;
        private System.Windows.Forms.TextBox TxtIsim;
        private System.Windows.Forms.TextBox TxtSoyIsim;
        private System.Windows.Forms.Label lblYonetmen;
        private System.Windows.Forms.Label LblFilm;
        private System.Windows.Forms.TextBox TxtFilm;
    }
}