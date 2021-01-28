
namespace Ghensis_Pro
{
    partial class FrmIntera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIntera));
            this.button4 = new System.Windows.Forms.Button();
            this.btnSHoli = new System.Windows.Forms.Button();
            this.btnSElemnt = new System.Windows.Forms.Button();
            this.btnSLabs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(109, 142);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Voltar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSHoli
            // 
            this.btnSHoli.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSHoli.BackgroundImage = global::Ghensis_Pro.Properties.Resources.StreamHolics;
            this.btnSHoli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSHoli.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSHoli.Location = new System.Drawing.Point(206, 12);
            this.btnSHoli.Name = "btnSHoli";
            this.btnSHoli.Size = new System.Drawing.Size(75, 54);
            this.btnSHoli.TabIndex = 2;
            this.btnSHoli.UseVisualStyleBackColor = true;
            this.btnSHoli.Click += new System.EventHandler(this.btnSHoli_Click);
            // 
            // btnSElemnt
            // 
            this.btnSElemnt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSElemnt.BackgroundImage = global::Ghensis_Pro.Properties.Resources.StreamElements;
            this.btnSElemnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSElemnt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSElemnt.Location = new System.Drawing.Point(109, 12);
            this.btnSElemnt.Name = "btnSElemnt";
            this.btnSElemnt.Size = new System.Drawing.Size(75, 54);
            this.btnSElemnt.TabIndex = 1;
            this.btnSElemnt.UseVisualStyleBackColor = true;
            this.btnSElemnt.Click += new System.EventHandler(this.btnSElemnt_Click);
            // 
            // btnSLabs
            // 
            this.btnSLabs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSLabs.BackgroundImage = global::Ghensis_Pro.Properties.Resources.StreamLabs;
            this.btnSLabs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSLabs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSLabs.Location = new System.Drawing.Point(20, 12);
            this.btnSLabs.Name = "btnSLabs";
            this.btnSLabs.Size = new System.Drawing.Size(75, 54);
            this.btnSLabs.TabIndex = 0;
            this.btnSLabs.UseVisualStyleBackColor = true;
            this.btnSLabs.Click += new System.EventHandler(this.btnSLabs_Click);
            // 
            // FrmIntera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ghensis_Pro.Properties.Resources.Integração;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(301, 206);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnSHoli);
            this.Controls.Add(this.btnSElemnt);
            this.Controls.Add(this.btnSLabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(301, 206);
            this.Name = "FrmIntera";
            this.Text = "Interação";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSLabs;
        private System.Windows.Forms.Button btnSElemnt;
        private System.Windows.Forms.Button btnSHoli;
        private System.Windows.Forms.Button button4;
    }
}