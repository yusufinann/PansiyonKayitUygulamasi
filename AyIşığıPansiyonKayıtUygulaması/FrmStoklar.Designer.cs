namespace AyIşığıPansiyonKayıtUygulaması
{
    partial class FrmStoklar
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
            LblGida = new Label();
            LblCerez = new Label();
            LblIcecek = new Label();
            TxtGida = new TextBox();
            TxtCerez = new TextBox();
            TxtIcecek = new TextBox();
            BtnKaydet = new Button();
            button2 = new Button();
            TxtSu = new TextBox();
            TxtInternet = new TextBox();
            TxtElektrik = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            listView2 = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            button1 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Location = new Point(3, 330);
            listView1.Name = "listView1";
            listView1.Size = new Size(420, 261);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Gıda";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "İçecek";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Çerez";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 150;
            // 
            // LblGida
            // 
            LblGida.AutoSize = true;
            LblGida.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            LblGida.Location = new Point(62, 52);
            LblGida.Name = "LblGida";
            LblGida.Size = new Size(104, 23);
            LblGida.TabIndex = 1;
            LblGida.Text = "Gıda Tutarı:";
            // 
            // LblCerez
            // 
            LblCerez.AutoSize = true;
            LblCerez.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            LblCerez.Location = new Point(50, 185);
            LblCerez.Name = "LblCerez";
            LblCerez.Size = new Size(111, 23);
            LblCerez.TabIndex = 2;
            LblCerez.Text = "Çerez Tutarı:";
            // 
            // LblIcecek
            // 
            LblIcecek.AutoSize = true;
            LblIcecek.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            LblIcecek.Location = new Point(50, 118);
            LblIcecek.Name = "LblIcecek";
            LblIcecek.Size = new Size(116, 23);
            LblIcecek.TabIndex = 3;
            LblIcecek.Text = "İçecek Tutarı:";
            // 
            // TxtGida
            // 
            TxtGida.BackColor = Color.FromArgb(255, 255, 192);
            TxtGida.Location = new Point(172, 54);
            TxtGida.Name = "TxtGida";
            TxtGida.Size = new Size(165, 27);
            TxtGida.TabIndex = 4;
            // 
            // TxtCerez
            // 
            TxtCerez.BackColor = Color.FromArgb(255, 255, 192);
            TxtCerez.Location = new Point(172, 181);
            TxtCerez.Name = "TxtCerez";
            TxtCerez.Size = new Size(165, 27);
            TxtCerez.TabIndex = 5;
            // 
            // TxtIcecek
            // 
            TxtIcecek.BackColor = Color.FromArgb(255, 255, 192);
            TxtIcecek.Location = new Point(172, 114);
            TxtIcecek.Name = "TxtIcecek";
            TxtIcecek.Size = new Size(165, 27);
            TxtIcecek.TabIndex = 6;
            // 
            // BtnKaydet
            // 
            BtnKaydet.Location = new Point(50, 250);
            BtnKaydet.Name = "BtnKaydet";
            BtnKaydet.Size = new Size(94, 29);
            BtnKaydet.TabIndex = 7;
            BtnKaydet.Text = "Kaydet";
            BtnKaydet.UseVisualStyleBackColor = true;
            BtnKaydet.Click += BtnKaydet_Click;
            // 
            // button2
            // 
            button2.Location = new Point(633, 250);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 15;
            button2.Text = "Kaydet";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // TxtSu
            // 
            TxtSu.BackColor = Color.FromArgb(255, 255, 192);
            TxtSu.Location = new Point(633, 112);
            TxtSu.Name = "TxtSu";
            TxtSu.Size = new Size(165, 27);
            TxtSu.TabIndex = 14;
            // 
            // TxtInternet
            // 
            TxtInternet.BackColor = Color.FromArgb(255, 255, 192);
            TxtInternet.Location = new Point(633, 178);
            TxtInternet.Name = "TxtInternet";
            TxtInternet.Size = new Size(165, 27);
            TxtInternet.TabIndex = 13;
            // 
            // TxtElektrik
            // 
            TxtElektrik.BackColor = Color.FromArgb(255, 255, 192);
            TxtElektrik.Location = new Point(633, 52);
            TxtElektrik.Name = "TxtElektrik";
            TxtElektrik.Size = new Size(165, 27);
            TxtElektrik.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(511, 112);
            label1.Name = "label1";
            label1.Size = new Size(102, 23);
            label1.TabIndex = 11;
            label1.Text = "Su Faturası:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(467, 182);
            label2.Name = "label2";
            label2.Size = new Size(146, 23);
            label2.TabIndex = 10;
            label2.Text = "Internet Faturası:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(469, 52);
            label3.Name = "label3";
            label3.Size = new Size(144, 23);
            label3.TabIndex = 9;
            label3.Text = "Elektrik Faturası:";
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6 });
            listView2.Location = new Point(444, 330);
            listView2.Name = "listView2";
            listView2.Size = new Size(445, 261);
            listView2.TabIndex = 16;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Elektrik";
            columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Su";
            columnHeader5.Width = 130;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "İnternet";
            columnHeader6.Width = 130;
            // 
            // button1
            // 
            button1.Location = new Point(243, 250);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 17;
            button1.Text = "Temizle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(775, 250);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 18;
            button3.Text = "Temizle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // FrmStoklar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(929, 594);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(listView2);
            Controls.Add(button2);
            Controls.Add(TxtSu);
            Controls.Add(TxtInternet);
            Controls.Add(TxtElektrik);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(BtnKaydet);
            Controls.Add(TxtIcecek);
            Controls.Add(TxtCerez);
            Controls.Add(TxtGida);
            Controls.Add(LblIcecek);
            Controls.Add(LblCerez);
            Controls.Add(LblGida);
            Controls.Add(listView1);
            Name = "FrmStoklar";
            Text = "FrmStoklar";
            Load += FrmStoklar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label LblGida;
        private Label LblCerez;
        private Label LblIcecek;
        private TextBox TxtGida;
        private TextBox TxtCerez;
        private TextBox TxtIcecek;
        private Button BtnKaydet;
        private Button button2;
        private TextBox TxtSu;
        private TextBox TxtInternet;
        private TextBox TxtElektrik;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListView listView2;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button button1;
        private Button button3;
    }
}