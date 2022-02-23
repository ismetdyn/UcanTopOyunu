
namespace Proje5._37UcanTopOyunu
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
            this.components = new System.ComponentModel.Container();
            this.lUst = new System.Windows.Forms.Label();
            this.lSol = new System.Windows.Forms.Label();
            this.lSag = new System.Windows.Forms.Label();
            this.btnTop = new System.Windows.Forms.Button();
            this.btnKontrolCubugu = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnBaslaDevamEt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lSure = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lKalanHak = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lKurtarmaSayisi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lUst
            // 
            this.lUst.BackColor = System.Drawing.Color.Black;
            this.lUst.Location = new System.Drawing.Point(92, 0);
            this.lUst.Name = "lUst";
            this.lUst.Size = new System.Drawing.Size(831, 46);
            this.lUst.TabIndex = 0;
            // 
            // lSol
            // 
            this.lSol.BackColor = System.Drawing.Color.Black;
            this.lSol.Location = new System.Drawing.Point(-5, 0);
            this.lSol.Name = "lSol";
            this.lSol.Size = new System.Drawing.Size(100, 686);
            this.lSol.TabIndex = 1;
            // 
            // lSag
            // 
            this.lSag.BackColor = System.Drawing.Color.Black;
            this.lSag.Location = new System.Drawing.Point(918, 0);
            this.lSag.Name = "lSag";
            this.lSag.Size = new System.Drawing.Size(100, 686);
            this.lSag.TabIndex = 2;
            // 
            // btnTop
            // 
            this.btnTop.BackColor = System.Drawing.Color.Red;
            this.btnTop.Location = new System.Drawing.Point(355, 302);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(15, 17);
            this.btnTop.TabIndex = 3;
            this.btnTop.UseVisualStyleBackColor = false;
            // 
            // btnKontrolCubugu
            // 
            this.btnKontrolCubugu.BackColor = System.Drawing.Color.Black;
            this.btnKontrolCubugu.Location = new System.Drawing.Point(384, 644);
            this.btnKontrolCubugu.Name = "btnKontrolCubugu";
            this.btnKontrolCubugu.Size = new System.Drawing.Size(116, 23);
            this.btnKontrolCubugu.TabIndex = 4;
            this.btnKontrolCubugu.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnBaslaDevamEt
            // 
            this.btnBaslaDevamEt.Location = new System.Drawing.Point(1048, 167);
            this.btnBaslaDevamEt.Name = "btnBaslaDevamEt";
            this.btnBaslaDevamEt.Size = new System.Drawing.Size(143, 27);
            this.btnBaslaDevamEt.TabIndex = 5;
            this.btnBaslaDevamEt.Text = "Başla/Devam Et";
            this.btnBaslaDevamEt.UseVisualStyleBackColor = true;
            this.btnBaslaDevamEt.Click += new System.EventHandler(this.btnBaslaDevamEt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1045, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Süre (sn):";
            // 
            // lSure
            // 
            this.lSure.AutoSize = true;
            this.lSure.Location = new System.Drawing.Point(1149, 30);
            this.lSure.Name = "lSure";
            this.lSure.Size = new System.Drawing.Size(14, 16);
            this.lSure.TabIndex = 7;
            this.lSure.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1045, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kalan Hakkınız:";
            // 
            // lKalanHak
            // 
            this.lKalanHak.AutoSize = true;
            this.lKalanHak.Location = new System.Drawing.Point(1149, 77);
            this.lKalanHak.Name = "lKalanHak";
            this.lKalanHak.Size = new System.Drawing.Size(14, 16);
            this.lKalanHak.TabIndex = 9;
            this.lKalanHak.Text = "4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1045, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kurtarma Sayısı:";
            // 
            // lKurtarmaSayisi
            // 
            this.lKurtarmaSayisi.AutoSize = true;
            this.lKurtarmaSayisi.Location = new System.Drawing.Point(1149, 121);
            this.lKurtarmaSayisi.Name = "lKurtarmaSayisi";
            this.lKurtarmaSayisi.Size = new System.Drawing.Size(14, 16);
            this.lKurtarmaSayisi.TabIndex = 11;
            this.lKurtarmaSayisi.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 679);
            this.Controls.Add(this.lKurtarmaSayisi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lKalanHak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lSure);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBaslaDevamEt);
            this.Controls.Add(this.btnKontrolCubugu);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.lSag);
            this.Controls.Add(this.lSol);
            this.Controls.Add(this.lUst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lUst;
        private System.Windows.Forms.Label lSol;
        private System.Windows.Forms.Label lSag;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.Button btnKontrolCubugu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnBaslaDevamEt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lSure;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lKalanHak;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lKurtarmaSayisi;
    }
}

