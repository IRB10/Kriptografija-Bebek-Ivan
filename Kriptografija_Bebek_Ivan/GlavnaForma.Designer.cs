namespace Kriptografija_Bebek_Ivan
{
    partial class GlavnaForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlavnaForma));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rsaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aesToolStripMenuItem,
            this.rsaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aesToolStripMenuItem
            // 
            this.aesToolStripMenuItem.Name = "aesToolStripMenuItem";
            this.aesToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.aesToolStripMenuItem.Text = "AES";
            this.aesToolStripMenuItem.Click += new System.EventHandler(this.aesToolStripMenuItem_Click);
            // 
            // rsaToolStripMenuItem
            // 
            this.rsaToolStripMenuItem.Name = "rsaToolStripMenuItem";
            this.rsaToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.rsaToolStripMenuItem.Text = "RSA";
            this.rsaToolStripMenuItem.Click += new System.EventHandler(this.rsaToolStripMenuItem_Click);
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GlavnaForma";
            this.Text = "Kriptografija Ivan Bebek";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GlavnaForma_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rsaToolStripMenuItem;
    }
}

