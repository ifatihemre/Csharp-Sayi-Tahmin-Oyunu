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
        SuresizOyun suresiz;
        
        public AnaForm()
        {
            InitializeComponent();
        }

        private void süreliOyunToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void süresizOyunToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
