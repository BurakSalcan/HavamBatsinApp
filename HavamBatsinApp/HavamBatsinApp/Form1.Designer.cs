namespace HavamBatsinApp
{
    partial class Form1
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
            this.lbl_sicaklik = new System.Windows.Forms.Label();
            this.lbl_hissedilen = new System.Windows.Forms.Label();
            this.lbl_sehir = new System.Windows.Forms.Label();
            this.lbl_hava = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_sicaklik
            // 
            this.lbl_sicaklik.AutoSize = true;
            this.lbl_sicaklik.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sicaklik.ForeColor = System.Drawing.Color.White;
            this.lbl_sicaklik.Location = new System.Drawing.Point(38, 155);
            this.lbl_sicaklik.Name = "lbl_sicaklik";
            this.lbl_sicaklik.Size = new System.Drawing.Size(384, 95);
            this.lbl_sicaklik.TabIndex = 0;
            this.lbl_sicaklik.Text = "Sıcaklık: ";
            // 
            // lbl_hissedilen
            // 
            this.lbl_hissedilen.AutoSize = true;
            this.lbl_hissedilen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hissedilen.ForeColor = System.Drawing.Color.White;
            this.lbl_hissedilen.Location = new System.Drawing.Point(49, 250);
            this.lbl_hissedilen.Name = "lbl_hissedilen";
            this.lbl_hissedilen.Size = new System.Drawing.Size(157, 29);
            this.lbl_hissedilen.TabIndex = 1;
            this.lbl_hissedilen.Text = "Hissedilen: ";
            // 
            // lbl_sehir
            // 
            this.lbl_sehir.AutoSize = true;
            this.lbl_sehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sehir.ForeColor = System.Drawing.Color.White;
            this.lbl_sehir.Location = new System.Drawing.Point(46, 107);
            this.lbl_sehir.Name = "lbl_sehir";
            this.lbl_sehir.Size = new System.Drawing.Size(148, 48);
            this.lbl_sehir.TabIndex = 2;
            this.lbl_sehir.Text = "Şehir: ";
            // 
            // lbl_hava
            // 
            this.lbl_hava.AutoSize = true;
            this.lbl_hava.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hava.ForeColor = System.Drawing.Color.White;
            this.lbl_hava.Location = new System.Drawing.Point(49, 296);
            this.lbl_hava.Name = "lbl_hava";
            this.lbl_hava.Size = new System.Drawing.Size(196, 29);
            this.lbl_hava.TabIndex = 3;
            this.lbl_hava.Text = "Hava Durumu: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(486, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_hava);
            this.Controls.Add(this.lbl_sehir);
            this.Controls.Add(this.lbl_hissedilen);
            this.Controls.Add(this.lbl_sicaklik);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_sicaklik;
        private System.Windows.Forms.Label lbl_hissedilen;
        private System.Windows.Forms.Label lbl_sehir;
        private System.Windows.Forms.Label lbl_hava;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

