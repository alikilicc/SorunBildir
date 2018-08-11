namespace SorunBildir
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ButonBilgiEkle = new System.Windows.Forms.Button();
            this.textbEtkiAlani = new System.Windows.Forms.TextBox();
            this.textbMac = new System.Windows.Forms.TextBox();
            this.textbIP = new System.Windows.Forms.TextBox();
            this.textbGateway = new System.Windows.Forms.TextBox();
            this.textbBilAdi = new System.Windows.Forms.TextBox();
            this.textbKullAdi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.butonGonder = new System.Windows.Forms.Button();
            this.textbSoruNe = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(53, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sorun Bildirme Formu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SorunBildir.Properties.Resources.askk;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(27, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 65);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(156, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "SORUN BİLDİRME FORMU";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox2.Controls.Add(this.ButonBilgiEkle);
            this.groupBox2.Controls.Add(this.textbEtkiAlani);
            this.groupBox2.Controls.Add(this.textbMac);
            this.groupBox2.Controls.Add(this.textbIP);
            this.groupBox2.Controls.Add(this.textbGateway);
            this.groupBox2.Controls.Add(this.textbBilAdi);
            this.groupBox2.Controls.Add(this.textbKullAdi);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(53, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(662, 198);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bilgilerinizi girin";
            // 
            // ButonBilgiEkle
            // 
            this.ButonBilgiEkle.BackColor = System.Drawing.Color.Turquoise;
            this.ButonBilgiEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButonBilgiEkle.Location = new System.Drawing.Point(256, 169);
            this.ButonBilgiEkle.Name = "ButonBilgiEkle";
            this.ButonBilgiEkle.Size = new System.Drawing.Size(111, 23);
            this.ButonBilgiEkle.TabIndex = 12;
            this.ButonBilgiEkle.Text = "Bilgileri Ekle";
            this.ButonBilgiEkle.UseVisualStyleBackColor = false;
            this.ButonBilgiEkle.Click += new System.EventHandler(this.ButonBilgiEkle_Click);
            // 
            // textbEtkiAlani
            // 
            this.textbEtkiAlani.Location = new System.Drawing.Point(439, 119);
            this.textbEtkiAlani.Name = "textbEtkiAlani";
            this.textbEtkiAlani.Size = new System.Drawing.Size(100, 20);
            this.textbEtkiAlani.TabIndex = 11;
            // 
            // textbMac
            // 
            this.textbMac.Location = new System.Drawing.Point(440, 73);
            this.textbMac.Name = "textbMac";
            this.textbMac.Size = new System.Drawing.Size(100, 20);
            this.textbMac.TabIndex = 10;
            // 
            // textbIP
            // 
            this.textbIP.Location = new System.Drawing.Point(439, 26);
            this.textbIP.Name = "textbIP";
            this.textbIP.Size = new System.Drawing.Size(100, 20);
            this.textbIP.TabIndex = 9;
            // 
            // textbGateway
            // 
            this.textbGateway.Location = new System.Drawing.Point(162, 120);
            this.textbGateway.Name = "textbGateway";
            this.textbGateway.Size = new System.Drawing.Size(100, 20);
            this.textbGateway.TabIndex = 8;
            // 
            // textbBilAdi
            // 
            this.textbBilAdi.Location = new System.Drawing.Point(162, 74);
            this.textbBilAdi.Name = "textbBilAdi";
            this.textbBilAdi.Size = new System.Drawing.Size(100, 20);
            this.textbBilAdi.TabIndex = 7;
            // 
            // textbKullAdi
            // 
            this.textbKullAdi.Location = new System.Drawing.Point(162, 30);
            this.textbKullAdi.Name = "textbKullAdi";
            this.textbKullAdi.Size = new System.Drawing.Size(100, 20);
            this.textbKullAdi.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(362, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Etki Alanı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mac Adresi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "IP Adresi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Gateway Adresi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Bilgisayar Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox3.Controls.Add(this.butonGonder);
            this.groupBox3.Controls.Add(this.textbSoruNe);
            this.groupBox3.Location = new System.Drawing.Point(53, 332);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(662, 106);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sorun Nedir";
            // 
            // butonGonder
            // 
            this.butonGonder.BackColor = System.Drawing.Color.Turquoise;
            this.butonGonder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butonGonder.Location = new System.Drawing.Point(558, 19);
            this.butonGonder.Name = "butonGonder";
            this.butonGonder.Size = new System.Drawing.Size(86, 80);
            this.butonGonder.TabIndex = 1;
            this.butonGonder.Text = "Gönder";
            this.butonGonder.UseVisualStyleBackColor = false;
            this.butonGonder.Click += new System.EventHandler(this.butonGonder_Click);
            // 
            // textbSoruNe
            // 
            this.textbSoruNe.Location = new System.Drawing.Point(27, 19);
            this.textbSoruNe.Multiline = true;
            this.textbSoruNe.Name = "textbSoruNe";
            this.textbSoruNe.Size = new System.Drawing.Size(513, 80);
            this.textbSoruNe.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(721, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ButonBilgiEkle;
        private System.Windows.Forms.TextBox textbEtkiAlani;
        private System.Windows.Forms.TextBox textbMac;
        private System.Windows.Forms.TextBox textbIP;
        private System.Windows.Forms.TextBox textbGateway;
        private System.Windows.Forms.TextBox textbBilAdi;
        private System.Windows.Forms.TextBox textbKullAdi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button butonGonder;
        private System.Windows.Forms.TextBox textbSoruNe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

