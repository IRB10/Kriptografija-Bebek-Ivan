namespace Kriptografija_Bebek_Ivan
{
    partial class FormaRSA
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.originalTekstRsa = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kriptiraniTekstRsa = new System.Windows.Forms.TextBox();
            this.dekriptiranjeRsa = new System.Windows.Forms.Button();
            this.kriptiranjeRsa = new System.Windows.Forms.Button();
            this.ucitajDatotekuRsa = new System.Windows.Forms.Button();
            this.spremiDatotekuRsa = new System.Windows.Forms.Button();
            this.ocistiOriginalTekst = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tekstJavniKljuc = new System.Windows.Forms.TextBox();
            this.tekstPrivatniKljuc = new System.Windows.Forms.TextBox();
            this.ucitajJavniKljuc = new System.Windows.Forms.Button();
            this.ucitajPrivatniKljuc = new System.Windows.Forms.Button();
            this.ocistiKriptiraniTekst = new System.Windows.Forms.Button();
            this.spremiKriptiraniTekst = new System.Windows.Forms.Button();
            this.ucitajKriptiraniTekst = new System.Windows.Forms.Button();
            this.kreirajParKljuceva = new System.Windows.Forms.Button();
            this.ocistiJavniKljuc = new System.Windows.Forms.Button();
            this.ocistiPrivatniKljuc = new System.Windows.Forms.Button();
            this.ucitajSazetak = new System.Windows.Forms.Button();
            this.tekstZaSazetak = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.provjeriSazetak = new System.Windows.Forms.Button();
            this.kreirajSazetak = new System.Windows.Forms.Button();
            this.ocistiSazetak = new System.Windows.Forms.Button();
            this.kreirajPotpis = new System.Windows.Forms.Button();
            this.provjeriDigitalniPotpis = new System.Windows.Forms.Button();
            this.ucitajPotpis = new System.Windows.Forms.Button();
            this.tekstZaDigitalniPotpis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ocistiPotpis = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.originalTekstRsa);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(16, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 832);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Originalni tekst datoteke";
            // 
            // originalTekstRsa
            // 
            this.originalTekstRsa.Location = new System.Drawing.Point(6, 19);
            this.originalTekstRsa.Multiline = true;
            this.originalTekstRsa.Name = "originalTekstRsa";
            this.originalTekstRsa.Size = new System.Drawing.Size(766, 807);
            this.originalTekstRsa.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.groupBox2.Controls.Add(this.kriptiraniTekstRsa);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(1094, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(778, 832);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kriptirani tekst datoteke";
            // 
            // kriptiraniTekstRsa
            // 
            this.kriptiraniTekstRsa.Location = new System.Drawing.Point(6, 19);
            this.kriptiraniTekstRsa.Multiline = true;
            this.kriptiraniTekstRsa.Name = "kriptiraniTekstRsa";
            this.kriptiraniTekstRsa.Size = new System.Drawing.Size(766, 807);
            this.kriptiraniTekstRsa.TabIndex = 0;
            // 
            // dekriptiranjeRsa
            // 
            this.dekriptiranjeRsa.Location = new System.Drawing.Point(799, 415);
            this.dekriptiranjeRsa.Margin = new System.Windows.Forms.Padding(2);
            this.dekriptiranjeRsa.Name = "dekriptiranjeRsa";
            this.dekriptiranjeRsa.Size = new System.Drawing.Size(291, 63);
            this.dekriptiranjeRsa.TabIndex = 15;
            this.dekriptiranjeRsa.Text = "Dekriptiraj tekst";
            this.dekriptiranjeRsa.UseVisualStyleBackColor = true;
            this.dekriptiranjeRsa.Click += new System.EventHandler(this.dekriptiranjeRsa_Click);
            // 
            // kriptiranjeRsa
            // 
            this.kriptiranjeRsa.Location = new System.Drawing.Point(799, 348);
            this.kriptiranjeRsa.Margin = new System.Windows.Forms.Padding(2);
            this.kriptiranjeRsa.Name = "kriptiranjeRsa";
            this.kriptiranjeRsa.Size = new System.Drawing.Size(291, 63);
            this.kriptiranjeRsa.TabIndex = 14;
            this.kriptiranjeRsa.Text = "Kriptiraj tekst";
            this.kriptiranjeRsa.UseVisualStyleBackColor = true;
            this.kriptiranjeRsa.Click += new System.EventHandler(this.kriptiranjeRsa_Click);
            // 
            // ucitajDatotekuRsa
            // 
            this.ucitajDatotekuRsa.Location = new System.Drawing.Point(16, 860);
            this.ucitajDatotekuRsa.Name = "ucitajDatotekuRsa";
            this.ucitajDatotekuRsa.Size = new System.Drawing.Size(111, 27);
            this.ucitajDatotekuRsa.TabIndex = 16;
            this.ucitajDatotekuRsa.Text = "Učitaj datoteku";
            this.ucitajDatotekuRsa.UseVisualStyleBackColor = true;
            this.ucitajDatotekuRsa.Click += new System.EventHandler(this.ucitajDatotekuRsa_Click);
            // 
            // spremiDatotekuRsa
            // 
            this.spremiDatotekuRsa.Location = new System.Drawing.Point(133, 860);
            this.spremiDatotekuRsa.Name = "spremiDatotekuRsa";
            this.spremiDatotekuRsa.Size = new System.Drawing.Size(111, 27);
            this.spremiDatotekuRsa.TabIndex = 17;
            this.spremiDatotekuRsa.Text = "Spremi u datoteku";
            this.spremiDatotekuRsa.UseVisualStyleBackColor = true;
            this.spremiDatotekuRsa.Click += new System.EventHandler(this.spremiDatotekuRsa_Click);
            // 
            // ocistiOriginalTekst
            // 
            this.ocistiOriginalTekst.Location = new System.Drawing.Point(683, 860);
            this.ocistiOriginalTekst.Name = "ocistiOriginalTekst";
            this.ocistiOriginalTekst.Size = new System.Drawing.Size(111, 27);
            this.ocistiOriginalTekst.TabIndex = 18;
            this.ocistiOriginalTekst.Text = "Očisti prozor";
            this.ocistiOriginalTekst.UseVisualStyleBackColor = true;
            this.ocistiOriginalTekst.Click += new System.EventHandler(this.ocistiOriginalTekst_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 923);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Javni ključ RSA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(13, 963);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Privatni ključ RSA:";
            // 
            // tekstJavniKljuc
            // 
            this.tekstJavniKljuc.Enabled = false;
            this.tekstJavniKljuc.Location = new System.Drawing.Point(118, 920);
            this.tekstJavniKljuc.Name = "tekstJavniKljuc";
            this.tekstJavniKljuc.Size = new System.Drawing.Size(442, 20);
            this.tekstJavniKljuc.TabIndex = 21;
            // 
            // tekstPrivatniKljuc
            // 
            this.tekstPrivatniKljuc.Enabled = false;
            this.tekstPrivatniKljuc.Location = new System.Drawing.Point(118, 960);
            this.tekstPrivatniKljuc.Name = "tekstPrivatniKljuc";
            this.tekstPrivatniKljuc.Size = new System.Drawing.Size(442, 20);
            this.tekstPrivatniKljuc.TabIndex = 22;
            // 
            // ucitajJavniKljuc
            // 
            this.ucitajJavniKljuc.Location = new System.Drawing.Point(566, 918);
            this.ucitajJavniKljuc.Name = "ucitajJavniKljuc";
            this.ucitajJavniKljuc.Size = new System.Drawing.Size(111, 23);
            this.ucitajJavniKljuc.TabIndex = 23;
            this.ucitajJavniKljuc.Text = "Učitaj javni ključ";
            this.ucitajJavniKljuc.UseVisualStyleBackColor = true;
            this.ucitajJavniKljuc.Click += new System.EventHandler(this.ucitajJavniKljuc_Click);
            // 
            // ucitajPrivatniKljuc
            // 
            this.ucitajPrivatniKljuc.Location = new System.Drawing.Point(566, 958);
            this.ucitajPrivatniKljuc.Name = "ucitajPrivatniKljuc";
            this.ucitajPrivatniKljuc.Size = new System.Drawing.Size(111, 23);
            this.ucitajPrivatniKljuc.TabIndex = 25;
            this.ucitajPrivatniKljuc.Text = "Učitaj privatni ključ";
            this.ucitajPrivatniKljuc.UseVisualStyleBackColor = true;
            this.ucitajPrivatniKljuc.Click += new System.EventHandler(this.ucitajPrivatniKljuc_Click);
            // 
            // ocistiKriptiraniTekst
            // 
            this.ocistiKriptiraniTekst.Location = new System.Drawing.Point(1761, 860);
            this.ocistiKriptiraniTekst.Name = "ocistiKriptiraniTekst";
            this.ocistiKriptiraniTekst.Size = new System.Drawing.Size(111, 27);
            this.ocistiKriptiraniTekst.TabIndex = 29;
            this.ocistiKriptiraniTekst.Text = "Očisti prozor";
            this.ocistiKriptiraniTekst.UseVisualStyleBackColor = true;
            this.ocistiKriptiraniTekst.Click += new System.EventHandler(this.ocistiKriptiraniTekst_Click);
            // 
            // spremiKriptiraniTekst
            // 
            this.spremiKriptiraniTekst.Location = new System.Drawing.Point(1211, 860);
            this.spremiKriptiraniTekst.Name = "spremiKriptiraniTekst";
            this.spremiKriptiraniTekst.Size = new System.Drawing.Size(117, 27);
            this.spremiKriptiraniTekst.TabIndex = 28;
            this.spremiKriptiraniTekst.Text = "Spremi kriptirani tekst";
            this.spremiKriptiraniTekst.UseVisualStyleBackColor = true;
            this.spremiKriptiraniTekst.Click += new System.EventHandler(this.spremiKriptiraniTekst_Click);
            // 
            // ucitajKriptiraniTekst
            // 
            this.ucitajKriptiraniTekst.Location = new System.Drawing.Point(1094, 860);
            this.ucitajKriptiraniTekst.Name = "ucitajKriptiraniTekst";
            this.ucitajKriptiraniTekst.Size = new System.Drawing.Size(111, 27);
            this.ucitajKriptiraniTekst.TabIndex = 27;
            this.ucitajKriptiraniTekst.Text = "Učitaj kriptirani tekst";
            this.ucitajKriptiraniTekst.UseVisualStyleBackColor = true;
            this.ucitajKriptiraniTekst.Click += new System.EventHandler(this.ucitajKriptiraniTekst_Click);
            // 
            // kreirajParKljuceva
            // 
            this.kreirajParKljuceva.Location = new System.Drawing.Point(683, 918);
            this.kreirajParKljuceva.Name = "kreirajParKljuceva";
            this.kreirajParKljuceva.Size = new System.Drawing.Size(111, 63);
            this.kreirajParKljuceva.TabIndex = 30;
            this.kreirajParKljuceva.Text = "Generiraj par ključeva";
            this.kreirajParKljuceva.UseVisualStyleBackColor = true;
            this.kreirajParKljuceva.Click += new System.EventHandler(this.kreirajParKljuceva_Click);
            // 
            // ocistiJavniKljuc
            // 
            this.ocistiJavniKljuc.Location = new System.Drawing.Point(449, 860);
            this.ocistiJavniKljuc.Name = "ocistiJavniKljuc";
            this.ocistiJavniKljuc.Size = new System.Drawing.Size(111, 27);
            this.ocistiJavniKljuc.TabIndex = 31;
            this.ocistiJavniKljuc.Text = "Očisti javni ključ";
            this.ocistiJavniKljuc.UseVisualStyleBackColor = true;
            this.ocistiJavniKljuc.Click += new System.EventHandler(this.ocistiJavniKljuc_Click);
            // 
            // ocistiPrivatniKljuc
            // 
            this.ocistiPrivatniKljuc.Location = new System.Drawing.Point(566, 860);
            this.ocistiPrivatniKljuc.Name = "ocistiPrivatniKljuc";
            this.ocistiPrivatniKljuc.Size = new System.Drawing.Size(111, 27);
            this.ocistiPrivatniKljuc.TabIndex = 32;
            this.ocistiPrivatniKljuc.Text = "Očisti privatni ključ";
            this.ocistiPrivatniKljuc.UseVisualStyleBackColor = true;
            this.ocistiPrivatniKljuc.Click += new System.EventHandler(this.ocistiPrivatniKljuc_Click);
            // 
            // ucitajSazetak
            // 
            this.ucitajSazetak.Location = new System.Drawing.Point(1633, 918);
            this.ucitajSazetak.Name = "ucitajSazetak";
            this.ucitajSazetak.Size = new System.Drawing.Size(111, 23);
            this.ucitajSazetak.TabIndex = 35;
            this.ucitajSazetak.Text = "Učitaj sažetak";
            this.ucitajSazetak.UseVisualStyleBackColor = true;
            this.ucitajSazetak.Click += new System.EventHandler(this.ucitajSazetak_Click);
            // 
            // tekstZaSazetak
            // 
            this.tekstZaSazetak.Enabled = false;
            this.tekstZaSazetak.Location = new System.Drawing.Point(1175, 920);
            this.tekstZaSazetak.Name = "tekstZaSazetak";
            this.tekstZaSazetak.Size = new System.Drawing.Size(452, 20);
            this.tekstZaSazetak.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(1091, 923);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Sažetak:";
            // 
            // provjeriSazetak
            // 
            this.provjeriSazetak.Location = new System.Drawing.Point(1750, 918);
            this.provjeriSazetak.Name = "provjeriSazetak";
            this.provjeriSazetak.Size = new System.Drawing.Size(122, 23);
            this.provjeriSazetak.TabIndex = 36;
            this.provjeriSazetak.Text = "Provjeri sažetak";
            this.provjeriSazetak.UseVisualStyleBackColor = true;
            this.provjeriSazetak.Click += new System.EventHandler(this.provjeriSazetak_Click);
            // 
            // kreirajSazetak
            // 
            this.kreirajSazetak.Location = new System.Drawing.Point(799, 482);
            this.kreirajSazetak.Margin = new System.Windows.Forms.Padding(2);
            this.kreirajSazetak.Name = "kreirajSazetak";
            this.kreirajSazetak.Size = new System.Drawing.Size(291, 63);
            this.kreirajSazetak.TabIndex = 37;
            this.kreirajSazetak.Text = "Kreiraj sažetak";
            this.kreirajSazetak.UseVisualStyleBackColor = true;
            this.kreirajSazetak.Click += new System.EventHandler(this.kreirajSazetak_Click);
            // 
            // ocistiSazetak
            // 
            this.ocistiSazetak.Location = new System.Drawing.Point(1644, 860);
            this.ocistiSazetak.Name = "ocistiSazetak";
            this.ocistiSazetak.Size = new System.Drawing.Size(111, 27);
            this.ocistiSazetak.TabIndex = 38;
            this.ocistiSazetak.Text = "Očisti sažetak";
            this.ocistiSazetak.UseVisualStyleBackColor = true;
            this.ocistiSazetak.Click += new System.EventHandler(this.ocistiSazetak_Click);
            // 
            // kreirajPotpis
            // 
            this.kreirajPotpis.Location = new System.Drawing.Point(799, 549);
            this.kreirajPotpis.Margin = new System.Windows.Forms.Padding(2);
            this.kreirajPotpis.Name = "kreirajPotpis";
            this.kreirajPotpis.Size = new System.Drawing.Size(291, 63);
            this.kreirajPotpis.TabIndex = 39;
            this.kreirajPotpis.Text = "Kreiraj digitalni potpis";
            this.kreirajPotpis.UseVisualStyleBackColor = true;
            this.kreirajPotpis.Click += new System.EventHandler(this.kreirajPotpis_Click);
            // 
            // provjeriDigitalniPotpis
            // 
            this.provjeriDigitalniPotpis.Location = new System.Drawing.Point(1750, 958);
            this.provjeriDigitalniPotpis.Name = "provjeriDigitalniPotpis";
            this.provjeriDigitalniPotpis.Size = new System.Drawing.Size(122, 23);
            this.provjeriDigitalniPotpis.TabIndex = 43;
            this.provjeriDigitalniPotpis.Text = "Provjeri digitalni potpis";
            this.provjeriDigitalniPotpis.UseVisualStyleBackColor = true;
            this.provjeriDigitalniPotpis.Click += new System.EventHandler(this.provjeriDigitalniPotpis_Click);
            // 
            // ucitajPotpis
            // 
            this.ucitajPotpis.Location = new System.Drawing.Point(1633, 958);
            this.ucitajPotpis.Name = "ucitajPotpis";
            this.ucitajPotpis.Size = new System.Drawing.Size(111, 23);
            this.ucitajPotpis.TabIndex = 42;
            this.ucitajPotpis.Text = "Učitaj digitalni potpis";
            this.ucitajPotpis.UseVisualStyleBackColor = true;
            this.ucitajPotpis.Click += new System.EventHandler(this.ucitajPotpis_Click);
            // 
            // tekstZaDigitalniPotpis
            // 
            this.tekstZaDigitalniPotpis.Enabled = false;
            this.tekstZaDigitalniPotpis.Location = new System.Drawing.Point(1175, 960);
            this.tekstZaDigitalniPotpis.Name = "tekstZaDigitalniPotpis";
            this.tekstZaDigitalniPotpis.Size = new System.Drawing.Size(452, 20);
            this.tekstZaDigitalniPotpis.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(1091, 963);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Digitalni potpis:";
            // 
            // ocistiPotpis
            // 
            this.ocistiPotpis.Location = new System.Drawing.Point(1527, 860);
            this.ocistiPotpis.Name = "ocistiPotpis";
            this.ocistiPotpis.Size = new System.Drawing.Size(111, 27);
            this.ocistiPotpis.TabIndex = 44;
            this.ocistiPotpis.Text = "Očisti potpis";
            this.ocistiPotpis.UseVisualStyleBackColor = true;
            this.ocistiPotpis.Click += new System.EventHandler(this.ocistiPotpis_Click);
            // 
            // FormaRSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1886, 1034);
            this.Controls.Add(this.ocistiPotpis);
            this.Controls.Add(this.provjeriDigitalniPotpis);
            this.Controls.Add(this.ucitajPotpis);
            this.Controls.Add(this.tekstZaDigitalniPotpis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kreirajPotpis);
            this.Controls.Add(this.ocistiSazetak);
            this.Controls.Add(this.kreirajSazetak);
            this.Controls.Add(this.provjeriSazetak);
            this.Controls.Add(this.ucitajSazetak);
            this.Controls.Add(this.tekstZaSazetak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ocistiPrivatniKljuc);
            this.Controls.Add(this.ocistiJavniKljuc);
            this.Controls.Add(this.kreirajParKljuceva);
            this.Controls.Add(this.ocistiKriptiraniTekst);
            this.Controls.Add(this.spremiKriptiraniTekst);
            this.Controls.Add(this.ucitajKriptiraniTekst);
            this.Controls.Add(this.ucitajPrivatniKljuc);
            this.Controls.Add(this.ucitajJavniKljuc);
            this.Controls.Add(this.tekstPrivatniKljuc);
            this.Controls.Add(this.tekstJavniKljuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ocistiOriginalTekst);
            this.Controls.Add(this.spremiDatotekuRsa);
            this.Controls.Add(this.ucitajDatotekuRsa);
            this.Controls.Add(this.dekriptiranjeRsa);
            this.Controls.Add(this.kriptiranjeRsa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormaRSA";
            this.Text = "RSA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox originalTekstRsa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox kriptiraniTekstRsa;
        private System.Windows.Forms.Button dekriptiranjeRsa;
        private System.Windows.Forms.Button kriptiranjeRsa;
        private System.Windows.Forms.Button ucitajDatotekuRsa;
        private System.Windows.Forms.Button spremiDatotekuRsa;
        private System.Windows.Forms.Button ocistiOriginalTekst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tekstJavniKljuc;
        private System.Windows.Forms.TextBox tekstPrivatniKljuc;
        private System.Windows.Forms.Button ucitajJavniKljuc;
        private System.Windows.Forms.Button ucitajPrivatniKljuc;
        private System.Windows.Forms.Button ocistiKriptiraniTekst;
        private System.Windows.Forms.Button spremiKriptiraniTekst;
        private System.Windows.Forms.Button ucitajKriptiraniTekst;
        private System.Windows.Forms.Button kreirajParKljuceva;
        private System.Windows.Forms.Button ocistiJavniKljuc;
        private System.Windows.Forms.Button ocistiPrivatniKljuc;
        private System.Windows.Forms.Button ucitajSazetak;
        private System.Windows.Forms.TextBox tekstZaSazetak;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button provjeriSazetak;
        private System.Windows.Forms.Button kreirajSazetak;
        private System.Windows.Forms.Button ocistiSazetak;
        private System.Windows.Forms.Button kreirajPotpis;
        private System.Windows.Forms.Button provjeriDigitalniPotpis;
        private System.Windows.Forms.Button ucitajPotpis;
        private System.Windows.Forms.TextBox tekstZaDigitalniPotpis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ocistiPotpis;
    }
}