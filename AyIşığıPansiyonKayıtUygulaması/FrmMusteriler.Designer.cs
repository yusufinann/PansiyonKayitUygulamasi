namespace AyIşığıPansiyonKayıtUygulaması
{
    partial class FrmMusteriler
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
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            TxtAra = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            BtnVerileriGoster = new Button();
            MskTxtBoxTelefon = new MaskedTextBox();
            comboBox1 = new ComboBox();
            label10 = new Label();
            DtpCikisTarihi = new DateTimePicker();
            DtpGirisTarihi = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            TxtUcret = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            TxtMail = new TextBox();
            TxtKimlikNo = new TextBox();
            TxtOdaNo = new TextBox();
            label3 = new Label();
            TxtSoyadi = new TextBox();
            label2 = new Label();
            TxtAdi = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11 });
            listView1.Location = new Point(6, 328);
            listView1.Name = "listView1";
            listView1.Size = new Size(898, 203);
            listView1.TabIndex = 90;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.DoubleClick += listView1_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Müşteri ID";
            columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Adı";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Soyadı";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Cinsiyet";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Telefon";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 130;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Mail";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "TC";
            columnHeader7.TextAlign = HorizontalAlignment.Center;
            columnHeader7.Width = 120;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Oda No";
            columnHeader8.TextAlign = HorizontalAlignment.Center;
            columnHeader8.Width = 65;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Ücret";
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Giriş Tarihi";
            columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Çıkış Tarihi";
            columnHeader11.Width = 100;
            // 
            // TxtAra
            // 
            TxtAra.Location = new Point(513, 238);
            TxtAra.Name = "TxtAra";
            TxtAra.Size = new Size(204, 27);
            TxtAra.TabIndex = 89;
            // 
            // button4
            // 
            button4.Location = new Point(745, 79);
            button4.Name = "button4";
            button4.Size = new Size(155, 34);
            button4.TabIndex = 88;
            button4.Text = "Sil";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(745, 126);
            button3.Name = "button3";
            button3.Size = new Size(155, 34);
            button3.TabIndex = 87;
            button3.Text = "Temizle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(745, 230);
            button2.Name = "button2";
            button2.Size = new Size(155, 34);
            button2.TabIndex = 86;
            button2.Text = "Ara";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(745, 170);
            button1.Name = "button1";
            button1.Size = new Size(155, 34);
            button1.TabIndex = 85;
            button1.Text = "Güncelle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BtnVerileriGoster
            // 
            BtnVerileriGoster.Location = new Point(745, 33);
            BtnVerileriGoster.Name = "BtnVerileriGoster";
            BtnVerileriGoster.Size = new Size(155, 31);
            BtnVerileriGoster.TabIndex = 84;
            BtnVerileriGoster.Text = "Verileri Göster";
            BtnVerileriGoster.UseVisualStyleBackColor = true;
            BtnVerileriGoster.Click += BtnVerileriGoster_Click;
            // 
            // MskTxtBoxTelefon
            // 
            MskTxtBoxTelefon.Location = new Point(113, 151);
            MskTxtBoxTelefon.Mask = "(999) 000-0000";
            MskTxtBoxTelefon.Name = "MskTxtBoxTelefon";
            MskTxtBoxTelefon.Size = new Size(204, 27);
            MskTxtBoxTelefon.TabIndex = 83;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bay", "Bayan" });
            comboBox1.Location = new Point(113, 115);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(204, 28);
            comboBox1.TabIndex = 82;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(43, 153);
            label10.Name = "label10";
            label10.Size = new Size(61, 20);
            label10.TabIndex = 81;
            label10.Text = "Telefon:";
            // 
            // DtpCikisTarihi
            // 
            DtpCikisTarihi.Location = new Point(457, 177);
            DtpCikisTarihi.Name = "DtpCikisTarihi";
            DtpCikisTarihi.Size = new Size(204, 27);
            DtpCikisTarihi.TabIndex = 80;
            // 
            // DtpGirisTarihi
            // 
            DtpGirisTarihi.Location = new Point(457, 133);
            DtpGirisTarihi.Name = "DtpGirisTarihi";
            DtpGirisTarihi.Size = new Size(204, 27);
            DtpGirisTarihi.TabIndex = 79;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(370, 184);
            label9.Name = "label9";
            label9.Size = new Size(81, 20);
            label9.TabIndex = 78;
            label9.Text = "Çıkış Tarihi:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(371, 138);
            label8.Name = "label8";
            label8.Size = new Size(80, 20);
            label8.TabIndex = 77;
            label8.Text = "Giriş Tarihi:";
            // 
            // TxtUcret
            // 
            TxtUcret.Location = new Point(457, 86);
            TxtUcret.Name = "TxtUcret";
            TxtUcret.Size = new Size(204, 27);
            TxtUcret.TabIndex = 76;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(407, 89);
            label7.Name = "label7";
            label7.Size = new Size(47, 20);
            label7.TabIndex = 75;
            label7.Text = "Ucret:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(58, 198);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 74;
            label6.Text = "Mail:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(387, 40);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 73;
            label5.Text = "Oda No:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 241);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 72;
            label4.Text = "Tc Kimlik No:";
            // 
            // TxtMail
            // 
            TxtMail.Location = new Point(113, 191);
            TxtMail.Name = "TxtMail";
            TxtMail.Size = new Size(204, 27);
            TxtMail.TabIndex = 71;
            // 
            // TxtKimlikNo
            // 
            TxtKimlikNo.Location = new Point(113, 234);
            TxtKimlikNo.MaxLength = 11;
            TxtKimlikNo.Name = "TxtKimlikNo";
            TxtKimlikNo.Size = new Size(204, 27);
            TxtKimlikNo.TabIndex = 70;
            // 
            // TxtOdaNo
            // 
            TxtOdaNo.Location = new Point(457, 33);
            TxtOdaNo.Name = "TxtOdaNo";
            TxtOdaNo.Size = new Size(204, 27);
            TxtOdaNo.TabIndex = 69;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 115);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 68;
            label3.Text = "Cinsiyet:";
            // 
            // TxtSoyadi
            // 
            TxtSoyadi.Location = new Point(113, 70);
            TxtSoyadi.Name = "TxtSoyadi";
            TxtSoyadi.Size = new Size(204, 27);
            TxtSoyadi.TabIndex = 67;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 77);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 66;
            label2.Text = "Soyadı:";
            // 
            // TxtAdi
            // 
            TxtAdi.Location = new Point(113, 29);
            TxtAdi.Name = "TxtAdi";
            TxtAdi.Size = new Size(204, 27);
            TxtAdi.TabIndex = 65;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 36);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 64;
            label1.Text = "Ad:";
            // 
            // FrmMusteriler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(916, 543);
            Controls.Add(listView1);
            Controls.Add(TxtAra);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(BtnVerileriGoster);
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
            Name = "FrmMusteriler";
            Text = "FrmMusteriler";
            Load += FrmMusteriler_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private TextBox TxtAra;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button BtnVerileriGoster;
        private MaskedTextBox MskTxtBoxTelefon;
        private ComboBox comboBox1;
        private Label label10;
        private DateTimePicker DtpCikisTarihi;
        private DateTimePicker DtpGirisTarihi;
        private Label label9;
        private Label label8;
        private TextBox TxtUcret;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox TxtMail;
        private TextBox TxtKimlikNo;
        private TextBox TxtOdaNo;
        private Label label3;
        private TextBox TxtSoyadi;
        private Label label2;
        private TextBox TxtAdi;
        private Label label1;
    }
}