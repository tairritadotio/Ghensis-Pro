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
    public partial class FrmGH : Form
    {
        public FrmGH()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Git\Git Bash");
        }

        private void GitHub_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\*\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\GitHub, Inc\GitHub Desktop");
        }
    }
}
