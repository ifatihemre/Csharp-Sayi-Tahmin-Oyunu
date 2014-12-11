using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oyunlar
{
    public partial class AnaForm : Form
    {
        SureliOyun sureli; 
        SureliOyunPD sureliPD;
        SuresizOyun suresiz;
        SuresizOyunPD suresizPD;
        
        public AnaForm()
        {
            InitializeComponent();
        }

        private void başlatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sureli == null || sureli.IsDisposed)
            {
                sureli = new SureliOyun();
                sureli.MdiParent = this;
                sureli.Show();
            }
            else
            {
                sureli.Focus();
            }

            sureli.WindowState = FormWindowState.Maximized;
        }

        private void başlatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (suresiz == null || suresiz.IsDisposed)
            {
                suresiz = new SuresizOyun();
                suresiz.MdiParent = this;
                suresiz.Show();
            }
            else
            {
                suresiz.Focus();
            }

            suresiz.WindowState = FormWindowState.Maximized;
        }

        private void puanDurumuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sureliPD == null || sureliPD.IsDisposed)
            {
                sureliPD = new SureliOyunPD();
                sureliPD.MdiParent = this;
                sureliPD.Show();
            }
            else
            {
                sureliPD.Focus();
            }

            sureliPD.WindowState = FormWindowState.Maximized;
        }

        private void puanDurumuToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (suresizPD == null || suresizPD.IsDisposed)
            {
                suresizPD = new SuresizOyunPD();
                suresizPD.MdiParent = this;
                suresizPD.Show();
            }
            else
            {
                suresizPD.Focus();
            }

            suresizPD.WindowState = FormWindowState.Maximized;
        }
    }
}
