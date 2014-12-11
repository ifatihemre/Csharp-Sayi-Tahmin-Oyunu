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
            this.başlatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puanDurumuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.süresizOyunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.başlatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.puanDurumuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.süreliOyunToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.başlatToolStripMenuItem,
            this.puanDurumuToolStripMenuItem});
            this.süreliOyunToolStripMenuItem.Name = "süreliOyunToolStripMenuItem";
            this.süreliOyunToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.süreliOyunToolStripMenuItem.Text = "Süreli Oyun";
            // 
            // başlatToolStripMenuItem
            // 
            this.başlatToolStripMenuItem.Name = "başlatToolStripMenuItem";
            this.başlatToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.başlatToolStripMenuItem.Text = "Başlat";
            this.başlatToolStripMenuItem.Click += new System.EventHandler(this.başlatToolStripMenuItem_Click);
            // 
            // puanDurumuToolStripMenuItem
            // 
            this.puanDurumuToolStripMenuItem.Name = "puanDurumuToolStripMenuItem";
            this.puanDurumuToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.puanDurumuToolStripMenuItem.Text = "Puan Durumu";
            this.puanDurumuToolStripMenuItem.Click += new System.EventHandler(this.puanDurumuToolStripMenuItem_Click);
            // 
            // süresizOyunToolStripMenuItem
            // 
            this.süresizOyunToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.başlatToolStripMenuItem1,
            this.puanDurumuToolStripMenuItem1});
            this.süresizOyunToolStripMenuItem.Name = "süresizOyunToolStripMenuItem";
            this.süresizOyunToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.süresizOyunToolStripMenuItem.Text = "Süresiz Oyun";
            // 
            // başlatToolStripMenuItem1
            // 
            this.başlatToolStripMenuItem1.Name = "başlatToolStripMenuItem1";
            this.başlatToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.başlatToolStripMenuItem1.Text = "Başlat";
            this.başlatToolStripMenuItem1.Click += new System.EventHandler(this.başlatToolStripMenuItem1_Click);
            // 
            // puanDurumuToolStripMenuItem1
            // 
            this.puanDurumuToolStripMenuItem1.Name = "puanDurumuToolStripMenuItem1";
            this.puanDurumuToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.puanDurumuToolStripMenuItem1.Text = "Puan Durumu";
            this.puanDurumuToolStripMenuItem1.Click += new System.EventHandler(this.puanDurumuToolStripMenuItem1_Click);
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
        private System.Windows.Forms.ToolStripMenuItem puanDurumuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puanDurumuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem başlatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem başlatToolStripMenuItem1;
    }
}

