
namespace Diyet_Uygulamasi
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.diyetisyenTc = new System.Windows.Forms.TextBox();
            this.diyetisyenAd = new System.Windows.Forms.TextBox();
            this.diyetisyenSoy = new System.Windows.Forms.TextBox();
            this.diyetisyenSifre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(40, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(40, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(40, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(40, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şifre";
            // 
            // diyetisyenTc
            // 
            this.diyetisyenTc.Location = new System.Drawing.Point(134, 70);
            this.diyetisyenTc.Name = "diyetisyenTc";
            this.diyetisyenTc.Size = new System.Drawing.Size(127, 22);
            this.diyetisyenTc.TabIndex = 4;
            // 
            // diyetisyenAd
            // 
            this.diyetisyenAd.Location = new System.Drawing.Point(134, 113);
            this.diyetisyenAd.Name = "diyetisyenAd";
            this.diyetisyenAd.Size = new System.Drawing.Size(127, 22);
            this.diyetisyenAd.TabIndex = 5;
            // 
            // diyetisyenSoy
            // 
            this.diyetisyenSoy.Location = new System.Drawing.Point(134, 159);
            this.diyetisyenSoy.Name = "diyetisyenSoy";
            this.diyetisyenSoy.Size = new System.Drawing.Size(127, 22);
            this.diyetisyenSoy.TabIndex = 6;
            // 
            // diyetisyenSifre
            // 
            this.diyetisyenSifre.Location = new System.Drawing.Point(134, 206);
            this.diyetisyenSifre.Name = "diyetisyenSifre";
            this.diyetisyenSifre.Size = new System.Drawing.Size(127, 22);
            this.diyetisyenSifre.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 345);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.diyetisyenSifre);
            this.Controls.Add(this.diyetisyenSoy);
            this.Controls.Add(this.diyetisyenAd);
            this.Controls.Add(this.diyetisyenTc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Diyetisyen Ekle";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox diyetisyenTc;
        private System.Windows.Forms.TextBox diyetisyenSoy;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox diyetisyenAd;
        public System.Windows.Forms.TextBox diyetisyenSifre;
    }
}