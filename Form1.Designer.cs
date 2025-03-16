namespace StockInventory
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            grsPanel = new Panel();
            silBtn = new Button();
            grsBtn = new Button();
            grsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 55);
            label1.Name = "label1";
            label1.Size = new Size(133, 12);
            label1.TabIndex = 0;
            label1.Text = "Kullanici Adı : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 81);
            label2.Name = "label2";
            label2.Size = new Size(61, 12);
            label2.TabIndex = 1;
            label2.Text = "Şifre :";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(241, 53);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(100, 19);
            txtKullaniciAdi.TabIndex = 2;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(241, 78);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(100, 19);
            txtSifre.TabIndex = 3;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // grsPanel
            // 
            grsPanel.BackColor = Color.FromArgb(192, 192, 255);
            grsPanel.Controls.Add(silBtn);
            grsPanel.Controls.Add(grsBtn);
            grsPanel.Controls.Add(txtKullaniciAdi);
            grsPanel.Controls.Add(txtSifre);
            grsPanel.Controls.Add(label1);
            grsPanel.Controls.Add(label2);
            grsPanel.ForeColor = SystemColors.InfoText;
            grsPanel.Location = new Point(867, 290);
            grsPanel.Name = "grsPanel";
            grsPanel.Size = new Size(429, 280);
            grsPanel.TabIndex = 4;
            grsPanel.Paint += panel1_Paint;
            // 
            // silBtn
            // 
            silBtn.Font = new Font("Lucida Console", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            silBtn.ForeColor = Color.Red;
            silBtn.Location = new Point(241, 182);
            silBtn.Name = "silBtn";
            silBtn.Size = new Size(100, 30);
            silBtn.TabIndex = 5;
            silBtn.Text = "Temizle";
            silBtn.UseVisualStyleBackColor = true;
            // 
            // grsBtn
            // 
            grsBtn.Font = new Font("Lucida Console", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grsBtn.ForeColor = Color.Lime;
            grsBtn.Location = new Point(129, 182);
            grsBtn.Name = "grsBtn";
            grsBtn.Size = new Size(99, 30);
            grsBtn.TabIndex = 4;
            grsBtn.Text = "Giriş";
            grsBtn.UseVisualStyleBackColor = true;
            grsBtn.Click += grsBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1349, 604);
            Controls.Add(grsPanel);
            Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Giris Formu";
            Load += Form1_Load;
            grsPanel.ResumeLayout(false);
            grsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel grsPanel;
        private Button silBtn;
        private Button grsBtn;
    }
}
