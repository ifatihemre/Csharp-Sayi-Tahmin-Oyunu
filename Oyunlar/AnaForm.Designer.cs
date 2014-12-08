namespace Oyunlar
{
    partial class AnaForm
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
            this.AnaMenu = new System.Windows.Forms.MenuStrip();
            this.sayıTahminOyunuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.süreliOyunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.süresizOyunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AnaMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnaMenu
            // 
            this.AnaMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sayıTahminOyunuToolStripMenuItem});
            this.AnaMenu.Location = new System.Drawing.Point(0, 0);
            this.AnaMenu.Name = "AnaMenu";
            this.AnaMenu.Size = new System.Drawing.Size(248, 24);
            this.AnaMenu.TabIndex = 0;
            this.AnaMenu.Text = "AnaMenu";
            // 
            // sayıTahminOyunuToolStripMenuItem
            // 
            this.sayıTahminOyunuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.süreliOyunToolStripMenuItem,
            this.süresizOyunToolStripMenuItem});
            this.sayıTahminOyunuToolStripMenuItem.Name = "sayıTahminOyunuToolStripMenuItem";
            this.sayıTahminOyunuToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.sayıTahminOyunuToolStripMenuItem.Text = "Sayı Tahmin Oyunu";
            // 
            // süreliOyunToolStripMenuItem
            // 
            this.süreliOyunToolStripMenuItem.Name = "süreliOyunToolStripMenuItem";
            this.süreliOyunToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.süreliOyunToolStripMenuItem.Text = "Süreli Oyun";
            this.süreliOyunToolStripMenuItem.Click += new System.EventHandler(this.süreliOyunToolStripMenuItem_Click);
            // 
            // süresizOyunToolStripMenuItem
            // 
            this.süresizOyunToolStripMenuItem.Name = "süresizOyunToolStripMenuItem";
            this.süresizOyunToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.süresizOyunToolStripMenuItem.Text = "Süresiz Oyun";
            this.süresizOyunToolStripMenuItem.Click += new System.EventHandler(this.süresizOyunToolStripMenuItem_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 330);
            this.Controls.Add(this.AnaMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.AnaMenu;
            this.Name = "AnaForm";
            this.Text = "Oyun Kutusu";
            this.AnaMenu.ResumeLayout(false);
            this.AnaMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip AnaMenu;
        private System.Windows.Forms.ToolStripMenuItem sayıTahminOyunuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem süreliOyunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem süresizOyunToolStripMenuItem;
    }
}

