namespace BankaOtomasyonu
{
    partial class FormMusteri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMusteri));
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnParaCek = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCekMiktar = new System.Windows.Forms.TextBox();
            this.txtCekHesapNo = new System.Windows.Forms.TextBox();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnParaYatir = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtYatirMiktar = new System.Windows.Forms.TextBox();
            this.txtYatirHesapNo = new System.Windows.Forms.TextBox();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHavaleGonder = new DevExpress.XtraEditors.SimpleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHavaleMiktar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKaynakNo = new System.Windows.Forms.TextBox();
            this.txtHavaleNo = new System.Windows.Forms.TextBox();
            this.tabNavigationPage4 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.timePickerBitis = new System.Windows.Forms.DateTimePicker();
            this.timePickerBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dataGridHesapOzeti = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOzetHesapNo = new System.Windows.Forms.TextBox();
            this.tabNavigationPage5 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridHesaplarim = new System.Windows.Forms.DataGridView();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabNavigationPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabNavigationPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHesapOzeti)).BeginInit();
            this.tabNavigationPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHesaplarim)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Controls.Add(this.tabNavigationPage3);
            this.tabPane1.Controls.Add(this.tabNavigationPage4);
            this.tabPane1.Controls.Add(this.tabNavigationPage5);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2,
            this.tabNavigationPage3,
            this.tabNavigationPage4,
            this.tabNavigationPage5});
            this.tabPane1.RegularSize = new System.Drawing.Size(728, 380);
            this.tabPane1.SelectedPage = this.tabNavigationPage2;
            this.tabPane1.Size = new System.Drawing.Size(728, 380);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Para Çekme";
            this.tabNavigationPage1.Controls.Add(this.simpleButton4);
            this.tabNavigationPage1.Controls.Add(this.groupBox1);
            this.tabNavigationPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage1.ImageOptions.Image")));
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(728, 341);
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(12, 13);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(47, 30);
            this.simpleButton4.TabIndex = 15;
            this.simpleButton4.Click += new System.EventHandler(this.SimpleButton4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnParaCek);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCekMiktar);
            this.groupBox1.Controls.Add(this.txtCekHesapNo);
            this.groupBox1.Location = new System.Drawing.Point(128, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 256);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hesap Bilgileri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Günlük Para Çekme Limiti 750 TL\'dir.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(69, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hesap Numarası:";
            // 
            // btnParaCek
            // 
            this.btnParaCek.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnParaCek.ImageOptions.Image")));
            this.btnParaCek.Location = new System.Drawing.Point(277, 195);
            this.btnParaCek.Name = "btnParaCek";
            this.btnParaCek.Size = new System.Drawing.Size(84, 43);
            this.btnParaCek.TabIndex = 4;
            this.btnParaCek.Text = "Çek";
            this.btnParaCek.Click += new System.EventHandler(this.BtnParaCek_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(69, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Miktar:";
            // 
            // txtCekMiktar
            // 
            this.txtCekMiktar.Location = new System.Drawing.Point(201, 145);
            this.txtCekMiktar.Name = "txtCekMiktar";
            this.txtCekMiktar.Size = new System.Drawing.Size(160, 20);
            this.txtCekMiktar.TabIndex = 3;
            // 
            // txtCekHesapNo
            // 
            this.txtCekHesapNo.Location = new System.Drawing.Point(201, 85);
            this.txtCekHesapNo.Name = "txtCekHesapNo";
            this.txtCekHesapNo.Size = new System.Drawing.Size(160, 20);
            this.txtCekHesapNo.TabIndex = 2;
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Para Yatır";
            this.tabNavigationPage2.Controls.Add(this.simpleButton3);
            this.tabNavigationPage2.Controls.Add(this.groupBox2);
            this.tabNavigationPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage2.ImageOptions.Image")));
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(728, 341);
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(12, 13);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(47, 30);
            this.simpleButton3.TabIndex = 15;
            this.simpleButton3.Click += new System.EventHandler(this.SimpleButton3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnParaYatir);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtYatirMiktar);
            this.groupBox2.Controls.Add(this.txtYatirHesapNo);
            this.groupBox2.Location = new System.Drawing.Point(134, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 256);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hesap Bilgileri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(68, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Hesap Numarası:";
            // 
            // btnParaYatir
            // 
            this.btnParaYatir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnParaYatir.ImageOptions.Image")));
            this.btnParaYatir.Location = new System.Drawing.Point(276, 161);
            this.btnParaYatir.Name = "btnParaYatir";
            this.btnParaYatir.Size = new System.Drawing.Size(84, 43);
            this.btnParaYatir.TabIndex = 4;
            this.btnParaYatir.Text = "Yatir";
            this.btnParaYatir.Click += new System.EventHandler(this.BtnParaYatir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(68, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Miktar:";
            // 
            // txtYatirMiktar
            // 
            this.txtYatirMiktar.Location = new System.Drawing.Point(200, 111);
            this.txtYatirMiktar.Name = "txtYatirMiktar";
            this.txtYatirMiktar.Size = new System.Drawing.Size(160, 20);
            this.txtYatirMiktar.TabIndex = 3;
            // 
            // txtYatirHesapNo
            // 
            this.txtYatirHesapNo.Location = new System.Drawing.Point(200, 51);
            this.txtYatirHesapNo.Name = "txtYatirHesapNo";
            this.txtYatirHesapNo.Size = new System.Drawing.Size(160, 20);
            this.txtYatirHesapNo.TabIndex = 2;
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Caption = "Hesaba Havale";
            this.tabNavigationPage3.Controls.Add(this.simpleButton5);
            this.tabNavigationPage3.Controls.Add(this.groupBox3);
            this.tabNavigationPage3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage3.ImageOptions.Image")));
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Size = new System.Drawing.Size(728, 341);
            // 
            // simpleButton5
            // 
            this.simpleButton5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.simpleButton5.Location = new System.Drawing.Point(12, 14);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(47, 30);
            this.simpleButton5.TabIndex = 15;
            this.simpleButton5.Click += new System.EventHandler(this.SimpleButton5_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnHavaleGonder);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtHavaleMiktar);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtKaynakNo);
            this.groupBox3.Controls.Add(this.txtHavaleNo);
            this.groupBox3.Location = new System.Drawing.Point(67, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(593, 255);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(58, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Havale Yapılacak Hesap Numarası:";
            // 
            // btnHavaleGonder
            // 
            this.btnHavaleGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHavaleGonder.ImageOptions.Image")));
            this.btnHavaleGonder.Location = new System.Drawing.Point(423, 196);
            this.btnHavaleGonder.Name = "btnHavaleGonder";
            this.btnHavaleGonder.Size = new System.Drawing.Size(86, 34);
            this.btnHavaleGonder.TabIndex = 7;
            this.btnHavaleGonder.Text = "Gönder";
            this.btnHavaleGonder.Click += new System.EventHandler(this.BtnHavaleGonder_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(58, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Kaynak Hesap Numarası:";
            // 
            // txtHavaleMiktar
            // 
            this.txtHavaleMiktar.Location = new System.Drawing.Point(306, 149);
            this.txtHavaleMiktar.Name = "txtHavaleMiktar";
            this.txtHavaleMiktar.Size = new System.Drawing.Size(203, 20);
            this.txtHavaleMiktar.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(-54, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Miktar:";
            // 
            // txtKaynakNo
            // 
            this.txtKaynakNo.Location = new System.Drawing.Point(306, 98);
            this.txtKaynakNo.Name = "txtKaynakNo";
            this.txtKaynakNo.Size = new System.Drawing.Size(203, 20);
            this.txtKaynakNo.TabIndex = 5;
            // 
            // txtHavaleNo
            // 
            this.txtHavaleNo.Location = new System.Drawing.Point(306, 54);
            this.txtHavaleNo.Name = "txtHavaleNo";
            this.txtHavaleNo.Size = new System.Drawing.Size(203, 20);
            this.txtHavaleNo.TabIndex = 4;
            // 
            // tabNavigationPage4
            // 
            this.tabNavigationPage4.Caption = "Hesap Özeti";
            this.tabNavigationPage4.Controls.Add(this.simpleButton6);
            this.tabNavigationPage4.Controls.Add(this.simpleButton1);
            this.tabNavigationPage4.Controls.Add(this.timePickerBitis);
            this.tabNavigationPage4.Controls.Add(this.timePickerBaslangic);
            this.tabNavigationPage4.Controls.Add(this.dataGridHesapOzeti);
            this.tabNavigationPage4.Controls.Add(this.label9);
            this.tabNavigationPage4.Controls.Add(this.txtOzetHesapNo);
            this.tabNavigationPage4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage4.ImageOptions.Image")));
            this.tabNavigationPage4.Name = "tabNavigationPage4";
            this.tabNavigationPage4.Size = new System.Drawing.Size(728, 341);
            this.tabNavigationPage4.Paint += new System.Windows.Forms.PaintEventHandler(this.TabNavigationPage4_Paint);
            // 
            // simpleButton6
            // 
            this.simpleButton6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton6.ImageOptions.Image")));
            this.simpleButton6.Location = new System.Drawing.Point(12, 3);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(47, 30);
            this.simpleButton6.TabIndex = 15;
            this.simpleButton6.Click += new System.EventHandler(this.SimpleButton6_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(574, 29);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(93, 35);
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "Listele";
            this.simpleButton1.Click += new System.EventHandler(this.SimpleButton1_Click);
            // 
            // timePickerBitis
            // 
            this.timePickerBitis.Location = new System.Drawing.Point(344, 52);
            this.timePickerBitis.Name = "timePickerBitis";
            this.timePickerBitis.Size = new System.Drawing.Size(200, 20);
            this.timePickerBitis.TabIndex = 9;
            // 
            // timePickerBaslangic
            // 
            this.timePickerBaslangic.Location = new System.Drawing.Point(344, 26);
            this.timePickerBaslangic.Name = "timePickerBaslangic";
            this.timePickerBaslangic.Size = new System.Drawing.Size(200, 20);
            this.timePickerBaslangic.TabIndex = 8;
            // 
            // dataGridHesapOzeti
            // 
            this.dataGridHesapOzeti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridHesapOzeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHesapOzeti.Location = new System.Drawing.Point(12, 97);
            this.dataGridHesapOzeti.Name = "dataGridHesapOzeti";
            this.dataGridHesapOzeti.Size = new System.Drawing.Size(704, 228);
            this.dataGridHesapOzeti.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(12, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "Hesap Numarası:";
            // 
            // txtOzetHesapNo
            // 
            this.txtOzetHesapNo.Location = new System.Drawing.Point(143, 44);
            this.txtOzetHesapNo.Name = "txtOzetHesapNo";
            this.txtOzetHesapNo.Size = new System.Drawing.Size(175, 20);
            this.txtOzetHesapNo.TabIndex = 6;
            // 
            // tabNavigationPage5
            // 
            this.tabNavigationPage5.Caption = "Hesaplarım";
            this.tabNavigationPage5.Controls.Add(this.simpleButton7);
            this.tabNavigationPage5.Controls.Add(this.dataGridHesaplarim);
            this.tabNavigationPage5.Controls.Add(this.simpleButton2);
            this.tabNavigationPage5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage5.ImageOptions.Image")));
            this.tabNavigationPage5.Name = "tabNavigationPage5";
            this.tabNavigationPage5.Size = new System.Drawing.Size(728, 341);
            // 
            // simpleButton7
            // 
            this.simpleButton7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton7.ImageOptions.Image")));
            this.simpleButton7.Location = new System.Drawing.Point(12, 0);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(47, 30);
            this.simpleButton7.TabIndex = 15;
            this.simpleButton7.Click += new System.EventHandler(this.SimpleButton7_Click);
            // 
            // dataGridHesaplarim
            // 
            this.dataGridHesaplarim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridHesaplarim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHesaplarim.Location = new System.Drawing.Point(12, 44);
            this.dataGridHesaplarim.Name = "dataGridHesaplarim";
            this.dataGridHesaplarim.Size = new System.Drawing.Size(704, 281);
            this.dataGridHesaplarim.TabIndex = 12;
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(65, 3);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(130, 35);
            this.simpleButton2.TabIndex = 11;
            this.simpleButton2.Text = "Listele";
            this.simpleButton2.Click += new System.EventHandler(this.SimpleButton2_Click);
            // 
            // FormMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 380);
            this.Controls.Add(this.tabPane1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMusteri";
            this.Text = "FormMusteri";
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabNavigationPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabNavigationPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabNavigationPage4.ResumeLayout(false);
            this.tabNavigationPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHesapOzeti)).EndInit();
            this.tabNavigationPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHesaplarim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage4;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnParaCek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCekMiktar;
        private System.Windows.Forms.TextBox txtCekHesapNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton btnParaYatir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtYatirMiktar;
        private System.Windows.Forms.TextBox txtYatirHesapNo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btnHavaleGonder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHavaleMiktar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKaynakNo;
        private System.Windows.Forms.TextBox txtHavaleNo;
        private System.Windows.Forms.DataGridView dataGridHesapOzeti;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOzetHesapNo;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.DateTimePicker timePickerBitis;
        private System.Windows.Forms.DateTimePicker timePickerBaslangic;
        private System.Windows.Forms.DataGridView dataGridHesaplarim;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
    }
}