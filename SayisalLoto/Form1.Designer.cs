namespace SayisalLoto
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_lotoCek = new System.Windows.Forms.Button();
            this.loto1 = new System.Windows.Forms.TextBox();
            this.loto2 = new System.Windows.Forms.TextBox();
            this.loto3 = new System.Windows.Forms.TextBox();
            this.loto4 = new System.Windows.Forms.TextBox();
            this.loto5 = new System.Windows.Forms.TextBox();
            this.loto6 = new System.Windows.Forms.TextBox();
            this.btn_lotoOyna = new System.Windows.Forms.Button();
            this.txt_oynanacakLotoSayisi = new System.Windows.Forms.TextBox();
            this.list_lotolar = new System.Windows.Forms.ListBox();
            this.lbl_2bilen = new System.Windows.Forms.Label();
            this.lbl_3bilen = new System.Windows.Forms.Label();
            this.lbl_4bilen = new System.Windows.Forms.Label();
            this.lbl_5bilen = new System.Windows.Forms.Label();
            this.lbl_6bilen = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Add1m = new System.Windows.Forms.Button();
            this.btn_Add100k = new System.Windows.Forms.Button();
            this.btn_Add10k = new System.Windows.Forms.Button();
            this.btn_Add1k = new System.Windows.Forms.Button();
            this.btn_gelismisSonuc = new System.Windows.Forms.Button();
            this.btn_Sifirla = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_lotoCek
            // 
            this.btn_lotoCek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lotoCek.Location = new System.Drawing.Point(144, 85);
            this.btn_lotoCek.Name = "btn_lotoCek";
            this.btn_lotoCek.Size = new System.Drawing.Size(126, 23);
            this.btn_lotoCek.TabIndex = 1;
            this.btn_lotoCek.Text = "Loto Çek";
            this.btn_lotoCek.UseVisualStyleBackColor = true;
            this.btn_lotoCek.Click += new System.EventHandler(this.btn_lotoCek_Click);
            // 
            // loto1
            // 
            this.loto1.BackColor = System.Drawing.Color.Gray;
            this.loto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loto1.Location = new System.Drawing.Point(12, 19);
            this.loto1.Multiline = true;
            this.loto1.Name = "loto1";
            this.loto1.ReadOnly = true;
            this.loto1.Size = new System.Drawing.Size(60, 60);
            this.loto1.TabIndex = 2;
            this.loto1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // loto2
            // 
            this.loto2.BackColor = System.Drawing.Color.Gray;
            this.loto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loto2.Location = new System.Drawing.Point(78, 19);
            this.loto2.Multiline = true;
            this.loto2.Name = "loto2";
            this.loto2.ReadOnly = true;
            this.loto2.Size = new System.Drawing.Size(60, 60);
            this.loto2.TabIndex = 3;
            // 
            // loto3
            // 
            this.loto3.BackColor = System.Drawing.Color.Gray;
            this.loto3.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loto3.Location = new System.Drawing.Point(144, 19);
            this.loto3.Multiline = true;
            this.loto3.Name = "loto3";
            this.loto3.ReadOnly = true;
            this.loto3.Size = new System.Drawing.Size(60, 60);
            this.loto3.TabIndex = 4;
            // 
            // loto4
            // 
            this.loto4.BackColor = System.Drawing.Color.Gray;
            this.loto4.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loto4.Location = new System.Drawing.Point(210, 19);
            this.loto4.Multiline = true;
            this.loto4.Name = "loto4";
            this.loto4.ReadOnly = true;
            this.loto4.Size = new System.Drawing.Size(60, 60);
            this.loto4.TabIndex = 5;
            // 
            // loto5
            // 
            this.loto5.BackColor = System.Drawing.Color.Gray;
            this.loto5.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loto5.Location = new System.Drawing.Point(276, 19);
            this.loto5.Multiline = true;
            this.loto5.Name = "loto5";
            this.loto5.ReadOnly = true;
            this.loto5.Size = new System.Drawing.Size(60, 60);
            this.loto5.TabIndex = 6;
            // 
            // loto6
            // 
            this.loto6.BackColor = System.Drawing.Color.Gray;
            this.loto6.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loto6.Location = new System.Drawing.Point(342, 19);
            this.loto6.Multiline = true;
            this.loto6.Name = "loto6";
            this.loto6.ReadOnly = true;
            this.loto6.Size = new System.Drawing.Size(60, 60);
            this.loto6.TabIndex = 7;
            // 
            // btn_lotoOyna
            // 
            this.btn_lotoOyna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lotoOyna.ForeColor = System.Drawing.Color.White;
            this.btn_lotoOyna.Location = new System.Drawing.Point(78, 19);
            this.btn_lotoOyna.Name = "btn_lotoOyna";
            this.btn_lotoOyna.Size = new System.Drawing.Size(120, 22);
            this.btn_lotoOyna.TabIndex = 14;
            this.btn_lotoOyna.Text = "Loto Oyna";
            this.btn_lotoOyna.UseVisualStyleBackColor = true;
            this.btn_lotoOyna.Click += new System.EventHandler(this.btn_lotoOyna_Click);
            // 
            // txt_oynanacakLotoSayisi
            // 
            this.txt_oynanacakLotoSayisi.BackColor = System.Drawing.Color.Gray;
            this.txt_oynanacakLotoSayisi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_oynanacakLotoSayisi.Location = new System.Drawing.Point(12, 19);
            this.txt_oynanacakLotoSayisi.Name = "txt_oynanacakLotoSayisi";
            this.txt_oynanacakLotoSayisi.Size = new System.Drawing.Size(61, 20);
            this.txt_oynanacakLotoSayisi.TabIndex = 15;
            this.txt_oynanacakLotoSayisi.Text = "0";
            this.txt_oynanacakLotoSayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_oynanacakLotoSayisi.Click += new System.EventHandler(this.txt_oynanacakLotoSayisi_Click);
            this.txt_oynanacakLotoSayisi.TextChanged += new System.EventHandler(this.txt_oynanacakLotoSayisi_TextChanged);
            this.txt_oynanacakLotoSayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_oynanacakLotoSayisi_KeyPress);
            // 
            // list_lotolar
            // 
            this.list_lotolar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.list_lotolar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.list_lotolar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.list_lotolar.FormattingEnabled = true;
            this.list_lotolar.Location = new System.Drawing.Point(12, 47);
            this.list_lotolar.Name = "list_lotolar";
            this.list_lotolar.Size = new System.Drawing.Size(135, 160);
            this.list_lotolar.TabIndex = 16;
            this.list_lotolar.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.list_lotolar_DrawItem);
            // 
            // lbl_2bilen
            // 
            this.lbl_2bilen.AutoSize = true;
            this.lbl_2bilen.BackColor = System.Drawing.Color.Transparent;
            this.lbl_2bilen.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lbl_2bilen.Location = new System.Drawing.Point(9, 26);
            this.lbl_2bilen.Name = "lbl_2bilen";
            this.lbl_2bilen.Size = new System.Drawing.Size(87, 13);
            this.lbl_2bilen.TabIndex = 17;
            this.lbl_2bilen.Text = "2 Bilen Sayısı = 0";
            // 
            // lbl_3bilen
            // 
            this.lbl_3bilen.AutoSize = true;
            this.lbl_3bilen.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_3bilen.Location = new System.Drawing.Point(9, 49);
            this.lbl_3bilen.Name = "lbl_3bilen";
            this.lbl_3bilen.Size = new System.Drawing.Size(87, 13);
            this.lbl_3bilen.TabIndex = 18;
            this.lbl_3bilen.Text = "3 Bilen Sayısı = 0";
            // 
            // lbl_4bilen
            // 
            this.lbl_4bilen.AutoSize = true;
            this.lbl_4bilen.ForeColor = System.Drawing.Color.Orange;
            this.lbl_4bilen.Location = new System.Drawing.Point(9, 74);
            this.lbl_4bilen.Name = "lbl_4bilen";
            this.lbl_4bilen.Size = new System.Drawing.Size(87, 13);
            this.lbl_4bilen.TabIndex = 20;
            this.lbl_4bilen.Text = "4 Bilen Sayısı = 0";
            // 
            // lbl_5bilen
            // 
            this.lbl_5bilen.AutoSize = true;
            this.lbl_5bilen.ForeColor = System.Drawing.Color.Red;
            this.lbl_5bilen.Location = new System.Drawing.Point(9, 97);
            this.lbl_5bilen.Name = "lbl_5bilen";
            this.lbl_5bilen.Size = new System.Drawing.Size(87, 13);
            this.lbl_5bilen.TabIndex = 21;
            this.lbl_5bilen.Text = "5 Bilen Sayısı = 0";
            // 
            // lbl_6bilen
            // 
            this.lbl_6bilen.AutoSize = true;
            this.lbl_6bilen.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_6bilen.Location = new System.Drawing.Point(9, 120);
            this.lbl_6bilen.Name = "lbl_6bilen";
            this.lbl_6bilen.Size = new System.Drawing.Size(87, 13);
            this.lbl_6bilen.TabIndex = 22;
            this.lbl_6bilen.Text = "6 Bilen Sayısı = 0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loto2);
            this.groupBox1.Controls.Add(this.btn_lotoCek);
            this.groupBox1.Controls.Add(this.loto1);
            this.groupBox1.Controls.Add(this.loto3);
            this.groupBox1.Controls.Add(this.loto4);
            this.groupBox1.Controls.Add(this.loto5);
            this.groupBox1.Controls.Add(this.loto6);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 115);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sayısal Loto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_2bilen);
            this.groupBox2.Controls.Add(this.lbl_6bilen);
            this.groupBox2.Controls.Add(this.lbl_3bilen);
            this.groupBox2.Controls.Add(this.lbl_5bilen);
            this.groupBox2.Controls.Add(this.lbl_4bilen);
            this.groupBox2.ForeColor = System.Drawing.Color.BlueViolet;
            this.groupBox2.Location = new System.Drawing.Point(285, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(143, 150);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bilenler";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Add1m);
            this.groupBox3.Controls.Add(this.btn_Add100k);
            this.groupBox3.Controls.Add(this.btn_Add10k);
            this.groupBox3.Controls.Add(this.btn_Add1k);
            this.groupBox3.Controls.Add(this.list_lotolar);
            this.groupBox3.Controls.Add(this.btn_lotoOyna);
            this.groupBox3.Controls.Add(this.txt_oynanacakLotoSayisi);
            this.groupBox3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.groupBox3.Location = new System.Drawing.Point(12, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(204, 223);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Oynayanlar";
            // 
            // btn_Add1m
            // 
            this.btn_Add1m.BackColor = System.Drawing.Color.Transparent;
            this.btn_Add1m.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add1m.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Add1m.Location = new System.Drawing.Point(150, 184);
            this.btn_Add1m.Name = "btn_Add1m";
            this.btn_Add1m.Size = new System.Drawing.Size(48, 23);
            this.btn_Add1m.TabIndex = 20;
            this.btn_Add1m.Text = "1M";
            this.btn_Add1m.UseVisualStyleBackColor = false;
            this.btn_Add1m.Click += new System.EventHandler(this.btn_Add1m_Click);
            // 
            // btn_Add100k
            // 
            this.btn_Add100k.BackColor = System.Drawing.Color.Transparent;
            this.btn_Add100k.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add100k.ForeColor = System.Drawing.Color.Red;
            this.btn_Add100k.Location = new System.Drawing.Point(150, 155);
            this.btn_Add100k.Name = "btn_Add100k";
            this.btn_Add100k.Size = new System.Drawing.Size(48, 23);
            this.btn_Add100k.TabIndex = 19;
            this.btn_Add100k.Text = "100k";
            this.btn_Add100k.UseVisualStyleBackColor = false;
            this.btn_Add100k.Click += new System.EventHandler(this.btn_Add100k_Click);
            // 
            // btn_Add10k
            // 
            this.btn_Add10k.BackColor = System.Drawing.Color.Transparent;
            this.btn_Add10k.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add10k.ForeColor = System.Drawing.Color.Tomato;
            this.btn_Add10k.Location = new System.Drawing.Point(150, 127);
            this.btn_Add10k.Name = "btn_Add10k";
            this.btn_Add10k.Size = new System.Drawing.Size(48, 23);
            this.btn_Add10k.TabIndex = 18;
            this.btn_Add10k.Text = "10k";
            this.btn_Add10k.UseVisualStyleBackColor = false;
            this.btn_Add10k.Click += new System.EventHandler(this.btn_Add10k_Click);
            // 
            // btn_Add1k
            // 
            this.btn_Add1k.BackColor = System.Drawing.Color.Transparent;
            this.btn_Add1k.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add1k.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Add1k.Location = new System.Drawing.Point(150, 98);
            this.btn_Add1k.Name = "btn_Add1k";
            this.btn_Add1k.Size = new System.Drawing.Size(48, 23);
            this.btn_Add1k.TabIndex = 17;
            this.btn_Add1k.Text = "1k";
            this.btn_Add1k.UseVisualStyleBackColor = false;
            this.btn_Add1k.Click += new System.EventHandler(this.btn_Add1k_Click);
            // 
            // btn_gelismisSonuc
            // 
            this.btn_gelismisSonuc.Enabled = false;
            this.btn_gelismisSonuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gelismisSonuc.Location = new System.Drawing.Point(285, 321);
            this.btn_gelismisSonuc.Name = "btn_gelismisSonuc";
            this.btn_gelismisSonuc.Size = new System.Drawing.Size(143, 35);
            this.btn_gelismisSonuc.TabIndex = 26;
            this.btn_gelismisSonuc.Text = "Gelişmiş Sonuçlar";
            this.btn_gelismisSonuc.UseVisualStyleBackColor = true;
            this.btn_gelismisSonuc.Click += new System.EventHandler(this.btn_gelismisSonuc_Click);
            // 
            // btn_Sifirla
            // 
            this.btn_Sifirla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sifirla.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btn_Sifirla.Location = new System.Drawing.Point(285, 289);
            this.btn_Sifirla.Name = "btn_Sifirla";
            this.btn_Sifirla.Size = new System.Drawing.Size(143, 28);
            this.btn_Sifirla.TabIndex = 27;
            this.btn_Sifirla.Text = "Sıfırla";
            this.btn_Sifirla.UseVisualStyleBackColor = true;
            this.btn_Sifirla.Click += new System.EventHandler(this.btn_Sifirla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(443, 368);
            this.Controls.Add(this.btn_Sifirla);
            this.Controls.Add(this.btn_gelismisSonuc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sayısal Loto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_lotoCek;
        private System.Windows.Forms.TextBox loto1;
        private System.Windows.Forms.TextBox loto2;
        private System.Windows.Forms.TextBox loto3;
        private System.Windows.Forms.TextBox loto4;
        private System.Windows.Forms.TextBox loto5;
        private System.Windows.Forms.TextBox loto6;
        private System.Windows.Forms.Button btn_lotoOyna;
        private System.Windows.Forms.TextBox txt_oynanacakLotoSayisi;
        private System.Windows.Forms.ListBox list_lotolar;
        private System.Windows.Forms.Label lbl_2bilen;
        private System.Windows.Forms.Label lbl_3bilen;
        private System.Windows.Forms.Label lbl_4bilen;
        private System.Windows.Forms.Label lbl_5bilen;
        private System.Windows.Forms.Label lbl_6bilen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Add1k;
        private System.Windows.Forms.Button btn_Add1m;
        private System.Windows.Forms.Button btn_Add100k;
        private System.Windows.Forms.Button btn_Add10k;
        private System.Windows.Forms.Button btn_gelismisSonuc;
        private System.Windows.Forms.Button btn_Sifirla;
    }
}

