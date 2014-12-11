namespace Oyunlar
{
    partial class SuresizOyunPD
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
            this.Liste = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.SifirlaButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Liste
            // 
            this.Liste.Location = new System.Drawing.Point(12, 32);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(224, 210);
            this.Liste.TabIndex = 0;
            this.Liste.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Süresiz Oyunda En İyi 10 Puan";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SifirlaButon
            // 
            this.SifirlaButon.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SifirlaButon.Location = new System.Drawing.Point(12, 248);
            this.SifirlaButon.Name = "SifirlaButon";
            this.SifirlaButon.Size = new System.Drawing.Size(224, 38);
            this.SifirlaButon.TabIndex = 2;
            this.SifirlaButon.Text = "Puanları Sıfırla";
            this.SifirlaButon.UseVisualStyleBackColor = true;
            this.SifirlaButon.Click += new System.EventHandler(this.SifirlaButon_Click);
            // 
            // SuresizOyunPD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 294);
            this.Controls.Add(this.SifirlaButon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Liste);
            this.Name = "SuresizOyunPD";
            this.Text = "Puan Durumu";
            this.Load += new System.EventHandler(this.SuresizOyunPD_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView Liste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SifirlaButon;



    }
}