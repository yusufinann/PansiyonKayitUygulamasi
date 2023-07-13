namespace AyIşığıPansiyonKayıtUygulaması
{
    partial class FrmAnaForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaForm));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            button7 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 30);
            button1.Name = "button1";
            button1.Size = new Size(114, 81);
            button1.TabIndex = 0;
            button1.Text = "Admin Giriş";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(12, 176);
            button2.Name = "button2";
            button2.Size = new Size(114, 81);
            button2.TabIndex = 1;
            button2.Text = "Müşteriler";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 255);
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(12, 310);
            button3.Name = "button3";
            button3.Size = new Size(114, 81);
            button3.TabIndex = 2;
            button3.Text = "Müşteri Mesajları";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 255, 192);
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(421, 176);
            button4.Name = "button4";
            button4.Size = new Size(114, 81);
            button4.TabIndex = 3;
            button4.Text = "Stoklar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(729, 380);
            button5.Name = "button5";
            button5.Size = new Size(59, 58);
            button5.TabIndex = 4;
            button5.Text = "Çıkış";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Cyan;
            button6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(213, 310);
            button6.Name = "button6";
            button6.Size = new Size(114, 81);
            button6.TabIndex = 5;
            button6.Text = "Hakkımızda";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Silver;
            button9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(213, 176);
            button9.Name = "button9";
            button9.Size = new Size(114, 81);
            button9.TabIndex = 8;
            button9.Text = "Gelir-Gider Formu";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(255, 224, 192);
            button10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button10.Location = new Point(421, 310);
            button10.Name = "button10";
            button10.Size = new Size(114, 81);
            button10.TabIndex = 9;
            button10.Text = "Şifre Güncelle";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(192, 192, 255);
            button11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button11.Location = new Point(421, 30);
            button11.Name = "button11";
            button11.Size = new Size(114, 81);
            button11.TabIndex = 10;
            button11.Text = "Odalar";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.FromArgb(128, 255, 128);
            button12.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button12.Location = new Point(213, 30);
            button12.Name = "button12";
            button12.Size = new Size(114, 81);
            button12.TabIndex = 11;
            button12.Text = "Yeni Müşteri";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(611, 51);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 12;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(611, 111);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 13;
            label2.Text = "label2";
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(569, 310);
            button7.Name = "button7";
            button7.Size = new Size(114, 81);
            button7.TabIndex = 14;
            button7.Text = "Hava Durumu";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // FrmAnaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button7);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FrmAnaForm";
            Text = "FrmAnaForm";
            Load += FrmAnaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label label2;
        private Button button7;
    }
}