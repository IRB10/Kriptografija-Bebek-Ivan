using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kriptografija_Bebek_Ivan
{
    public partial class FormaRSA : Form
    {
        public FormaRSA()
        {
            InitializeComponent();
        }

        private void ucitajDatotekuRsa_Click(object sender, EventArgs e)
        {
            TextBox podaci = null;
            string dokument = "";

            System.Windows.Forms.OpenFileDialog dijalogZaUcitavanje = new System.Windows.Forms.OpenFileDialog();
            dijalogZaUcitavanje.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dijalogZaUcitavanje.DefaultExt = "txt";
            dijalogZaUcitavanje.ShowDialog();
            if (dijalogZaUcitavanje.FileName != "")
            {
                dokument = dijalogZaUcitavanje.FileName;
                string tekst = File.ReadAllText(dokument);
                originalTekstRsa.Text = tekst;
                podaci = originalTekstRsa;
                podaci.Text = ucitajDokument(dokument);
                if (podaci.Text != "" && podaci.Lines[0] == "")
                {
                    string[] lines = podaci.Lines;
                    podaci.Lines = lines.Skip(1).ToArray();
                }
            }
            else
            {
                MessageBox.Show("Molimo odaberite datoteku koju želite otvoriti!");
            }
        }

        private string ucitajDokument(string dokument)
        {
            string podaci = "";
            string red = "";

            string path = dokument;

            if (!File.Exists(path))
            {
                return podaci;
            }

            StreamReader streamReader = new StreamReader(path);
            red = streamReader.ReadLine();

            while (red != null)
            {
                podaci = podaci + Environment.NewLine + red;
                red = streamReader.ReadLine();
            }
            streamReader.Close();
            return podaci;
        }

        private void spremiDatotekuRsa_Click(object sender, EventArgs e)
        {
            string podaci = "";
            string dokument = "";

            System.Windows.Forms.SaveFileDialog dijalogZaUcitavanje = new System.Windows.Forms.SaveFileDialog();
            dijalogZaUcitavanje.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dijalogZaUcitavanje.DefaultExt = "txt";
            dijalogZaUcitavanje.ShowDialog();
            if (dijalogZaUcitavanje.FileName != "")
            {
                podaci = originalTekstRsa.Text;
                dokument = dijalogZaUcitavanje.FileName;
                File.WriteAllText(dokument, podaci);

            }
            else
            {
                MessageBox.Show("Molimo odredite gdje želite da se datoteka spremi!");
            }
        }

        private void ucitajJavniKljuc_Click(object sender, EventArgs e)
        {
            try
            {
                string tekstZaRsaJ = File.ReadAllText("javni_kljuc.txt");
                tekstJavniKljuc.Text = tekstZaRsaJ;
            }
            catch (Exception)
            {
                MessageBox.Show("Javni ključ ne postoji molimo generirajte ga.");
            }
        }

        private void ucitajPrivatniKljuc_Click(object sender, EventArgs e)
        {
            try
            {
                string tekstZaRsaP = File.ReadAllText("privatni_kljuc.txt");
                tekstPrivatniKljuc.Text = tekstZaRsaP;
            }
            catch (Exception)
            {
                MessageBox.Show("Privatni ključ ne postoji molimo generirajte ga.");
            }
        }


        private void kriptiranjeRsa_Click(object sender, EventArgs e)
        {
            string PodaciZaKriptiranje = originalTekstRsa.Text;
            string KljucZaKriptiranje = tekstJavniKljuc.Text;

            if (PodaciZaKriptiranje == null || PodaciZaKriptiranje.Length <= 0)
            {
                MessageBox.Show("Tekst za enkripciju neispravan");
                return;
            }
            if (KljucZaKriptiranje == null || KljucZaKriptiranje.Length <= 0)
            {
                MessageBox.Show("Ključ za enkripciju neispravan");
                return;
            }

            try
            {
                byte[] kriptiraniPodaci;
                UnicodeEncoding KonverterBitova = new UnicodeEncoding();
                byte[] ByteDataToEncrypt = KonverterBitova.GetBytes(PodaciZaKriptiranje);
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(2048))
                {
                    RSA.FromXmlString(KljucZaKriptiranje);
                    kriptiraniPodaci = RSA.Encrypt(ByteDataToEncrypt, false);
                }
                kriptiraniTekstRsa.Text = Convert.ToBase64String(kriptiraniPodaci);
            }
            catch (Exception)
            {
                MessageBox.Show("Enkripcija neuspjela! Provjerite ispravnost ključa i originalni tekst");
                return;
            }

            string podaci = "";
            string dokument = "";

            System.Windows.Forms.SaveFileDialog dijalogZaUcitavanje = new System.Windows.Forms.SaveFileDialog();
            dijalogZaUcitavanje.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dijalogZaUcitavanje.DefaultExt = "txt";
            dijalogZaUcitavanje.ShowDialog();

            if (dijalogZaUcitavanje.FileName != "")
            {
                podaci = kriptiraniTekstRsa.Text;
                dokument = dijalogZaUcitavanje.FileName;
                File.WriteAllText(dokument, podaci);

            }
            else
            {
                MessageBox.Show("Molimo odredite gdje želite da se kriptirani tekst spremi!");
            }
        }

        private void dekriptiranjeRsa_Click(object sender, EventArgs e)
        {
            string PodaciZaDekriptiranje = kriptiraniTekstRsa.Text;
            string KljucZaDekriptiranje = tekstPrivatniKljuc.Text;

            if (PodaciZaDekriptiranje == null || PodaciZaDekriptiranje.Length <= 0)
            {
                MessageBox.Show("Tekst za dekripciju neispravan");
                return;
            }
            if (KljucZaDekriptiranje == null || KljucZaDekriptiranje.Length <= 0)
            {
                MessageBox.Show("Ključ za dekripciju neispravan");
                return;
            }

            try
            {
                byte[] dekriptiraniPodaci;
                byte[] bitovniPodaciZaDekriptiranje = Convert.FromBase64String(PodaciZaDekriptiranje);
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(2048))
                {
                    RSA.FromXmlString(KljucZaDekriptiranje);
                    dekriptiraniPodaci = RSA.Decrypt(bitovniPodaciZaDekriptiranje, false);
                }
                UnicodeEncoding ByteConverter = new UnicodeEncoding();
                originalTekstRsa.Text = ByteConverter.GetString(dekriptiraniPodaci);
            }
            catch (Exception)
            {
                MessageBox.Show("Dekripcije neuspjela! Provjerite ispravnost ključa i kriptiranog teksta");
                return;
            }
        }

        private void ucitajKriptiraniTekst_Click(object sender, EventArgs e)
        {
            TextBox podaci = null;
            string dokument = "";

            System.Windows.Forms.OpenFileDialog dijalogZaUcitavanje = new System.Windows.Forms.OpenFileDialog();
            dijalogZaUcitavanje.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dijalogZaUcitavanje.DefaultExt = "txt";
            dijalogZaUcitavanje.ShowDialog();
            if (dijalogZaUcitavanje.FileName != "")
            {
                dokument = dijalogZaUcitavanje.FileName;
                string tekst = File.ReadAllText(dokument);
                kriptiraniTekstRsa.Text = tekst;
                podaci = kriptiraniTekstRsa;
                podaci.Text = ucitajDokument(dokument);
                if (podaci.Text != "" && podaci.Lines[0] == "")
                {
                    string[] lines = podaci.Lines;
                    podaci.Lines = lines.Skip(1).ToArray();
                }
            }
            else
            {
                MessageBox.Show("Molimo odaberite datoteku koju želite otvoriti!");
            }
        }

        private void kreirajParKljuceva_Click(object sender, EventArgs e)
        {
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(2048))
            {
                tekstJavniKljuc.Text = RSA.ToXmlString(false);
                tekstPrivatniKljuc.Text = RSA.ToXmlString(true);
                File.WriteAllText("javni_kljuc.txt", tekstJavniKljuc.Text);
                File.WriteAllText("privatni_kljuc.txt", tekstPrivatniKljuc.Text);
            }
        }

        private void ocistiOriginalTekst_Click(object sender, EventArgs e)
        {
            originalTekstRsa.Text = string.Empty;
        }

        private void ocistiKriptiraniTekst_Click(object sender, EventArgs e)
        {
            kriptiraniTekstRsa.Text = string.Empty;
        }

        private void ocistiJavniKljuc_Click(object sender, EventArgs e)
        {
            tekstJavniKljuc.Text = string.Empty;
        }

        private void ocistiPrivatniKljuc_Click(object sender, EventArgs e)
        {
            tekstPrivatniKljuc.Text = string.Empty;
        }

        private void spremiKriptiraniTekst_Click(object sender, EventArgs e)
        {
            string podaci = "";
            string dokument = "";

            System.Windows.Forms.SaveFileDialog dijalogZaUcitavanje = new System.Windows.Forms.SaveFileDialog();
            dijalogZaUcitavanje.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dijalogZaUcitavanje.DefaultExt = "txt";
            dijalogZaUcitavanje.ShowDialog();
            if (dijalogZaUcitavanje.FileName != "")
            {
                podaci = kriptiraniTekstRsa.Text;
                dokument = dijalogZaUcitavanje.FileName;
                File.WriteAllText(dokument, podaci);

            }
            else
            {
                MessageBox.Show("Molimo odredite gdje želite da se kriptirani tekst spremi!");
            }
        }

        private void kreirajSazetak_Click(object sender, EventArgs e)
        {
            tekstZaSazetak.BackColor = Color.White;
            tekstZaSazetak.Text = GetSHA256CSPHash(originalTekstRsa.Text);
            File.WriteAllText("sazetak.txt", tekstZaSazetak.Text);
        }

        public static string GetSHA256CSPHash(string tekstZaHashiranje)
        {

            SHA256CryptoServiceProvider SHA256provider = new SHA256CryptoServiceProvider();
            byte[] hashiranaVrijednost = SHA256provider.ComputeHash(Encoding.Default.GetBytes(tekstZaHashiranje));
            StringBuilder stringBuilder = new StringBuilder();
            for (int counter = 0; counter < hashiranaVrijednost.Length; counter++)
            {
                stringBuilder.Append(hashiranaVrijednost[counter].ToString("X1"));
            }
            return stringBuilder.ToString();
        }

        private void ocistiSazetak_Click(object sender, EventArgs e)
        {
            tekstZaSazetak.Text = string.Empty;
        }

        private void ucitajSazetak_Click(object sender, EventArgs e)
        {
            try
            {
                string tekstZaSazetakD = File.ReadAllText("sazetak.txt");
                tekstZaSazetak.Text = tekstZaSazetakD;
            }
            catch (Exception)
            {
                MessageBox.Show("Sažetak ne postoji molimo generirajte ga.");
            }
        }

        private void provjeriSazetak_Click(object sender, EventArgs e)
        {
            if (VerifySHA256CSPhash(originalTekstRsa.Text, tekstZaSazetak.Text))
            {
                tekstZaSazetak.BackColor = Color.GreenYellow;
            }
            else
            {
                tekstZaSazetak.BackColor = Color.Red;
                MessageBox.Show("Sažetak nije ispravan!");
            }
        }

        static bool VerifySHA256CSPhash(string izvorniTekst, string prethodnaHashVrijednost)
        {
            string hashiranaVrijednost = GetSHA256CSPHash(izvorniTekst);
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;
            if (stringComparer.Compare(hashiranaVrijednost, prethodnaHashVrijednost).Equals(0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void kreirajPotpis_Click(object sender, EventArgs e)
        {
            string KljucZaKriptiranje = tekstPrivatniKljuc.Text;

            if (KljucZaKriptiranje == null || KljucZaKriptiranje.Length <= 0)
            {
                MessageBox.Show("Ključ za enkripciju neispravan");
                return;
            }

            try
            {
                UnicodeEncoding KonverterBitova = new UnicodeEncoding();
                byte[] PodaciZaPotpis = KonverterBitova.GetBytes(originalTekstRsa.Text);
                RSACryptoServiceProvider RSACryptoServiceProvider = new RSACryptoServiceProvider();
                RSACryptoServiceProvider.FromXmlString(KljucZaKriptiranje);
                tekstZaDigitalniPotpis.Text = Convert.ToBase64String(RSACryptoServiceProvider.SignData(PodaciZaPotpis, new SHA256CryptoServiceProvider()));
                File.WriteAllText("digitalni_potpis.txt", tekstZaDigitalniPotpis.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Potpisivanje neuspješno! Provjerite ispravnost ključa i teksta");
                return;
            }

            tekstZaDigitalniPotpis.BackColor = Color.White;
        }

        private void ucitajPotpis_Click(object sender, EventArgs e)
        {
            try
            {
                string tekstZaPotpisD = File.ReadAllText("digitalni_potpis.txt");
                tekstZaDigitalniPotpis.Text = tekstZaPotpisD;
            }
            catch (Exception)
            {
                MessageBox.Show("Sažetak ne postoji molimo generirajte ga.");
            }
        }

        private void provjeriDigitalniPotpis_Click(object sender, EventArgs e)
        {
            string KljucZaDekriptiranje = tekstJavniKljuc.Text;
            if (KljucZaDekriptiranje == null || KljucZaDekriptiranje.Length <= 0)
            {
                MessageBox.Show("Ključ za dekripciju neispravan");
                return;
            }

            try
            {
                UnicodeEncoding KonverterBitova = new UnicodeEncoding();
                byte[] PodaciZaPotvrdu = KonverterBitova.GetBytes(originalTekstRsa.Text);
                byte[] PotpisaniPodaci = Convert.FromBase64String(tekstZaDigitalniPotpis.Text);
                RSACryptoServiceProvider RSAalg = new RSACryptoServiceProvider();
                RSAalg.FromXmlString(KljucZaDekriptiranje);
                bool status = RSAalg.VerifyData(PodaciZaPotvrdu, new SHA256CryptoServiceProvider(), PotpisaniPodaci);
                if (status)
                {
                    tekstZaDigitalniPotpis.BackColor = Color.GreenYellow;
                    MessageBox.Show("Digitalni potpis uspješno verificiran");
                }
                else
                {
                    tekstZaDigitalniPotpis.BackColor = Color.Red;
                    MessageBox.Show("Digitalni potpis nije ispravan");
                }
            }
            catch (Exception)
            {
                tekstZaDigitalniPotpis.BackColor = Color.Red;
                MessageBox.Show("Potpisivanje neuspješno! Provjerite ispravnost ključa i teksta");
                return;
            }

        }

        private void ocistiPotpis_Click(object sender, EventArgs e)
        {
            tekstZaDigitalniPotpis.Text = string.Empty;
        }
    }
}
