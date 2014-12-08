namespace Oyunlar
{
    partial class SuresizOyun
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
            this.AralikLabel = new System.Windows.Forms.Label();
            this.HakLabel = new System.Windows.Forms.Label();
            this.MesajLabel = new System.Windows.Forms.Label();
            this.SonucLabel = new System.Windows.Forms.Label();
            this.TahminKutu = new System.Windows.Forms.TextBox();
            this.TahminButon = new System.Windows.Forms.Button();
            this.ResetButon = new System.Windows.Forms.Button();
            this.Grup = new System.Windows.Forms.GroupBox();
            this.Grup.SuspendLayout();
            this.SuspendLayout();
            // 
            // AralikLabel
            // 
            this.AralikLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AralikLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AralikLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.AralikLabel.Location = new System.Drawing.Point(6, 16);
            this.AralikLabel.Name = "AralikLabel";
            this.AralikLabel.Size = new System.Drawing.Size(210, 21);
            this.AralikLabel.TabIndex = 0;
            this.AralikLabel.Text = "1 ile 10 arasında bir sayı girin.";
            this.AralikLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HakLabel
            // 
            this.HakLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HakLabel.Location = new System.Drawing.Point(6, 47);
            this.HakLabel.Name = "HakLabel";
            this.HakLabel.Size = new System.Drawing.Size(210, 13);
            this.HakLabel.TabIndex = 1;
            this.HakLabel.Text = "Kalan Hakkınız: 5";
            this.HakLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MesajLabel
            // 
            this.MesajLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MesajLabel.Location = new System.Drawing.Point(3, 71);
            this.MesajLabel.Name = "MesajLabel";
            this.MesajLabel.Size = new System.Drawing.Size(213, 13);
            this.MesajLabel.TabIndex = 2;
            this.MesajLabel.Text = "Bakalım sayıyı bulabilecek misin?";
            this.MesajLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SonucLabel
            // 
            this.SonucLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SonucLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SonucLabel.ForeColor = System.Drawing.Color.Crimson;
            this.SonucLabel.Location = new System.Drawing.Point(6, 93);
            this.SonucLabel.Name = "SonucLabel";
            this.SonucLabel.Size = new System.Drawing.Size(210, 73);
            this.SonucLabel.TabIndex = 3;
            this.SonucLabel.Text = "8";
            this.SonucLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TahminKutu
            // 
            this.TahminKutu.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TahminKutu.Location = new System.Drawing.Point(6, 188);
            this.TahminKutu.MaxLength = 3;
            this.TahminKutu.Name = "TahminKutu";
            this.TahminKutu.Size = new System.Drawing.Size(104, 63);
            this.TahminKutu.TabIndex = 4;
            this.TahminKutu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TahminKutu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TahminKutu_KeyDown);
            // 
            // TahminButon
            // 
            this.TahminButon.Location = new System.Drawing.Point(116, 188);
            this.TahminButon.Name = "TahminButon";
            this.TahminButon.Size = new System.Drawing.Size(100, 25);
            this.TahminButon.TabIndex = 5;
            this.TahminButon.Text = "Tahmin Et";
            this.TahminButon.UseVisualStyleBackColor = true;
            this.TahminButon.Click += new System.EventHandler(this.TahminButon_Click);
            // 
            // ResetButon
            // 
            this.ResetButon.Location = new System.Drawing.Point(116, 226);
            this.ResetButon.Name = "ResetButon";
            this.ResetButon.Size = new System.Drawing.Size(100, 25);
            this.ResetButon.TabIndex = 6;
            this.ResetButon.Text = "Yeniden Başla";
            this.ResetButon.UseVisualStyleBackColor = true;
            this.ResetButon.Click += new System.EventHandler(this.ResetButon_Click);
            // 
            // Grup
            // 
            this.Grup.Controls.Add(this.TahminButon);
            this.Grup.Controls.Add(this.SonucLabel);
            this.Grup.Controls.Add(this.TahminKutu);
            this.Grup.Controls.Add(this.MesajLabel);
            this.Grup.Controls.Add(this.ResetButon);
            this.Grup.Controls.Add(this.HakLabel);
            this.Grup.Controls.Add(this.AralikLabel);
            this.Grup.Location = new System.Drawing.Point(12, 12);
            this.Grup.Name = "Grup";
            this.Grup.Size = new System.Drawing.Size(222, 259);
            this.Grup.TabIndex = 7;
            this.Grup.TabStop = false;
            // 
            // SuresizOyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 294);
            this.Controls.Add(this.Grup);
            this.Name = "SuresizOyun";
            this.Text = "Süresiz Oyun";
            this.Load += new System.EventHandler(this.SureliOyun_Load);
            this.Grup.ResumeLayout(false);
            this.Grup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label AralikLabel;
        private System.Windows.Forms.Label HakLabel;
        private System.Windows.Forms.Label MesajLabel;
        private System.Windows.Forms.Label SonucLabel;
        private System.Windows.Forms.TextBox TahminKutu;
        private System.Windows.Forms.Button TahminButon;
        private System.Windows.Forms.Button ResetButon;
        private System.Windows.Forms.GroupBox Grup;
    }
}