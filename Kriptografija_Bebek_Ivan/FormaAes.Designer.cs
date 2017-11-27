namespace Kriptografija_Bebek_Ivan
{
    partial class FormAes
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
            this.groupBoxZaOriginal = new System.Windows.Forms.GroupBox();
            this.originalTekstDatoteke = new System.Windows.Forms.TextBox();
            this.buttonZaUcitatOriginal = new System.Windows.Forms.Button();
            this.buttonSpremiNoviUneseni = new System.Windows.Forms.Button();
            this.ocistiOriginalniTekst = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tekstZaAesKljuc = new System.Windows.Forms.TextBox();
            this.ucitajTajniKljuc = new System.Windows.Forms.Button();
            this.spremiTajniKljuc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kriptiraniTekstDatoteke = new System.Windows.Forms.TextBox();
            this.ocistiKriptiraniTekst = new System.Windows.Forms.Button();
            this.spremiKriptiraniTekst = new System.Windows.Forms.Button();
            this.ucitajKriptiraniTekst = new System.Windows.Forms.Button();
            this.kriptiranjeAes = new System.Windows.Forms.Button();
            this.dekriptiranjeAes = new System.Windows.Forms.Button();
            this.ocistiTajniKljuc = new System.Windows.Forms.Button();
            this.provjeriSazetak = new System.Windows.Forms.Button();
            this.ucitajSazetak = new System.Windows.Forms.Button();
            this.tekstZaSazetak = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kreirajSazetak = new System.Windows.Forms.Button();
            this.ocistiSazetak = new System.Windows.Forms.Button();
            this.groupBoxZaOriginal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxZaOriginal
            // 
            this.groupBoxZaOriginal.Controls.Add(this.originalTekstDatoteke);
            this.groupBoxZaOriginal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxZaOriginal.Location = new System.Drawing.Point(16, 21);
            this.groupBoxZaOriginal.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxZaOriginal.Name = "groupBoxZaOriginal";
            this.groupBoxZaOriginal.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxZaOriginal.Size = new System.Drawing.Size(778, 832);
            this.groupBoxZaOriginal.TabIndex = 0;
            this.groupBoxZaOriginal.TabStop = false;
            this.groupBoxZaOriginal.Text = "Originalni tekst datoteke";
            // 
            // originalTekstDatoteke
            // 
            this.originalTekstDatoteke.Location = new System.Drawing.Point(4, 17);
            this.originalTekstDatoteke.Margin = new System.Windows.Forms.Padding(2);
            this.originalTekstDatoteke.Multiline = true;
            this.originalTekstDatoteke.Name = "originalTekstDatoteke";
            this.originalTekstDatoteke.Size = new System.Drawing.Size(770, 811);
            this.originalTekstDatoteke.TabIndex = 0;
            // 
            // buttonZaUcitatOriginal
            // 
            this.buttonZaUcitatOriginal.Location = new System.Drawing.Point(16, 873);
            this.buttonZaUcitatOriginal.Margin = new System.Windows.Forms.Padding(2);
            this.buttonZaUcitatOriginal.Name = "buttonZaUcitatOriginal";
            this.buttonZaUcitatOriginal.Size = new System.Drawing.Size(154, 37);
            this.buttonZaUcitatOriginal.TabIndex = 1;
            this.buttonZaUcitatOriginal.Text = "Učitaj datoteku";
            this.buttonZaUcitatOriginal.UseVisualStyleBackColor = true;
            this.buttonZaUcitatOriginal.Click += new System.EventHandler(this.buttonZaUcitatOriginal_Click);
            // 
            // buttonSpremiNoviUneseni
            // 
            this.buttonSpremiNoviUneseni.Location = new System.Drawing.Point(179, 873);
            this.buttonSpremiNoviUneseni.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSpremiNoviUneseni.Name = "buttonSpremiNoviUneseni";
            this.buttonSpremiNoviUneseni.Size = new System.Drawing.Size(154, 37);
            this.buttonSpremiNoviUneseni.TabIndex = 2;
            this.buttonSpremiNoviUneseni.Text = "Spremi u datoteku";
            this.buttonSpremiNoviUneseni.UseVisualStyleBackColor = true;
            this.buttonSpremiNoviUneseni.Click += new System.EventHandler(this.buttonSpremiNoviUneseni_Click);
            // 
            // ocistiOriginalniTekst
            // 
            this.ocistiOriginalniTekst.Location = new System.Drawing.Point(640, 873);
            this.ocistiOriginalniTekst.Margin = new System.Windows.Forms.Padding(2);
            this.ocistiOriginalniTekst.Name = "ocistiOriginalniTekst";
            this.ocistiOriginalniTekst.Size = new System.Drawing.Size(154, 37);
            this.ocistiOriginalniTekst.TabIndex = 3;
            this.ocistiOriginalniTekst.Text = "Očisti prozor";
            this.ocistiOriginalniTekst.UseVisualStyleBackColor = true;
            this.ocistiOriginalniTekst.Click += new System.EventHandler(this.ocistiOriginalniTekst_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(14, 945);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tajni ključ AES:";
            // 
            // tekstZaAesKljuc
            // 
            this.tekstZaAesKljuc.Enabled = false;
            this.tekstZaAesKljuc.Location = new System.Drawing.Point(101, 942);
            this.tekstZaAesKljuc.Margin = new System.Windows.Forms.Padding(2);
            this.tekstZaAesKljuc.Name = "tekstZaAesKljuc";
            this.tekstZaAesKljuc.Size = new System.Drawing.Size(390, 20);
            this.tekstZaAesKljuc.TabIndex = 5;
            // 
            // ucitajTajniKljuc
            // 
            this.ucitajTajniKljuc.Location = new System.Drawing.Point(495, 937);
            this.ucitajTajniKljuc.Margin = new System.Windows.Forms.Padding(2);
            this.ucitajTajniKljuc.Name = "ucitajTajniKljuc";
            this.ucitajTajniKljuc.Size = new System.Drawing.Size(140, 29);
            this.ucitajTajniKljuc.TabIndex = 6;
            this.ucitajTajniKljuc.Text = "Učitaj tajni ključ";
            this.ucitajTajniKljuc.UseVisualStyleBackColor = true;
            this.ucitajTajniKljuc.Click += new System.EventHandler(this.ucitajTajniKljuc_Click);
            // 
            // spremiTajniKljuc
            // 
            this.spremiTajniKljuc.Location = new System.Drawing.Point(640, 937);
            this.spremiTajniKljuc.Margin = new System.Windows.Forms.Padding(2);
            this.spremiTajniKljuc.Name = "spremiTajniKljuc";
            this.spremiTajniKljuc.Size = new System.Drawing.Size(154, 29);
            this.spremiTajniKljuc.TabIndex = 7;
            this.spremiTajniKljuc.Text = "Kreiraj tajni ključ";
            this.spremiTajniKljuc.UseVisualStyleBackColor = true;
            this.spremiTajniKljuc.Click += new System.EventHandler(this.spremiTajniKljuc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kriptiraniTekstDatoteke);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(1094, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(778, 832);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kriptirani tekst datoteke";
            // 
            // kriptiraniTekstDatoteke
            // 
            this.kriptiraniTekstDatoteke.Location = new System.Drawing.Point(4, 17);
            this.kriptiraniTekstDatoteke.Margin = new System.Windows.Forms.Padding(2);
            this.kriptiraniTekstDatoteke.Multiline = true;
            this.kriptiraniTekstDatoteke.Name = "kriptiraniTekstDatoteke";
            this.kriptiraniTekstDatoteke.Size = new System.Drawing.Size(770, 811);
            this.kriptiraniTekstDatoteke.TabIndex = 0;
            // 
            // ocistiKriptiraniTekst
            // 
            this.ocistiKriptiraniTekst.Location = new System.Drawing.Point(1718, 857);
            this.ocistiKriptiraniTekst.Margin = new System.Windows.Forms.Padding(2);
            this.ocistiKriptiraniTekst.Name = "ocistiKriptiraniTekst";
            this.ocistiKriptiraniTekst.Size = new System.Drawing.Size(154, 37);
            this.ocistiKriptiraniTekst.TabIndex = 11;
            this.ocistiKriptiraniTekst.Text = "Očisti prozor";
            this.ocistiKriptiraniTekst.UseVisualStyleBackColor = true;
            this.ocistiKriptiraniTekst.Click += new System.EventHandler(this.ocistiKriptiraniTekst_Click);
            // 
            // spremiKriptiraniTekst
            // 
            this.spremiKriptiraniTekst.Location = new System.Drawing.Point(1257, 857);
            this.spremiKriptiraniTekst.Margin = new System.Windows.Forms.Padding(2);
            this.spremiKriptiraniTekst.Name = "spremiKriptiraniTekst";
            this.spremiKriptiraniTekst.Size = new System.Drawing.Size(154, 37);
            this.spremiKriptiraniTekst.TabIndex = 10;
            this.spremiKriptiraniTekst.Text = "Spremi kriptirani tekst";
            this.spremiKriptiraniTekst.UseVisualStyleBackColor = true;
            this.spremiKriptiraniTekst.Click += new System.EventHandler(this.spremiKriptiraniTekst_Click);
            // 
            // ucitajKriptiraniTekst
            // 
            this.ucitajKriptiraniTekst.Location = new System.Drawing.Point(1094, 857);
            this.ucitajKriptiraniTekst.Margin = new System.Windows.Forms.Padding(2);
            this.ucitajKriptiraniTekst.Name = "ucitajKriptiraniTekst";
            this.ucitajKriptiraniTekst.Size = new System.Drawing.Size(154, 37);
            this.ucitajKriptiraniTekst.TabIndex = 9;
            this.ucitajKriptiraniTekst.Text = "Učitaj kriptirani tekst";
            this.ucitajKriptiraniTekst.UseVisualStyleBackColor = true;
            this.ucitajKriptiraniTekst.Click += new System.EventHandler(this.ucitajKriptiraniTekst_Click);
            // 
            // kriptiranjeAes
            // 
            this.kriptiranjeAes.Location = new System.Drawing.Point(799, 348);
            this.kriptiranjeAes.Margin = new System.Windows.Forms.Padding(2);
            this.kriptiranjeAes.Name = "kriptiranjeAes";
            this.kriptiranjeAes.Size = new System.Drawing.Size(291, 63);
            this.kriptiranjeAes.TabIndex = 12;
            this.kriptiranjeAes.Text = "Kriptiraj tekst";
            this.kriptiranjeAes.UseVisualStyleBackColor = true;
            this.kriptiranjeAes.Click += new System.EventHandler(this.kriptiranjeAes_Click);
            // 
            // dekriptiranjeAes
            // 
            this.dekriptiranjeAes.Location = new System.Drawing.Point(799, 415);
            this.dekriptiranjeAes.Margin = new System.Windows.Forms.Padding(2);
            this.dekriptiranjeAes.Name = "dekriptiranjeAes";
            this.dekriptiranjeAes.Size = new System.Drawing.Size(291, 63);
            this.dekriptiranjeAes.TabIndex = 13;
            this.dekriptiranjeAes.Text = "Dekriptiraj tekst";
            this.dekriptiranjeAes.UseVisualStyleBackColor = true;
            this.dekriptiranjeAes.Click += new System.EventHandler(this.dekriptiranjeAes_Click);
            // 
            // ocistiTajniKljuc
            // 
            this.ocistiTajniKljuc.Location = new System.Drawing.Point(482, 873);
            this.ocistiTajniKljuc.Margin = new System.Windows.Forms.Padding(2);
            this.ocistiTajniKljuc.Name = "ocistiTajniKljuc";
            this.ocistiTajniKljuc.Size = new System.Drawing.Size(154, 37);
            this.ocistiTajniKljuc.TabIndex = 14;
            this.ocistiTajniKljuc.Text = "Očisti tajni ključ";
            this.ocistiTajniKljuc.UseVisualStyleBackColor = true;
            this.ocistiTajniKljuc.Click += new System.EventHandler(this.ocistiTajniKljuc_Click);
            // 
            // provjeriSazetak
            // 
            this.provjeriSazetak.Location = new System.Drawing.Point(1759, 904);
            this.provjeriSazetak.Margin = new System.Windows.Forms.Padding(2);
            this.provjeriSazetak.Name = "provjeriSazetak";
            this.provjeriSazetak.Size = new System.Drawing.Size(113, 29);
            this.provjeriSazetak.TabIndex = 18;
            this.provjeriSazetak.Text = "Provjeri sažetak";
            this.provjeriSazetak.UseVisualStyleBackColor = true;
            this.provjeriSazetak.Click += new System.EventHandler(this.provjeriSazetak_Click);
            // 
            // ucitajSazetak
            // 
            this.ucitajSazetak.Location = new System.Drawing.Point(1642, 904);
            this.ucitajSazetak.Margin = new System.Windows.Forms.Padding(2);
            this.ucitajSazetak.Name = "ucitajSazetak";
            this.ucitajSazetak.Size = new System.Drawing.Size(113, 29);
            this.ucitajSazetak.TabIndex = 17;
            this.ucitajSazetak.Text = "Učitaj sažetak";
            this.ucitajSazetak.UseVisualStyleBackColor = true;
            this.ucitajSazetak.Click += new System.EventHandler(this.ucitajSazetak_Click);
            // 
            // tekstZaSazetak
            // 
            this.tekstZaSazetak.Enabled = false;
            this.tekstZaSazetak.Location = new System.Drawing.Point(1144, 908);
            this.tekstZaSazetak.Margin = new System.Windows.Forms.Padding(2);
            this.tekstZaSazetak.Name = "tekstZaSazetak";
            this.tekstZaSazetak.Size = new System.Drawing.Size(494, 20);
            this.tekstZaSazetak.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(1091, 911);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Sažetak:";
            // 
            // kreirajSazetak
            // 
            this.kreirajSazetak.Location = new System.Drawing.Point(799, 482);
            this.kreirajSazetak.Margin = new System.Windows.Forms.Padding(2);
            this.kreirajSazetak.Name = "kreirajSazetak";
            this.kreirajSazetak.Size = new System.Drawing.Size(291, 63);
            this.kreirajSazetak.TabIndex = 19;
            this.kreirajSazetak.Text = "Kreiraj sažetak";
            this.kreirajSazetak.UseVisualStyleBackColor = true;
            this.kreirajSazetak.Click += new System.EventHandler(this.kreirajSazetak_Click);
            // 
            // ocistiSazetak
            // 
            this.ocistiSazetak.Location = new System.Drawing.Point(1560, 857);
            this.ocistiSazetak.Margin = new System.Windows.Forms.Padding(2);
            this.ocistiSazetak.Name = "ocistiSazetak";
            this.ocistiSazetak.Size = new System.Drawing.Size(154, 37);
            this.ocistiSazetak.TabIndex = 20;
            this.ocistiSazetak.Text = "Očisti sažetak";
            this.ocistiSazetak.UseVisualStyleBackColor = true;
            this.ocistiSazetak.Click += new System.EventHandler(this.ocistiSazetak_Click);
            // 
            // FormAes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1972, 982);
            this.Controls.Add(this.ocistiSazetak);
            this.Controls.Add(this.kreirajSazetak);
            this.Controls.Add(this.provjeriSazetak);
            this.Controls.Add(this.ucitajSazetak);
            this.Controls.Add(this.tekstZaSazetak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ocistiTajniKljuc);
            this.Controls.Add(this.dekriptiranjeAes);
            this.Controls.Add(this.kriptiranjeAes);
            this.Controls.Add(this.ocistiKriptiraniTekst);
            this.Controls.Add(this.spremiKriptiraniTekst);
            this.Controls.Add(this.ucitajKriptiraniTekst);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.spremiTajniKljuc);
            this.Controls.Add(this.ucitajTajniKljuc);
            this.Controls.Add(this.tekstZaAesKljuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ocistiOriginalniTekst);
            this.Controls.Add(this.buttonSpremiNoviUneseni);
            this.Controls.Add(this.buttonZaUcitatOriginal);
            this.Controls.Add(this.groupBoxZaOriginal);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAes";
            this.Text = "AES";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormAes_Load);
            this.groupBoxZaOriginal.ResumeLayout(false);
            this.groupBoxZaOriginal.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxZaOriginal;
        private System.Windows.Forms.TextBox originalTekstDatoteke;
        private System.Windows.Forms.Button buttonZaUcitatOriginal;
        private System.Windows.Forms.Button buttonSpremiNoviUneseni;
        private System.Windows.Forms.Button ocistiOriginalniTekst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tekstZaAesKljuc;
        private System.Windows.Forms.Button ucitajTajniKljuc;
        private System.Windows.Forms.Button spremiTajniKljuc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox kriptiraniTekstDatoteke;
        private System.Windows.Forms.Button ocistiKriptiraniTekst;
        private System.Windows.Forms.Button spremiKriptiraniTekst;
        private System.Windows.Forms.Button ucitajKriptiraniTekst;
        private System.Windows.Forms.Button kriptiranjeAes;
        private System.Windows.Forms.Button dekriptiranjeAes;
        private System.Windows.Forms.Button ocistiTajniKljuc;
        private System.Windows.Forms.Button provjeriSazetak;
        private System.Windows.Forms.Button ucitajSazetak;
        private System.Windows.Forms.TextBox tekstZaSazetak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button kreirajSazetak;
        private System.Windows.Forms.Button ocistiSazetak;
    }
}