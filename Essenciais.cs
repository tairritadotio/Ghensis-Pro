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
    public partial class FrmEssen : Form
    {
        public FrmEssen()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Node.js\Node.js command prompt");
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEssen_Load(object sender, EventArgs e)
        {
            
        }

        private void btnObs_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\OBS Studio\OBS Studio (64bit)");
        }

        private void btnTwiSou_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\*\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Soundtrack by Twitch");
        }
        private void btnBotSpeak_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\*\OneDrive\Documentos\Projects\BotSpeaker\GhensisBotV3\Server\bin\Release\net5.0\publish\GhensisBotV3.Server.exe");
        }
    }
}
