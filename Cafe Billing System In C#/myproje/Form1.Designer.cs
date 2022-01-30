namespace myproje
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NUpDownSU = new System.Windows.Forms.NumericUpDown();
            this.NUpDownCay = new System.Windows.Forms.NumericUpDown();
            this.NUpDownMayveSU = new System.Windows.Forms.NumericUpDown();
            this.NUpDownHahve = new System.Windows.Forms.NumericUpDown();
            this.labelKahve = new System.Windows.Forms.Label();
            this.labelSU = new System.Windows.Forms.Label();
            this.labelCay = new System.Windows.Forms.Label();
            this.labelMayveSU = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonHesap = new System.Windows.Forms.Button();
            this.buttonSun = new System.Windows.Forms.Button();
            this.buttonCık = new System.Windows.Forms.Button();
            this.LisBoxİcecek = new System.Windows.Forms.ListBox();
            this.LisBoxAdet = new System.Windows.Forms.ListBox();
            this.LisBoxFatura = new System.Windows.Forms.ListBox();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUpDownSU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUpDownCay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUpDownMayveSU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUpDownHahve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.NUpDownSU);
            this.groupBox1.Controls.Add(this.NUpDownCay);
            this.groupBox1.Controls.Add(this.NUpDownMayveSU);
            this.groupBox1.Controls.Add(this.NUpDownHahve);
            this.groupBox1.Controls.Add(this.labelKahve);
            this.groupBox1.Controls.Add(this.labelSU);
            this.groupBox1.Controls.Add(this.labelCay);
            this.groupBox1.Controls.Add(this.labelMayveSU);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(22, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 281);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // NUpDownSU
            // 
            this.NUpDownSU.Location = new System.Drawing.Point(43, 226);
            this.NUpDownSU.Name = "NUpDownSU";
            this.NUpDownSU.Size = new System.Drawing.Size(69, 20);
            this.NUpDownSU.TabIndex = 2;
            this.NUpDownSU.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // NUpDownCay
            // 
            this.NUpDownCay.Location = new System.Drawing.Point(243, 226);
            this.NUpDownCay.Name = "NUpDownCay";
            this.NUpDownCay.Size = new System.Drawing.Size(69, 20);
            this.NUpDownCay.TabIndex = 2;
            this.NUpDownCay.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // NUpDownMayveSU
            // 
            this.NUpDownMayveSU.Location = new System.Drawing.Point(436, 226);
            this.NUpDownMayveSU.Name = "NUpDownMayveSU";
            this.NUpDownMayveSU.Size = new System.Drawing.Size(69, 20);
            this.NUpDownMayveSU.TabIndex = 2;
            this.NUpDownMayveSU.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // NUpDownHahve
            // 
            this.NUpDownHahve.Location = new System.Drawing.Point(637, 226);
            this.NUpDownHahve.Name = "NUpDownHahve";
            this.NUpDownHahve.Size = new System.Drawing.Size(69, 20);
            this.NUpDownHahve.TabIndex = 2;
            // 
            // labelKahve
            // 
            this.labelKahve.AutoSize = true;
            this.labelKahve.Location = new System.Drawing.Point(626, 179);
            this.labelKahve.Name = "labelKahve";
            this.labelKahve.Size = new System.Drawing.Size(101, 13);
            this.labelKahve.TabIndex = 1;
            this.labelKahve.Text = "Türk Kahvesi : 4 TL";
            this.labelKahve.Click += new System.EventHandler(this.labT_Click);
            // 
            // labelSU
            // 
            this.labelSU.AutoSize = true;
            this.labelSU.Location = new System.Drawing.Point(51, 179);
            this.labelSU.Name = "labelSU";
            this.labelSU.Size = new System.Drawing.Size(66, 13);
            this.labelSU.TabIndex = 1;
            this.labelSU.Text = "Su : 1.50 TL";
            // 
            // labelCay
            // 
            this.labelCay.AutoSize = true;
            this.labelCay.Location = new System.Drawing.Point(256, 179);
            this.labelCay.Name = "labelCay";
            this.labelCay.Size = new System.Drawing.Size(56, 13);
            this.labelCay.TabIndex = 1;
            this.labelCay.Text = "Çay : 2 TL";
            this.labelCay.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelMayveSU
            // 
            this.labelMayveSU.AutoSize = true;
            this.labelMayveSU.Location = new System.Drawing.Point(428, 179);
            this.labelMayveSU.Name = "labelMayveSU";
            this.labelMayveSU.Size = new System.Drawing.Size(97, 13);
            this.labelMayveSU.TabIndex = 1;
            this.labelMayveSU.Text = "Mayve Suyu : 3 TL";
            this.labelMayveSU.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::myproje.Properties.Resources.kahve;
            this.pictureBox4.Location = new System.Drawing.Point(601, 19);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(139, 128);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::myproje.Properties.Resources.mayve_suyu;
            this.pictureBox3.Location = new System.Drawing.Point(406, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(139, 128);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::myproje.Properties.Resources.cay;
            this.pictureBox2.Location = new System.Drawing.Point(210, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(139, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::myproje.Properties.Resources.su;
            this.pictureBox1.Location = new System.Drawing.Point(16, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Alındığı İçecek";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Adet";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(595, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Fatura";
            // 
            // buttonHesap
            // 
            this.buttonHesap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonHesap.Location = new System.Drawing.Point(575, 447);
            this.buttonHesap.Name = "buttonHesap";
            this.buttonHesap.Size = new System.Drawing.Size(75, 23);
            this.buttonHesap.TabIndex = 2;
            this.buttonHesap.Text = "Hesapla";
            this.buttonHesap.UseVisualStyleBackColor = false;
            this.buttonHesap.Click += new System.EventHandler(this.buttonH_Click);
            // 
            // buttonSun
            // 
            this.buttonSun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonSun.Location = new System.Drawing.Point(153, 490);
            this.buttonSun.Name = "buttonSun";
            this.buttonSun.Size = new System.Drawing.Size(110, 23);
            this.buttonSun.TabIndex = 2;
            this.buttonSun.Text = "Alınanları sun ";
            this.buttonSun.UseVisualStyleBackColor = false;
            this.buttonSun.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonCık
            // 
            this.buttonCık.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonCık.Location = new System.Drawing.Point(555, 505);
            this.buttonCık.Name = "buttonCık";
            this.buttonCık.Size = new System.Drawing.Size(113, 23);
            this.buttonCık.TabIndex = 2;
            this.buttonCık.Text = "Sistemden Çık";
            this.buttonCık.UseVisualStyleBackColor = false;
            this.buttonCık.Click += new System.EventHandler(this.buttonSC_Click);
            // 
            // LisBoxİcecek
            // 
            this.LisBoxİcecek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LisBoxİcecek.FormattingEnabled = true;
            this.LisBoxİcecek.Location = new System.Drawing.Point(96, 340);
            this.LisBoxİcecek.Name = "LisBoxİcecek";
            this.LisBoxİcecek.Size = new System.Drawing.Size(120, 134);
            this.LisBoxİcecek.TabIndex = 4;
            this.LisBoxİcecek.SelectedIndexChanged += new System.EventHandler(this.LisBoxİcecek_SelectedIndexChanged);
            // 
            // LisBoxAdet
            // 
            this.LisBoxAdet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LisBoxAdet.FormattingEnabled = true;
            this.LisBoxAdet.Location = new System.Drawing.Point(215, 340);
            this.LisBoxAdet.Name = "LisBoxAdet";
            this.LisBoxAdet.Size = new System.Drawing.Size(120, 134);
            this.LisBoxAdet.TabIndex = 5;
            this.LisBoxAdet.SelectedIndexChanged += new System.EventHandler(this.LBD_SelectedIndexChanged);
            // 
            // LisBoxFatura
            // 
            this.LisBoxFatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LisBoxFatura.FormattingEnabled = true;
            this.LisBoxFatura.Location = new System.Drawing.Point(554, 338);
            this.LisBoxFatura.Name = "LisBoxFatura";
            this.LisBoxFatura.Size = new System.Drawing.Size(120, 95);
            this.LisBoxFatura.TabIndex = 5;
            this.LisBoxFatura.SelectedIndexChanged += new System.EventHandler(this.LBF_SelectedIndexChanged);
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonTemizle.Location = new System.Drawing.Point(565, 476);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(93, 23);
            this.buttonTemizle.TabIndex = 6;
            this.buttonTemizle.Text = "Temizle";
            this.buttonTemizle.UseVisualStyleBackColor = false;
            this.buttonTemizle.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.buttonTemizle);
            this.Controls.Add(this.LisBoxFatura);
            this.Controls.Add(this.LisBoxAdet);
            this.Controls.Add(this.LisBoxİcecek);
            this.Controls.Add(this.buttonSun);
            this.Controls.Add(this.buttonCık);
            this.Controls.Add(this.buttonHesap);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "Form1";
            this.Text = "Temizle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUpDownSU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUpDownCay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUpDownMayveSU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUpDownHahve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown NUpDownSU;
        private System.Windows.Forms.NumericUpDown NUpDownCay;
        private System.Windows.Forms.NumericUpDown NUpDownMayveSU;
        private System.Windows.Forms.NumericUpDown NUpDownHahve;
        private System.Windows.Forms.Label labelKahve;
        private System.Windows.Forms.Label labelSU;
        private System.Windows.Forms.Label labelCay;
        private System.Windows.Forms.Label labelMayveSU;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonHesap;
        private System.Windows.Forms.Button buttonSun;
        private System.Windows.Forms.Button buttonCık;
        private System.Windows.Forms.ListBox LisBoxİcecek;
        private System.Windows.Forms.ListBox LisBoxAdet;
        private System.Windows.Forms.ListBox LisBoxFatura;
        private System.Windows.Forms.Button buttonTemizle;
    }
}

