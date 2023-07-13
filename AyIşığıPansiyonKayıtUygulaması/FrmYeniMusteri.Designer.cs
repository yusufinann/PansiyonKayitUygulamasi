namespace AyIşığıPansiyonKayıtUygulaması
{
    partial class FrmYeniMusteri
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
            label1 = new Label();
            TxtAdi = new TextBox();
            label2 = new Label();
            TxtSoyadi = new TextBox();
            label3 = new Label();
            TxtOdaNo = new TextBox();
            TxtKimlikNo = new TextBox();
            TxtMail = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            TxtUcret = new TextBox();
            label8 = new Label();
            label9 = new Label();
            DtpGirisTarihi = new DateTimePicker();
            DtpCikisTarihi = new DateTimePicker();
            label10 = new Label();
            comboBox1 = new ComboBox();
            MskTxtBoxTelefon = new MaskedTextBox();
            BtnKaydet = new Button();
            BtnOda101 = new Button();
            BtnOda104 = new Button();
            BtnOda105 = new Button();
            BtnOda103 = new Button();
            BtnOda102 = new Button();
            BtnOda107 = new Button();
            BtnOda108 = new Button();
            BtnOda106 = new Button();
            BtnOda109 = new Button();
            button2 = new Button();
            button1 = new Button();
            label11 = new Label();
            button3 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 26);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // TxtAdi
            // 
            TxtAdi.Location = new Point(102, 19);
            TxtAdi.Name = "TxtAdi";
            TxtAdi.Size = new Size(204, 27);
            TxtAdi.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 67);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 2;
            label2.Text = "Soyadı:";
            // 
            // TxtSoyadi
            // 
            TxtSoyadi.Location = new Point(102, 60);
            TxtSoyadi.Name = "TxtSoyadi";
            TxtSoyadi.Size = new Size(204, 27);
            TxtSoyadi.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 105);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 4;
            label3.Text = "Cinsiyet:";
            // 
            // TxtOdaNo
            // 
            TxtOdaNo.Enabled = false;
            TxtOdaNo.Location = new Point(102, 266);
            TxtOdaNo.Name = "TxtOdaNo";
            TxtOdaNo.Size = new Size(204, 27);
            TxtOdaNo.TabIndex = 5;
            // 
            // TxtKimlikNo
            // 
            TxtKimlikNo.Location = new Point(102, 224);
            TxtKimlikNo.MaxLength = 11;
            TxtKimlikNo.Name = "TxtKimlikNo";
            TxtKimlikNo.Size = new Size(204, 27);
            TxtKimlikNo.TabIndex = 6;
            // 
            // TxtMail
            // 
            TxtMail.Location = new Point(102, 181);
            TxtMail.Name = "TxtMail";
            TxtMail.Size = new Size(204, 27);
            TxtMail.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1, 231);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 9;
            label4.Text = "Tc Kimlik No:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 273);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 10;
            label5.Text = "Oda No:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 188);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 11;
            label6.Text = "Mail:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(52, 322);
            label7.Name = "label7";
            label7.Size = new Size(47, 20);
            label7.TabIndex = 12;
            label7.Text = "Ucret:";
            // 
            // TxtUcret
            // 
            TxtUcret.Location = new Point(102, 319);
            TxtUcret.Name = "TxtUcret";
            TxtUcret.Size = new Size(204, 27);
            TxtUcret.TabIndex = 15;
            TxtUcret.TextChanged += TxtUcret_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 371);
            label8.Name = "label8";
            label8.Size = new Size(80, 20);
            label8.TabIndex = 16;
            label8.Text = "Giriş Tarihi:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 417);
            label9.Name = "label9";
            label9.Size = new Size(81, 20);
            label9.TabIndex = 17;
            label9.Text = "Çıkış Tarihi:";
            // 
            // DtpGirisTarihi
            // 
            DtpGirisTarihi.Location = new Point(102, 366);
            DtpGirisTarihi.Name = "DtpGirisTarihi";
            DtpGirisTarihi.Size = new Size(204, 27);
            DtpGirisTarihi.TabIndex = 18;
            // 
            // DtpCikisTarihi
            // 
            DtpCikisTarihi.Location = new Point(102, 410);
            DtpCikisTarihi.Name = "DtpCikisTarihi";
            DtpCikisTarihi.Size = new Size(204, 27);
            DtpCikisTarihi.TabIndex = 19;
            DtpCikisTarihi.ValueChanged += DtpCikisTarihi_ValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(32, 143);
            label10.Name = "label10";
            label10.Size = new Size(61, 20);
            label10.TabIndex = 20;
            label10.Text = "Telefon:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bay", "Bayan" });
            comboBox1.Location = new Point(102, 105);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(204, 28);
            comboBox1.TabIndex = 21;
            // 
            // MskTxtBoxTelefon
            // 
            MskTxtBoxTelefon.Location = new Point(102, 141);
            MskTxtBoxTelefon.Mask = "(999) 000-0000";
            MskTxtBoxTelefon.Name = "MskTxtBoxTelefon";
            MskTxtBoxTelefon.Size = new Size(204, 27);
            MskTxtBoxTelefon.TabIndex = 22;
            // 
            // BtnKaydet
            // 
            BtnKaydet.Location = new Point(148, 454);
            BtnKaydet.Name = "BtnKaydet";
            BtnKaydet.Size = new Size(94, 29);
            BtnKaydet.TabIndex = 23;
            BtnKaydet.Text = "Kaydet";
            BtnKaydet.UseVisualStyleBackColor = true;
            BtnKaydet.Click += BtnKaydet_Click;
            // 
            // BtnOda101
            // 
            BtnOda101.BackColor = Color.Lime;
            BtnOda101.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnOda101.Location = new Point(374, 39);
            BtnOda101.Name = "BtnOda101";
            BtnOda101.Size = new Size(94, 74);
            BtnOda101.TabIndex = 24;
            BtnOda101.Text = "101";
            BtnOda101.UseVisualStyleBackColor = false;
            BtnOda101.Click += TxtOda101_Click;
            // 
            // BtnOda104
            // 
            BtnOda104.BackColor = Color.Lime;
            BtnOda104.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnOda104.Location = new Point(374, 188);
            BtnOda104.Name = "BtnOda104";
            BtnOda104.Size = new Size(94, 74);
            BtnOda104.TabIndex = 25;
            BtnOda104.Text = "104";
            BtnOda104.UseVisualStyleBackColor = false;
            BtnOda104.Click += TxtOda104_Click;
            // 
            // BtnOda105
            // 
            BtnOda105.BackColor = Color.Lime;
            BtnOda105.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnOda105.Location = new Point(550, 188);
            BtnOda105.Name = "BtnOda105";
            BtnOda105.Size = new Size(94, 74);
            BtnOda105.TabIndex = 26;
            BtnOda105.Text = "105";
            BtnOda105.UseVisualStyleBackColor = false;
            BtnOda105.Click += TxtOda105_Click;
            // 
            // BtnOda103
            // 
            BtnOda103.BackColor = Color.Lime;
            BtnOda103.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnOda103.Location = new Point(725, 39);
            BtnOda103.Name = "BtnOda103";
            BtnOda103.Size = new Size(94, 74);
            BtnOda103.TabIndex = 27;
            BtnOda103.Text = "103";
            BtnOda103.UseVisualStyleBackColor = false;
            BtnOda103.Click += button3_Click;
            // 
            // BtnOda102
            // 
            BtnOda102.BackColor = Color.Lime;
            BtnOda102.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnOda102.Location = new Point(550, 39);
            BtnOda102.Name = "BtnOda102";
            BtnOda102.Size = new Size(94, 74);
            BtnOda102.TabIndex = 28;
            BtnOda102.Text = "102";
            BtnOda102.UseVisualStyleBackColor = false;
            BtnOda102.Click += TxtOda102_Click;
            // 
            // BtnOda107
            // 
            BtnOda107.BackColor = Color.Lime;
            BtnOda107.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnOda107.Location = new Point(374, 343);
            BtnOda107.Name = "BtnOda107";
            BtnOda107.Size = new Size(94, 74);
            BtnOda107.TabIndex = 29;
            BtnOda107.Text = "107";
            BtnOda107.UseVisualStyleBackColor = false;
            BtnOda107.Click += TxtOda107_Click;
            // 
            // BtnOda108
            // 
            BtnOda108.BackColor = Color.Lime;
            BtnOda108.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnOda108.Location = new Point(550, 343);
            BtnOda108.Name = "BtnOda108";
            BtnOda108.Size = new Size(94, 74);
            BtnOda108.TabIndex = 30;
            BtnOda108.Text = "108";
            BtnOda108.UseVisualStyleBackColor = false;
            BtnOda108.Click += TxtOda108_Click;
            // 
            // BtnOda106
            // 
            BtnOda106.BackColor = Color.Lime;
            BtnOda106.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnOda106.Location = new Point(725, 188);
            BtnOda106.Name = "BtnOda106";
            BtnOda106.Size = new Size(94, 74);
            BtnOda106.TabIndex = 31;
            BtnOda106.Text = "106";
            BtnOda106.UseVisualStyleBackColor = false;
            BtnOda106.Click += TxtOda106_Click;
            // 
            // BtnOda109
            // 
            BtnOda109.BackColor = Color.Lime;
            BtnOda109.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnOda109.Location = new Point(725, 343);
            BtnOda109.Name = "BtnOda109";
            BtnOda109.Size = new Size(94, 74);
            BtnOda109.TabIndex = 32;
            BtnOda109.Text = "109";
            BtnOda109.UseVisualStyleBackColor = false;
            BtnOda109.Click += TxtOda109_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Lime;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(725, 434);
            button2.Name = "button2";
            button2.Size = new Size(68, 53);
            button2.TabIndex = 34;
            button2.Text = "Boş";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(632, 434);
            button1.Name = "button1";
            button1.Size = new Size(62, 53);
            button1.TabIndex = 35;
            button1.Text = "Dolu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(248, 458);
            label11.Name = "label11";
            label11.Size = new Size(58, 20);
            label11.TabIndex = 36;
            label11.Text = "label11";
            label11.Visible = false;
            // 
            // button3
            // 
            button3.Location = new Point(5, 454);
            button3.Name = "button3";
            button3.Size = new Size(91, 29);
            button3.TabIndex = 37;
            button3.Text = "Ana Menü";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // FrmYeniMusteri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(844, 499);
            Controls.Add(button3);
            Controls.Add(label11);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(BtnOda109);
            Controls.Add(BtnOda106);
            Controls.Add(BtnOda108);
            Controls.Add(BtnOda107);
            Controls.Add(BtnOda102);
            Controls.Add(BtnOda103);
            Controls.Add(BtnOda105);
            Controls.Add(BtnOda104);
            Controls.Add(BtnOda101);
            Controls.Add(BtnKaydet);
            Controls.Add(MskTxtBoxTelefon);
            Controls.Add(comboBox1);
            Controls.Add(label10);
            Controls.Add(DtpCikisTarihi);
            Controls.Add(DtpGirisTarihi);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(TxtUcret);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(TxtMail);
            Controls.Add(TxtKimlikNo);
            Controls.Add(TxtOdaNo);
            Controls.Add(label3);
            Controls.Add(TxtSoyadi);
            Controls.Add(label2);
            Controls.Add(TxtAdi);
            Controls.Add(label1);
            Name = "FrmYeniMusteri";
            Text = "FrmYeniMuster";
            Load += FrmYeniMusteri_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtAdi;
        private Label label2;
        private TextBox TxtSoyadi;
        private Label label3;
        private TextBox TxtOdaNo;
        private TextBox TxtKimlikNo;
        private TextBox TxtMail;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox TxtUcret;
        private Label label8;
        private Label label9;
        private DateTimePicker DtpGirisTarihi;
        private DateTimePicker DtpCikisTarihi;
        private Label label10;
        private ComboBox comboBox1;
        private MaskedTextBox MskTxtBoxTelefon;
        private Button BtnKaydet;
        private Button BtnOda101;
        private Button BtnOda104;
        private Button BtnOda105;
        private Button BtnOda103;
        private Button BtnOda102;
        private Button BtnOda107;
        private Button BtnOda108;
        private Button BtnOda106;
        private Button BtnOda109;
        private Button button2;
        private Button button1;
        private Label label11;
        private Button button3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}