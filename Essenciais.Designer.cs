
namespace Ghensis_Pro
{
    partial class FrmEssen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEssen));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnTwiSou = new System.Windows.Forms.Button();
            this.btnBotSh = new System.Windows.Forms.Button();
            this.btnBotSpeak = new System.Windows.Forms.Button();
            this.btnObs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(134, 130);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnTwiSou
            // 
            this.btnTwiSou.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTwiSou.BackgroundImage = global::Ghensis_Pro.Properties.Resources.Twitch_Soundtrack;
            this.btnTwiSou.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTwiSou.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTwiSou.Location = new System.Drawing.Point(255, 30);
            this.btnTwiSou.Name = "btnTwiSou";
            this.btnTwiSou.Size = new System.Drawing.Size(75, 61);
            this.btnTwiSou.TabIndex = 3;
            this.btnTwiSou.UseVisualStyleBackColor = true;
            this.btnTwiSou.Click += new System.EventHandler(this.btnTwiSou_Click);
            // 
            // btnBotSh
            // 
            this.btnBotSh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBotSh.BackgroundImage = global::Ghensis_Pro.Properties.Resources.BotShSo;
            this.btnBotSh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBotSh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBotSh.Location = new System.Drawing.Point(174, 30);
            this.btnBotSh.Name = "btnBotSh";
            this.btnBotSh.Size = new System.Drawing.Size(75, 61);
            this.btnBotSh.TabIndex = 2;
            this.btnBotSh.UseVisualStyleBackColor = true;
            this.btnBotSh.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnBotSpeak
            // 
            this.btnBotSpeak.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBotSpeak.BackgroundImage = global::Ghensis_Pro.Properties.Resources.BotSpeaker;
            this.btnBotSpeak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBotSpeak.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBotSpeak.Location = new System.Drawing.Point(93, 30);
            this.btnBotSpeak.Name = "btnBotSpeak";
            this.btnBotSpeak.Size = new System.Drawing.Size(75, 61);
            this.btnBotSpeak.TabIndex = 1;
            this.btnBotSpeak.UseVisualStyleBackColor = true;
            this.btnBotSpeak.Click += new System.EventHandler(this.btnBotSpeak_Click);
            // 
            // btnObs
            // 
            this.btnObs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnObs.BackgroundImage = global::Ghensis_Pro.Properties.Resources.OBS_Studio;
            this.btnObs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnObs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnObs.Location = new System.Drawing.Point(12, 30);
            this.btnObs.Name = "btnObs";
            this.btnObs.Size = new System.Drawing.Size(75, 61);
            this.btnObs.TabIndex = 0;
            this.btnObs.UseVisualStyleBackColor = true;
            this.btnObs.Click += new System.EventHandler(this.btnObs_Click);
            // 
            // FrmEssen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ghensis_Pro.Properties.Resources.Background_Live;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(342, 180);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnTwiSou);
            this.Controls.Add(this.btnBotSh);
            this.Controls.Add(this.btnBotSpeak);
            this.Controls.Add(this.btnObs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEssen";
            this.Text = "Essenciais";
            this.Load += new System.EventHandler(this.FrmEssen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnObs;
        private System.Windows.Forms.Button btnBotSpeak;
        private System.Windows.Forms.Button btnBotSh;
        private System.Windows.Forms.Button btnTwiSou;
        private System.Windows.Forms.Button btnVoltar;
    }
}