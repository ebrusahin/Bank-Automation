namespace BankaOtomasyonu
{
    partial class FormYonetici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormYonetici));
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPersonelEkle = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPersonelEkleSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPersonelEkleKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPersonelEkleSoyadi = new System.Windows.Forms.TextBox();
            this.txtPersonelEkleAdi = new System.Windows.Forms.TextBox();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPersonelSil = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPersonelSilKulAdi = new System.Windows.Forms.TextBox();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridPersonelListele = new System.Windows.Forms.DataGridView();
            this.tabNavigationPage4 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.btnBankaIslemListele = new DevExpress.XtraEditors.SimpleButton();
            this.labelToplamPara = new System.Windows.Forms.Label();
            this.dataGridBankaIslemListele = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabNavigationPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonelListele)).BeginInit();
            this.tabNavigationPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBankaIslemListele)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Controls.Add(this.tabNavigationPage3);
            this.tabPane1.Controls.Add(this.tabNavigationPage4);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2,
            this.tabNavigationPage3,
            this.tabNavigationPage4});
            this.tabPane1.RegularSize = new System.Drawing.Size(800, 450);
            this.tabPane1.SelectedPage = this.tabNavigationPage2;
            this.tabPane1.Size = new System.Drawing.Size(800, 450);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Personel Ekle";
            this.tabNavigationPage1.Controls.Add(this.simpleButton1);
            this.tabNavigationPage1.Controls.Add(this.groupBox1);
            this.tabNavigationPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage1.ImageOptions.Image")));
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(800, 411);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(12, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(47, 30);
            this.simpleButton1.TabIndex = 12;
            this.simpleButton1.Click += new System.EventHandler(this.SimpleButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnPersonelEkle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPersonelEkleSifre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPersonelEkleKullaniciAdi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPersonelEkleSoyadi);
            this.groupBox1.Controls.Add(this.txtPersonelEkleAdi);
            this.groupBox1.Location = new System.Drawing.Point(176, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 271);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Bilgileri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(81, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyadı:";
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonelEkle.ImageOptions.Image")));
            this.btnPersonelEkle.Location = new System.Drawing.Point(234, 218);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(93, 36);
            this.btnPersonelEkle.TabIndex = 9;
            this.btnPersonelEkle.Text = "Ekle";
            this.btnPersonelEkle.Click += new System.EventHandler(this.BtnPersonelEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(81, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adı:";
            // 
            // txtPersonelEkleSifre
            // 
            this.txtPersonelEkleSifre.Location = new System.Drawing.Point(207, 169);
            this.txtPersonelEkleSifre.Name = "txtPersonelEkleSifre";
            this.txtPersonelEkleSifre.Size = new System.Drawing.Size(120, 20);
            this.txtPersonelEkleSifre.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(81, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kullanıcı Adı:";
            // 
            // txtPersonelEkleKullaniciAdi
            // 
            this.txtPersonelEkleKullaniciAdi.Location = new System.Drawing.Point(207, 125);
            this.txtPersonelEkleKullaniciAdi.Name = "txtPersonelEkleKullaniciAdi";
            this.txtPersonelEkleKullaniciAdi.Size = new System.Drawing.Size(120, 20);
            this.txtPersonelEkleKullaniciAdi.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(81, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Şifre:";
            // 
            // txtPersonelEkleSoyadi
            // 
            this.txtPersonelEkleSoyadi.Location = new System.Drawing.Point(207, 79);
            this.txtPersonelEkleSoyadi.Name = "txtPersonelEkleSoyadi";
            this.txtPersonelEkleSoyadi.Size = new System.Drawing.Size(120, 20);
            this.txtPersonelEkleSoyadi.TabIndex = 6;
            // 
            // txtPersonelEkleAdi
            // 
            this.txtPersonelEkleAdi.Location = new System.Drawing.Point(207, 38);
            this.txtPersonelEkleAdi.Name = "txtPersonelEkleAdi";
            this.txtPersonelEkleAdi.Size = new System.Drawing.Size(120, 20);
            this.txtPersonelEkleAdi.TabIndex = 5;
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Personel Çıkar";
            this.tabNavigationPage2.Controls.Add(this.simpleButton2);
            this.tabNavigationPage2.Controls.Add(this.groupBox2);
            this.tabNavigationPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage2.ImageOptions.Image")));
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(800, 411);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(12, 3);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(47, 30);
            this.simpleButton2.TabIndex = 13;
            this.simpleButton2.Click += new System.EventHandler(this.SimpleButton2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPersonelSil);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtPersonelSilKulAdi);
            this.groupBox2.Location = new System.Drawing.Point(176, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 185);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personel Bilgileri";
            // 
            // btnPersonelSil
            // 
            this.btnPersonelSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonelSil.ImageOptions.Image")));
            this.btnPersonelSil.Location = new System.Drawing.Point(234, 98);
            this.btnPersonelSil.Name = "btnPersonelSil";
            this.btnPersonelSil.Size = new System.Drawing.Size(93, 36);
            this.btnPersonelSil.TabIndex = 9;
            this.btnPersonelSil.Text = "Çıkar";
            this.btnPersonelSil.Click += new System.EventHandler(this.BtnPersonelSil_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(81, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Kullanıcı Adı:";
            // 
            // txtPersonelSilKulAdi
            // 
            this.txtPersonelSilKulAdi.Location = new System.Drawing.Point(207, 38);
            this.txtPersonelSilKulAdi.Name = "txtPersonelSilKulAdi";
            this.txtPersonelSilKulAdi.Size = new System.Drawing.Size(120, 20);
            this.txtPersonelSilKulAdi.TabIndex = 5;
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Caption = "Personel Listele";
            this.tabNavigationPage3.Controls.Add(this.simpleButton3);
            this.tabNavigationPage3.Controls.Add(this.dataGridPersonelListele);
            this.tabNavigationPage3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage3.ImageOptions.Image")));
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Size = new System.Drawing.Size(800, 411);
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(12, 14);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(47, 30);
            this.simpleButton3.TabIndex = 13;
            this.simpleButton3.Click += new System.EventHandler(this.SimpleButton3_Click);
            // 
            // dataGridPersonelListele
            // 
            this.dataGridPersonelListele.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPersonelListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPersonelListele.Location = new System.Drawing.Point(12, 50);
            this.dataGridPersonelListele.Name = "dataGridPersonelListele";
            this.dataGridPersonelListele.Size = new System.Drawing.Size(776, 345);
            this.dataGridPersonelListele.TabIndex = 0;
            // 
            // tabNavigationPage4
            // 
            this.tabNavigationPage4.Caption = "Banka İşlem Listesi";
            this.tabNavigationPage4.Controls.Add(this.simpleButton4);
            this.tabNavigationPage4.Controls.Add(this.btnBankaIslemListele);
            this.tabNavigationPage4.Controls.Add(this.labelToplamPara);
            this.tabNavigationPage4.Controls.Add(this.dataGridBankaIslemListele);
            this.tabNavigationPage4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage4.ImageOptions.Image")));
            this.tabNavigationPage4.Name = "tabNavigationPage4";
            this.tabNavigationPage4.Size = new System.Drawing.Size(800, 411);
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(12, 9);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(47, 30);
            this.simpleButton4.TabIndex = 13;
            this.simpleButton4.Click += new System.EventHandler(this.SimpleButton4_Click);
            // 
            // btnBankaIslemListele
            // 
            this.btnBankaIslemListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBankaIslemListele.ImageOptions.Image")));
            this.btnBankaIslemListele.Location = new System.Drawing.Point(197, 9);
            this.btnBankaIslemListele.Name = "btnBankaIslemListele";
            this.btnBankaIslemListele.Size = new System.Drawing.Size(88, 37);
            this.btnBankaIslemListele.TabIndex = 3;
            this.btnBankaIslemListele.Text = "Listele:";
            this.btnBankaIslemListele.Click += new System.EventHandler(this.BtnBankaIslemListele_Click);
            // 
            // labelToplamPara
            // 
            this.labelToplamPara.AutoSize = true;
            this.labelToplamPara.Location = new System.Drawing.Point(333, 21);
            this.labelToplamPara.Name = "labelToplamPara";
            this.labelToplamPara.Size = new System.Drawing.Size(123, 13);
            this.labelToplamPara.TabIndex = 2;
            this.labelToplamPara.Text = "Banka Toplam Para: -TL";
            // 
            // dataGridBankaIslemListele
            // 
            this.dataGridBankaIslemListele.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridBankaIslemListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBankaIslemListele.Location = new System.Drawing.Point(12, 52);
            this.dataGridBankaIslemListele.Name = "dataGridBankaIslemListele";
            this.dataGridBankaIslemListele.Size = new System.Drawing.Size(776, 306);
            this.dataGridBankaIslemListele.TabIndex = 1;
            // 
            // FormYonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabPane1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormYonetici";
            this.Text = "FormYonetici";
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabNavigationPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabNavigationPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonelListele)).EndInit();
            this.tabNavigationPage4.ResumeLayout(false);
            this.tabNavigationPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBankaIslemListele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnPersonelEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPersonelEkleSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPersonelEkleKullaniciAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPersonelEkleSoyadi;
        private System.Windows.Forms.TextBox txtPersonelEkleAdi;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btnPersonelSil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPersonelSilKulAdi;
        private System.Windows.Forms.DataGridView dataGridPersonelListele;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton btnBankaIslemListele;
        private System.Windows.Forms.Label labelToplamPara;
        private System.Windows.Forms.DataGridView dataGridBankaIslemListele;
    }
}