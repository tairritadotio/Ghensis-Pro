using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ghensis_Pro
{
    public partial class FrmIntera : Form
    {
        public FrmIntera()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSLabs_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://streamlabs.com/dashboard#/stats");
        }

        private void btnSElemnt_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://streamelements.com/dashboard");
        }

        private void btnSHoli_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://streamholics.live/");
        }
    }
}
