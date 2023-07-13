namespace AyIşığıPansiyonKayıtUygulaması
{
    partial class FrmAdminGiris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminGiris));
            lblKullanici = new Label();
            lblSifre = new Label();
            TxtKullanici = new TextBox();
            TxtSifre = new TextBox();
            BtnGiris = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblKullanici
            // 
            lblKullanici.AutoSize = true;
            lblKullanici.BackColor = Color.Transparent;
            lblKullanici.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblKullanici.ForeColor = Color.White;
            lblKullanici.Location = new Point(110, 162);
            lblKullanici.Name = "lblKullanici";
            lblKullanici.Size = new Size(124, 25);
            lblKullanici.TabIndex = 0;
            lblKullanici.Text = "Kullanıcı Adi:";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.BackColor = Color.Transparent;
            lblSifre.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblSifre.ForeColor = Color.White;
            lblSifre.Location = new Point(178, 216);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(56, 25);
            lblSifre.TabIndex = 1;
            lblSifre.Text = "Şifre:";
            lblSifre.Click += label1_Click;
            // 
            // TxtKullanici
            // 
            TxtKullanici.Location = new Point(260, 160);
            TxtKullanici.Name = "TxtKullanici";
            TxtKullanici.Size = new Size(170, 27);
            TxtKullanici.TabIndex = 2;
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(260, 214);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(170, 27);
            TxtSifre.TabIndex = 3;
            TxtSifre.UseSystemPasswordChar = true;
            // 
            // BtnGiris
            // 
            BtnGiris.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnGiris.Location = new Point(260, 259);
            BtnGiris.Name = "BtnGiris";
            BtnGiris.Size = new Size(94, 36);
            BtnGiris.TabIndex = 4;
            BtnGiris.Text = "Giriş";
            BtnGiris.UseVisualStyleBackColor = true;
            BtnGiris.Click += BtnGiris_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe Script", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(40, 43);
            label2.Name = "label2";
            label2.Size = new Size(398, 33);
            label2.TabIndex = 6;
            label2.Text = "AY IŞIĞI PANSİYONA HOŞGELDİNİZ";
            // 
            // FrmAdminGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(778, 486);
            Controls.Add(label2);
            Controls.Add(BtnGiris);
            Controls.Add(TxtSifre);
            Controls.Add(TxtKullanici);
            Controls.Add(lblSifre);
            Controls.Add(lblKullanici);
            Name = "FrmAdminGiris";
            Text = "Admin Giriş";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKullanici;
        private Label lblSifre;
        private TextBox TxtKullanici;
        private TextBox TxtSifre;
        private Button BtnGiris;
        private Label label2;
    }
}