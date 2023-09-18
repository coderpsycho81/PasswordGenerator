
namespace Passwd_Generator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.newText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CopyBTN = new System.Windows.Forms.Button();
            this.passGeneratorBTN = new System.Windows.Forms.Button();
            this.büyükHarfCH = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.küçükHarfCH = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numaraCH = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sembolCH = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numberLenghCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.langCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.newText);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.CopyBTN);
            this.panel1.Controls.Add(this.passGeneratorBTN);
            this.panel1.Controls.Add(this.büyükHarfCH);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.küçükHarfCH);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.numaraCH);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.sembolCH);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.numberLenghCombo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.langCombo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(28, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 472);
            this.panel1.TabIndex = 0;
            // 
            // newText
            // 
            this.newText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newText.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newText.Location = new System.Drawing.Point(163, 322);
            this.newText.Multiline = true;
            this.newText.Name = "newText";
            this.newText.Size = new System.Drawing.Size(212, 29);
            this.newText.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(6, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Yeni Şifreleriniz:";
            // 
            // CopyBTN
            // 
            this.CopyBTN.BackColor = System.Drawing.Color.Bisque;
            this.CopyBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CopyBTN.FlatAppearance.BorderSize = 0;
            this.CopyBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MistyRose;
            this.CopyBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin;
            this.CopyBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyBTN.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CopyBTN.Location = new System.Drawing.Point(284, 253);
            this.CopyBTN.Name = "CopyBTN";
            this.CopyBTN.Size = new System.Drawing.Size(95, 36);
            this.CopyBTN.TabIndex = 16;
            this.CopyBTN.Text = "Kopyala";
            this.CopyBTN.UseVisualStyleBackColor = false;
            this.CopyBTN.Click += new System.EventHandler(this.CopyBTN_Click);
            // 
            // passGeneratorBTN
            // 
            this.passGeneratorBTN.BackColor = System.Drawing.Color.Bisque;
            this.passGeneratorBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passGeneratorBTN.FlatAppearance.BorderSize = 0;
            this.passGeneratorBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MistyRose;
            this.passGeneratorBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin;
            this.passGeneratorBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passGeneratorBTN.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passGeneratorBTN.Location = new System.Drawing.Point(152, 253);
            this.passGeneratorBTN.Name = "passGeneratorBTN";
            this.passGeneratorBTN.Size = new System.Drawing.Size(126, 36);
            this.passGeneratorBTN.TabIndex = 15;
            this.passGeneratorBTN.Text = "Şifre oluştur";
            this.passGeneratorBTN.UseVisualStyleBackColor = false;
            this.passGeneratorBTN.Click += new System.EventHandler(this.passGeneratorBTN_Click);
            // 
            // büyükHarfCH
            // 
            this.büyükHarfCH.AutoSize = true;
            this.büyükHarfCH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.büyükHarfCH.Location = new System.Drawing.Point(284, 216);
            this.büyükHarfCH.Name = "büyükHarfCH";
            this.büyükHarfCH.Size = new System.Drawing.Size(101, 17);
            this.büyükHarfCH.TabIndex = 14;
            this.büyükHarfCH.Text = "( e.g. ABCDEF )";
            this.büyükHarfCH.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(272, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Büyük Harf Karakterleri Dahil Et:";
            // 
            // küçükHarfCH
            // 
            this.küçükHarfCH.AutoSize = true;
            this.küçükHarfCH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.küçükHarfCH.Location = new System.Drawing.Point(284, 189);
            this.küçükHarfCH.Name = "küçükHarfCH";
            this.küçükHarfCH.Size = new System.Drawing.Size(104, 17);
            this.küçükHarfCH.TabIndex = 12;
            this.küçükHarfCH.Text = "( e.g. abcdefgh )";
            this.küçükHarfCH.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Küçük Harf Karakterleri Dahil Et:";
            // 
            // numaraCH
            // 
            this.numaraCH.AutoSize = true;
            this.numaraCH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numaraCH.Location = new System.Drawing.Point(284, 162);
            this.numaraCH.Name = "numaraCH";
            this.numaraCH.Size = new System.Drawing.Size(95, 17);
            this.numaraCH.TabIndex = 10;
            this.numaraCH.Text = "( e.g. 123456 )";
            this.numaraCH.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Numaraları Dahil Et:";
            // 
            // sembolCH
            // 
            this.sembolCH.AutoSize = true;
            this.sembolCH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sembolCH.Location = new System.Drawing.Point(284, 135);
            this.sembolCH.Name = "sembolCH";
            this.sembolCH.Size = new System.Drawing.Size(91, 17);
            this.sembolCH.TabIndex = 8;
            this.sembolCH.Text = "( e.g. @#$% )";
            this.sembolCH.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sembolleri Dahil Et:";
            // 
            // numberLenghCombo
            // 
            this.numberLenghCombo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numberLenghCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numberLenghCombo.FormattingEnabled = true;
            this.numberLenghCombo.Location = new System.Drawing.Point(140, 96);
            this.numberLenghCombo.Name = "numberLenghCombo";
            this.numberLenghCombo.Size = new System.Drawing.Size(157, 21);
            this.numberLenghCombo.TabIndex = 6;
            this.numberLenghCombo.TabStop = false;
            this.numberLenghCombo.SelectedIndexChanged += new System.EventHandler(this.numberLenghCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre uzunluğu:";
            // 
            // langCombo
            // 
            this.langCombo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.langCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.langCombo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.langCombo.FormattingEnabled = true;
            this.langCombo.Location = new System.Drawing.Point(265, 3);
            this.langCombo.Name = "langCombo";
            this.langCombo.Size = new System.Drawing.Size(114, 22);
            this.langCombo.TabIndex = 4;
            this.langCombo.TabStop = false;
            this.langCombo.SelectedIndexChanged += new System.EventHandler(this.langCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(79, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Güvenli Şifre Oluşturucu";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(3, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 11);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Passwd_Generator.Properties.Resources.secure;
            this.pictureBox1.Location = new System.Drawing.Point(9, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(438, 496);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswdGenerator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox langCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox numberLenghCombo;
        private System.Windows.Forms.CheckBox sembolCH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox küçükHarfCH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox numaraCH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox büyükHarfCH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button passGeneratorBTN;
        private System.Windows.Forms.Button CopyBTN;
        private System.Windows.Forms.TextBox newText;
        private System.Windows.Forms.Label label7;
    }
}

