namespace SorunBildir
{
    partial class SorunGoster
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnSiraNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnOtelAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnKullanıciAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSorun = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.butonSil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.butonSil);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1362, 721);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bidirilen Sorunlar";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.Color.PowderBlue;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnSiraNo,
            this.columnOtelAdi,
            this.columnKullanıciAdi,
            this.columnSorun});
            this.listView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.listView1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(5)), true);
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(6, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1210, 464);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnSiraNo
            // 
            this.columnSiraNo.Text = "Sıra No";
            this.columnSiraNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnSiraNo.Width = 85;
            // 
            // columnOtelAdi
            // 
            this.columnOtelAdi.Text = "İşletme Adı";
            this.columnOtelAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnOtelAdi.Width = 139;
            // 
            // columnKullanıciAdi
            // 
            this.columnKullanıciAdi.Text = "Kullanıcı Adı";
            this.columnKullanıciAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnKullanıciAdi.Width = 289;
            // 
            // columnSorun
            // 
            this.columnSorun.Text = "Sorunun Açıklaması";
            this.columnSorun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnSorun.Width = 409;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // butonSil
            // 
            this.butonSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butonSil.Location = new System.Drawing.Point(48, 489);
            this.butonSil.Name = "butonSil";
            this.butonSil.Size = new System.Drawing.Size(67, 42);
            this.butonSil.TabIndex = 1;
            this.butonSil.Text = "Şeçilenleri Sil";
            this.butonSil.UseVisualStyleBackColor = true;
            this.butonSil.Click += new System.EventHandler(this.butonSil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SorunBildir.Properties.Resources.delete;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(6, 489);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 42);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SorunGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 721);
            this.Controls.Add(this.groupBox1);
            this.Name = "SorunGoster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SorunGoster";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
       public System.Windows.Forms.ColumnHeader columnOtelAdi;
        private System.Windows.Forms.ColumnHeader columnSorun;
        private System.Windows.Forms.ColumnHeader columnKullanıciAdi;
        private System.Windows.Forms.ColumnHeader columnSiraNo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button butonSil;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}