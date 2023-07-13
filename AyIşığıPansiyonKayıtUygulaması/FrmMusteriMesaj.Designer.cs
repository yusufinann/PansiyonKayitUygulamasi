namespace AyIşığıPansiyonKayıtUygulaması
{
    partial class FrmMusteriMesaj
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
            TxtAdSoyad = new TextBox();
            label2 = new Label();
            TxtMesaj = new RichTextBox();
            BtnMesajGonder = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 19);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad:";
            // 
            // TxtAdSoyad
            // 
            TxtAdSoyad.Location = new Point(132, 12);
            TxtAdSoyad.Name = "TxtAdSoyad";
            TxtAdSoyad.Size = new Size(576, 27);
            TxtAdSoyad.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 166);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 2;
            label2.Text = "Mesaj:";
            // 
            // TxtMesaj
            // 
            TxtMesaj.Location = new Point(132, 45);
            TxtMesaj.Name = "TxtMesaj";
            TxtMesaj.Size = new Size(576, 270);
            TxtMesaj.TabIndex = 3;
            TxtMesaj.Text = "";
            // 
            // BtnMesajGonder
            // 
            BtnMesajGonder.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnMesajGonder.Location = new Point(728, 249);
            BtnMesajGonder.Name = "BtnMesajGonder";
            BtnMesajGonder.Size = new Size(94, 66);
            BtnMesajGonder.TabIndex = 5;
            BtnMesajGonder.Text = "Mesaj Gönder";
            BtnMesajGonder.UseVisualStyleBackColor = true;
            BtnMesajGonder.Click += BtnMesajGonder_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Location = new Point(12, 336);
            listView1.Name = "listView1";
            listView1.Size = new Size(810, 155);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged_1;
            listView1.DoubleClick += listView1_DoubleClick_1;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mesajid";
            columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ad Soyad";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Mesaj";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 900;
            // 
            // FrmMusteriMesaj
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(834, 503);
            Controls.Add(listView1);
            Controls.Add(BtnMesajGonder);
            Controls.Add(TxtMesaj);
            Controls.Add(label2);
            Controls.Add(TxtAdSoyad);
            Controls.Add(label1);
            Name = "FrmMusteriMesaj";
            Text = "FrmMusteriMesaj";
            Load += FrmMusteriMesaj_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtAdSoyad;
        private Label label2;
        private RichTextBox TxtMesaj;
        private Button BtnMesajGonder;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}