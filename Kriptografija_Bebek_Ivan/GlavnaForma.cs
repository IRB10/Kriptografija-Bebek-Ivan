using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kriptografija_Bebek_Ivan
{
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();
        }



        private void aesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }
            FormAes formaZaAes = new FormAes();
            formaZaAes.MdiParent = this;
            formaZaAes.WindowState = FormWindowState.Maximized;
            formaZaAes.Show();
        }

        private void rsaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }
            FormaRSA formaZaRSA = new FormaRSA();
            formaZaRSA.MdiParent = this;
            formaZaRSA.WindowState = FormWindowState.Maximized;
            formaZaRSA.Show();
        }

        private void GlavnaForma_Load(object sender, EventArgs e)
        {
            
        }
    }
}
