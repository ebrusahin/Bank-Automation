namespace BankaOtomasyonu
{
    partial class FormGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt1KullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMusteriGiris = new DevExpress.XtraEditors.SimpleButton();
            this.btnPersonelGiris = new DevExpress.XtraEditors.SimpleButton();
            this.btnYonetici = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(48, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı/ Müşteri No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(48, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // txt1KullaniciAdi
            // 
            this.txt1KullaniciAdi.Location = new System.Drawing.Point(250, 44);
            this.txt1KullaniciAdi.Name = "txt1KullaniciAdi";
            this.txt1KullaniciAdi.Size = new System.Drawing.Size(120, 21);
            this.txt1KullaniciAdi.TabIndex = 2;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(250, 94);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(120, 21);
            this.txtSifre.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSifre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt1KullaniciAdi);
            this.groupBox1.Location = new System.Drawing.Point(168, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 171);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş Bilgileri";
            // 
            // btnMusteriGiris
            // 
            this.btnMusteriGiris.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriGiris.ImageOptions.Image")));
            this.btnMusteriGiris.Location = new System.Drawing.Point(47, 33);
            this.btnMusteriGiris.Name = "btnMusteriGiris";
            this.btnMusteriGiris.Size = new System.Drawing.Size(106, 46);
            this.btnMusteriGiris.TabIndex = 5;
            this.btnMusteriGiris.Text = "Müşteri Girişi";
            this.btnMusteriGiris.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            this.btnMusteriGiris.Click += new System.EventHandler(this.BtnMusteriGiris_Click);
            // 
            // btnPersonelGiris
            // 
            this.btnPersonelGiris.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonelGiris.ImageOptions.Image")));
            this.btnPersonelGiris.Location = new System.Drawing.Point(199, 33);
            this.btnPersonelGiris.Name = "btnPersonelGiris";
            this.btnPersonelGiris.Size = new System.Drawing.Size(106, 46);
            this.btnPersonelGiris.TabIndex = 6;
            this.btnPersonelGiris.Text = "Personel Girişi";
            this.btnPersonelGiris.Click += new System.EventHandler(this.BtnPersonelGiris_Click);
            // 
            // btnYonetici
            // 
            this.btnYonetici.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYonetici.ImageOptions.Image")));
            this.btnYonetici.Location = new System.Drawing.Point(358, 33);
            this.btnYonetici.Name = "btnYonetici";
            this.btnYonetici.Size = new System.Drawing.Size(106, 46);
            this.btnYonetici.TabIndex = 7;
            this.btnYonetici.Text = "Yönetici Girişi";
            this.btnYonetici.Click += new System.EventHandler(this.BtnYonetici_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMusteriGiris);
            this.groupBox2.Controls.Add(this.btnYonetici);
            this.groupBox2.Controls.Add(this.btnPersonelGiris);
            this.groupBox2.Location = new System.Drawing.Point(168, 323);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(525, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giriş";
            // 
            // FormGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGiris";
            this.Text = "FormGiris";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt1KullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnMusteriGiris;
        private DevExpress.XtraEditors.SimpleButton btnPersonelGiris;
        private DevExpress.XtraEditors.SimpleButton btnYonetici;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}