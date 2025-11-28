namespace paint
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.pcbTuval = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbYesil = new System.Windows.Forms.RadioButton();
            this.rbMavi = new System.Windows.Forms.RadioButton();
            this.rbKirmizi = new System.Windows.Forms.RadioButton();
            this.rbSiyah = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbBuyuk = new System.Windows.Forms.RadioButton();
            this.rbOrta = new System.Windows.Forms.RadioButton();
            this.rbKucuk = new System.Windows.Forms.RadioButton();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnGeriAl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTuval)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbTuval
            // 
            this.pcbTuval.BackColor = System.Drawing.Color.White;
            this.pcbTuval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbTuval.Location = new System.Drawing.Point(0, 0);
            this.pcbTuval.Name = "pcbTuval";
            this.pcbTuval.Size = new System.Drawing.Size(800, 450);
            this.pcbTuval.TabIndex = 0;
            this.pcbTuval.TabStop = false;
            this.pcbTuval.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcbTuval_MouseDown);
            this.pcbTuval.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pcbTuval_MouseMove);
            this.pcbTuval.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pcbTuval_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbYesil);
            this.groupBox1.Controls.Add(this.rbMavi);
            this.groupBox1.Controls.Add(this.rbKirmizi);
            this.groupBox1.Controls.Add(this.rbSiyah);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 124);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Renkler";
            // 
            // rbYesil
            // 
            this.rbYesil.AutoSize = true;
            this.rbYesil.Location = new System.Drawing.Point(12, 88);
            this.rbYesil.Name = "rbYesil";
            this.rbYesil.Size = new System.Drawing.Size(47, 17);
            this.rbYesil.TabIndex = 3;
            this.rbYesil.TabStop = true;
            this.rbYesil.Text = "Yeşil";
            this.rbYesil.UseVisualStyleBackColor = true;
            this.rbYesil.Click += new System.EventHandler(this.RenkDegistir);
            // 
            // rbMavi
            // 
            this.rbMavi.AutoSize = true;
            this.rbMavi.Location = new System.Drawing.Point(12, 65);
            this.rbMavi.Name = "rbMavi";
            this.rbMavi.Size = new System.Drawing.Size(48, 17);
            this.rbMavi.TabIndex = 2;
            this.rbMavi.TabStop = true;
            this.rbMavi.Text = "Mavi";
            this.rbMavi.UseVisualStyleBackColor = true;
            this.rbMavi.Click += new System.EventHandler(this.RenkDegistir);
            // 
            // rbKirmizi
            // 
            this.rbKirmizi.AutoSize = true;
            this.rbKirmizi.Location = new System.Drawing.Point(12, 42);
            this.rbKirmizi.Name = "rbKirmizi";
            this.rbKirmizi.Size = new System.Drawing.Size(54, 17);
            this.rbKirmizi.TabIndex = 1;
            this.rbKirmizi.TabStop = true;
            this.rbKirmizi.Text = "Kırmızı";
            this.rbKirmizi.UseVisualStyleBackColor = true;
            this.rbKirmizi.Click += new System.EventHandler(this.RenkDegistir);
            // 
            // rbSiyah
            // 
            this.rbSiyah.AutoSize = true;
            this.rbSiyah.Location = new System.Drawing.Point(12, 19);
            this.rbSiyah.Name = "rbSiyah";
            this.rbSiyah.Size = new System.Drawing.Size(51, 17);
            this.rbSiyah.TabIndex = 0;
            this.rbSiyah.TabStop = true;
            this.rbSiyah.Text = "Siyah";
            this.rbSiyah.UseVisualStyleBackColor = true;
            this.rbSiyah.Click += new System.EventHandler(this.RenkDegistir);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbBuyuk);
            this.groupBox2.Controls.Add(this.rbOrta);
            this.groupBox2.Controls.Add(this.rbKucuk);
            this.groupBox2.Location = new System.Drawing.Point(12, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(115, 96);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Boyut";
            // 
            // rbBuyuk
            // 
            this.rbBuyuk.AutoSize = true;
            this.rbBuyuk.Location = new System.Drawing.Point(6, 62);
            this.rbBuyuk.Name = "rbBuyuk";
            this.rbBuyuk.Size = new System.Drawing.Size(55, 17);
            this.rbBuyuk.TabIndex = 2;
            this.rbBuyuk.TabStop = true;
            this.rbBuyuk.Text = "Büyük";
            this.rbBuyuk.UseVisualStyleBackColor = true;
            this.rbBuyuk.Click += new System.EventHandler(this.BoyutDegistir);
            // 
            // rbOrta
            // 
            this.rbOrta.AutoSize = true;
            this.rbOrta.Location = new System.Drawing.Point(6, 39);
            this.rbOrta.Name = "rbOrta";
            this.rbOrta.Size = new System.Drawing.Size(45, 17);
            this.rbOrta.TabIndex = 1;
            this.rbOrta.TabStop = true;
            this.rbOrta.Text = "Orta";
            this.rbOrta.UseVisualStyleBackColor = true;
            this.rbOrta.Click += new System.EventHandler(this.BoyutDegistir);
            // 
            // rbKucuk
            // 
            this.rbKucuk.AutoSize = true;
            this.rbKucuk.Location = new System.Drawing.Point(6, 19);
            this.rbKucuk.Name = "rbKucuk";
            this.rbKucuk.Size = new System.Drawing.Size(56, 17);
            this.rbKucuk.TabIndex = 0;
            this.rbKucuk.TabStop = true;
            this.rbKucuk.Text = "Küçük";
            this.rbKucuk.UseVisualStyleBackColor = true;
            this.rbKucuk.Click += new System.EventHandler(this.BoyutDegistir);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(12, 253);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGeriAl
            // 
            this.btnGeriAl.Location = new System.Drawing.Point(12, 282);
            this.btnGeriAl.Name = "btnGeriAl";
            this.btnGeriAl.Size = new System.Drawing.Size(75, 23);
            this.btnGeriAl.TabIndex = 4;
            this.btnGeriAl.Text = "Geri Al";
            this.btnGeriAl.UseVisualStyleBackColor = true;
            this.btnGeriAl.Click += new System.EventHandler(this.btnGeriAl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGeriAl);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pcbTuval);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbTuval)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbTuval;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbYesil;
        private System.Windows.Forms.RadioButton rbMavi;
        private System.Windows.Forms.RadioButton rbKirmizi;
        private System.Windows.Forms.RadioButton rbSiyah;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbBuyuk;
        private System.Windows.Forms.RadioButton rbOrta;
        private System.Windows.Forms.RadioButton rbKucuk;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGeriAl;
    }
}

