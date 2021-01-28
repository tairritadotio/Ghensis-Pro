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
    public partial class FrmJogos : Form
    {
        public FrmJogos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Steam\steam");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Epic Games Launcher");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\*\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Facebook\Facebook Gameroom");
        }

        private void FrmJogos_Load(object sender, EventArgs e)
        {

        }
    }
}
