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
    public partial class FrmInicial : Form
    {
        public FrmInicial()
        {
            InitializeComponent();
        }

        private void FrmInicial_Load(object sender, EventArgs e)
        {
            
        }

        private void escenciaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEssen frmEssen1 = new FrmEssen();
            frmEssen1.MdiParent = this;
            frmEssen1.Show();
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void interaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIntera frmIntera1 = new FrmIntera();
            frmIntera1.MdiParent = this;
            frmIntera1.Show();
            
        }

        private void iDEsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIDE frmIDE1 = new FrmIDE();
            frmIDE1.MdiParent = this;
            frmIDE1.Show();
            
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void navegadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNavega frmNavega1 = new FrmNavega();
            frmNavega1.MdiParent = this;
            frmNavega1.Show();
        }

        private void pesquisasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPesq frmPesq1 = new FrmPesq();
            frmPesq1.MdiParent = this;
            frmPesq1.Show();
        }

        private void redesSociaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRS frmRS1 = new FrmRS();
            frmRS1.MdiParent = this;
            frmRS1.Show();
        }

        private void emailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEMail frmEMail1 = new FrmEMail();
            frmEMail1.MdiParent = this;
            frmEMail1.Show();
        }

        private void videosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVideos frmVideos1 = new FrmVideos();
            frmVideos1.MdiParent = this;
            frmVideos1.Show();
        }

        private void plataformasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmJogos frmJogos1 = new FrmJogos();
            frmJogos1.MdiParent = this;
            frmJogos1.Show();
        }

        private void instaladosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmJInst frmJInst1 = new FrmJInst();
            frmJInst1.MdiParent = this;
            frmJInst1.Show();
        }

        private void pokersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPoker frmPoker1 = new FrmPoker();
            frmPoker1.MdiParent = this;
            frmPoker1.Show();
        }

        private void navegadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGH frmGH1 = new FrmGH();
            frmGH1.MdiParent = this;
            frmGH1.Show();
        }

        private void vozETextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmComu frmComu1 = new FrmComu();
            frmComu1.MdiParent = this;
            frmComu1.Show();
        }
    }
}
