namespace AyIşığıPansiyonKayıtUygulaması
{
    partial class FrmSifreGuncelle
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
            BtnGuncelle = new Button();
            TxtSifre = new TextBox();
            TxtKullanici = new TextBox();
            lblSifre = new Label();
            lblKullanici = new Label();
            SuspendLayout();
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnGuncelle.Location = new Point(279, 194);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(94, 36);
            BtnGuncelle.TabIndex = 10;
            BtnGuncelle.Text = "Güncelle";
            BtnGuncelle.UseVisualStyleBackColor = true;
            BtnGuncelle.Click += BtnGuncelle_Click_1;
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(279, 150);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(170, 27);
            TxtSifre.TabIndex = 9;
            TxtSifre.UseSystemPasswordChar = true;
            // 
            // TxtKullanici
            // 
            TxtKullanici.Location = new Point(279, 96);
            TxtKullanici.Name = "TxtKullanici";
            TxtKullanici.Size = new Size(170, 27);
            TxtKullanici.TabIndex = 8;
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.BackColor = Color.Transparent;
            lblSifre.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblSifre.ForeColor = Color.White;
            lblSifre.Location = new Point(197, 152);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(56, 25);
            lblSifre.TabIndex = 7;
            lblSifre.Text = "Şifre:";
            // 
            // lblKullanici
            // 
            lblKullanici.AutoSize = true;
            lblKullanici.BackColor = Color.Transparent;
            lblKullanici.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblKullanici.ForeColor = Color.White;
            lblKullanici.Location = new Point(129, 98);
            lblKullanici.Name = "lblKullanici";
            lblKullanici.Size = new Size(124, 25);
            lblKullanici.TabIndex = 6;
            lblKullanici.Text = "Kullanıcı Adi:";
            // 
            // FrmSifreGuncelle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnGuncelle);
            Controls.Add(TxtSifre);
            Controls.Add(TxtKullanici);
            Controls.Add(lblSifre);
            Controls.Add(lblKullanici);
            Name = "FrmSifreGuncelle";
            Text = "FrmSifreGuncelle";
            Load += FrmSifreGuncelle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnGuncelle;
        private TextBox TxtSifre;
        private TextBox TxtKullanici;
        private Label lblSifre;
        private Label lblKullanici;
    }
}