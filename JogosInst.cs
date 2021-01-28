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
    public partial class FrmJInst : Form
    {
        public FrmJInst()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Riot Games\League of Legends");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Z8Games\CrossFire BR\CrossFire BR");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Guild Wars 2\Guild Wars 2");
        }

        private void FrmJInst_Load(object sender, EventArgs e)
        {

        }
    }
}
