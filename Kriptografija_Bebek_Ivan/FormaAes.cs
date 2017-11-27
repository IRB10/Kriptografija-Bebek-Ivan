using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Kriptografija_Bebek_Ivan
{
    public partial class FormAes : Form
    {
        public FormAes()
        {
            InitializeComponent();
        }

        private void buttonZaUcitatOriginal_Click(object sender, EventArgs e)
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
                originalTekstDatoteke.Text = tekst;
                podaci = originalTekstDatoteke;
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

        private void buttonSpremiNoviUneseni_Click(object sender, EventArgs e)
        {
            string podaci = "";
            string dokument = "";

            System.Windows.Forms.SaveFileDialog dijalogZaUcitavanje = new System.Windows.Forms.SaveFileDialog();
            dijalogZaUcitavanje.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dijalogZaUcitavanje.DefaultExt = "txt";
            dijalogZaUcitavanje.ShowDialog();
            if (dijalogZaUcitavanje.FileName != "")
            {
                podaci = originalTekstDatoteke.Text;
                dokument = dijalogZaUcitavanje.FileName;
                File.WriteAllText(dokument, podaci);

            }
            else
            {
                MessageBox.Show("Molimo odredite gdje želite da se datoteka spremi!");
            }
        }

        private void spremiTajniKljuc_Click(object sender, EventArgs e)
        {
            using (AesCryptoServiceProvider AES = new AesCryptoServiceProvider())
            {
                AES.KeySize = 128;
                SoapHexBinary shb = new SoapHexBinary(AES.Key);
                tekstZaAesKljuc.Text = shb.ToString();
                File.WriteAllText("tajni_kljuc.txt", tekstZaAesKljuc.Text);
            }

        }

        private void ucitajTajniKljuc_Click(object sender, EventArgs e)
        {
            try
            {
                string tekstZaAes = File.ReadAllText("tajni_kljuc.txt");
                tekstZaAesKljuc.Text = tekstZaAes;
            }
            catch (Exception)
            {
                MessageBox.Show("Tajni ključ ne postoji molimo generirajte ga.");
            }


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
                podaci = kriptiraniTekstDatoteke.Text;
                dokument = dijalogZaUcitavanje.FileName;
                File.WriteAllText(dokument, podaci);

            }
            else
            {
                MessageBox.Show("Molimo odredite gdje želite da se kriptirani tekst spremi!");
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
                kriptiraniTekstDatoteke.Text = tekst;
                podaci = kriptiraniTekstDatoteke;
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

        private void ocistiOriginalniTekst_Click(object sender, EventArgs e)
        {
            originalTekstDatoteke.Text = string.Empty;
        }

        private void ocistiKriptiraniTekst_Click(object sender, EventArgs e)
        {
            kriptiraniTekstDatoteke.Text = string.Empty;
        }

        private void kriptiranjeAes_Click(object sender, EventArgs e)
        {
            string TekstZaEnkripciju = originalTekstDatoteke.Text;
            string KljucZaEnkripciju = tekstZaAesKljuc.Text;

            if (TekstZaEnkripciju == null || TekstZaEnkripciju.Length <= 0)
            {
                MessageBox.Show("Tekst za enkripciju neispravan");
                return;
            }

            if (KljucZaEnkripciju == null || KljucZaEnkripciju.Length <= 0)
            {
                MessageBox.Show("Ključ za enkripciju neispravan");
                return;
            }

            try
            {
                byte[] encryptedData;
                SoapHexBinary soapHexBinary = SoapHexBinary.Parse(KljucZaEnkripciju);
                byte[] Key = soapHexBinary.Value;
                byte[] IV = System.Text.ASCIIEncoding.ASCII.GetBytes("16A7C51F5CA8F123");
                using (Aes aesAlgoritam = Aes.Create())
                {
                    aesAlgoritam.Key = Key;
                    aesAlgoritam.IV = IV;
                    ICryptoTransform encryptor = aesAlgoritam.CreateEncryptor(aesAlgoritam.Key, aesAlgoritam.IV);
                    using (MemoryStream memoryStreamEncrypt = new MemoryStream())
                    {
                        using (CryptoStream cryptoStreamEncrypt = new CryptoStream(memoryStreamEncrypt, encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter streamWriterEncrypt = new StreamWriter(cryptoStreamEncrypt))
                            {
                                streamWriterEncrypt.Write(TekstZaEnkripciju);
                            }
                            encryptedData = memoryStreamEncrypt.ToArray();
                        }
                    }
                }
                kriptiraniTekstDatoteke.Text = Convert.ToBase64String(encryptedData);
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
                podaci = kriptiraniTekstDatoteke.Text;
                dokument = dijalogZaUcitavanje.FileName;
                File.WriteAllText(dokument, podaci);

            }
            else
            {
                MessageBox.Show("Molimo odredite gdje želite da se kriptirani tekst spremi!");
            }
        }

        private void dekriptiranjeAes_Click(object sender, EventArgs e)
        {
            string PodaciZaDekriptiranje = kriptiraniTekstDatoteke.Text;
            string KljucZaDekriptiranje = tekstZaAesKljuc.Text;

            if (PodaciZaDekriptiranje == null || PodaciZaDekriptiranje.Length <= 0)
            {
                MessageBox.Show("Tekst za dekripciju neispravan"); return;
            }

            if (KljucZaDekriptiranje == null || KljucZaDekriptiranje.Length <= 0)
            {
                MessageBox.Show("Ključ za dekripciju neispravan"); return;
            }

            try
            {
                string dekriptiraniPodaci;
                byte[] ByteDataToDecrypt = Convert.FromBase64String(PodaciZaDekriptiranje);
                SoapHexBinary soapHexBinary = SoapHexBinary.Parse(KljucZaDekriptiranje);
                byte[] Key = soapHexBinary.Value;
                byte[] IV = System.Text.ASCIIEncoding.ASCII.GetBytes("16A7C51F5CA8F123");
                using (Aes aesAlgoritam = Aes.Create())
                {
                    aesAlgoritam.Key = Key;
                    aesAlgoritam.IV = IV;
                    ICryptoTransform decryptor = aesAlgoritam.CreateDecryptor(aesAlgoritam.Key, aesAlgoritam.IV);
                    using (MemoryStream memoryStreamDecrypt = new MemoryStream(ByteDataToDecrypt))
                    {
                        using (CryptoStream cryptoStreamDecrypt = new CryptoStream(memoryStreamDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader streamReaderDecrypt = new StreamReader(cryptoStreamDecrypt))
                            {
                                dekriptiraniPodaci = streamReaderDecrypt.ReadToEnd();
                            }
                        }
                    }
                }
                originalTekstDatoteke.Text = dekriptiraniPodaci;
            }
            catch (Exception)
            {
                MessageBox.Show("Dekripcije neuspjela! Provjerite ispravnost ključa i kriptiranog teksta");
                return;
            }
        }

        private void ocistiTajniKljuc_Click(object sender, EventArgs e)
        {
            tekstZaAesKljuc.Text = string.Empty;
        }

        private void kreirajSazetak_Click(object sender, EventArgs e)
        {
            tekstZaSazetak.BackColor = Color.White;
            tekstZaSazetak.Text = GetSHA256CSPHash(originalTekstDatoteke.Text);
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
            if (VerifySHA256CSPhash(originalTekstDatoteke.Text, tekstZaSazetak.Text))
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

        private void ocistiSazetak_Click(object sender, EventArgs e)
        {
            tekstZaSazetak.Text = string.Empty;
        }

        private void FormAes_Load(object sender, EventArgs e)
        {
            
        }
    }
}
