namespace musilla.Forms
{
    partial class adminpanelsanatci
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.sanatcilarDGV = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanatci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eposta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.sanatcieklegroup = new System.Windows.Forms.GroupBox();
            this.sanatcieklebuton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sanatcidüzenlemegroup = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sanatcilarDGV)).BeginInit();
            this.sanatcieklegroup.SuspendLayout();
            this.sanatcidüzenlemegroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // sanatcilarDGV
            // 
            this.sanatcilarDGV.AllowUserToAddRows = false;
            this.sanatcilarDGV.AllowUserToDeleteRows = false;
            this.sanatcilarDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.sanatcilarDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.sanatci,
            this.ad,
            this.soyad,
            this.eposta,
            this.sifre});
            this.sanatcilarDGV.Location = new System.Drawing.Point(3, 85);
            this.sanatcilarDGV.Name = "sanatcilarDGV";
            this.sanatcilarDGV.ReadOnly = true;
            this.sanatcilarDGV.RowHeadersVisible = false;
            this.sanatcilarDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.sanatcilarDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sanatcilarDGV.Size = new System.Drawing.Size(1064, 185);
            this.sanatcilarDGV.TabIndex = 0;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.FillWeight = 20F;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // sanatci
            // 
            this.sanatci.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sanatci.FillWeight = 46.90354F;
            this.sanatci.HeaderText = "Sanatçılar";
            this.sanatci.Name = "sanatci";
            this.sanatci.ReadOnly = true;
            // 
            // ad
            // 
            this.ad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ad.FillWeight = 46.90354F;
            this.ad.HeaderText = "Ad";
            this.ad.Name = "ad";
            this.ad.ReadOnly = true;
            // 
            // soyad
            // 
            this.soyad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soyad.FillWeight = 46.90354F;
            this.soyad.HeaderText = "Soyad";
            this.soyad.Name = "soyad";
            this.soyad.ReadOnly = true;
            // 
            // eposta
            // 
            this.eposta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.eposta.FillWeight = 46.90354F;
            this.eposta.HeaderText = "Mail";
            this.eposta.Name = "eposta";
            this.eposta.ReadOnly = true;
            // 
            // sifre
            // 
            this.sifre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sifre.FillWeight = 46.90354F;
            this.sifre.HeaderText = "Parola";
            this.sifre.Name = "sifre";
            this.sifre.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SANATÇILAR";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(491, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(239, 278);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 45);
            this.button3.TabIndex = 4;
            this.button3.Text = "Düzenle";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // sanatcieklegroup
            // 
            this.sanatcieklegroup.Controls.Add(this.sanatcieklebuton);
            this.sanatcieklegroup.Controls.Add(this.label5);
            this.sanatcieklegroup.Controls.Add(this.textBox4);
            this.sanatcieklegroup.Controls.Add(this.label4);
            this.sanatcieklegroup.Controls.Add(this.label3);
            this.sanatcieklegroup.Controls.Add(this.label2);
            this.sanatcieklegroup.Controls.Add(this.textBox3);
            this.sanatcieklegroup.Controls.Add(this.textBox2);
            this.sanatcieklegroup.Controls.Add(this.textBox1);
            this.sanatcieklegroup.Location = new System.Drawing.Point(6, 329);
            this.sanatcieklegroup.Name = "sanatcieklegroup";
            this.sanatcieklegroup.Size = new System.Drawing.Size(200, 388);
            this.sanatcieklegroup.TabIndex = 5;
            this.sanatcieklegroup.TabStop = false;
            this.sanatcieklegroup.Text = "Ekleme";
            // 
            // sanatcieklebuton
            // 
            this.sanatcieklebuton.Location = new System.Drawing.Point(6, 250);
            this.sanatcieklebuton.Name = "sanatcieklebuton";
            this.sanatcieklebuton.Size = new System.Drawing.Size(187, 23);
            this.sanatcieklebuton.TabIndex = 8;
            this.sanatcieklebuton.Text = "Ekle";
            this.sanatcieklebuton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Password";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 182);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(187, 20);
            this.textBox4.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soyadı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adı";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 139);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(187, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(187, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 0;
            // 
            // sanatcidüzenlemegroup
            // 
            this.sanatcidüzenlemegroup.Controls.Add(this.button4);
            this.sanatcidüzenlemegroup.Controls.Add(this.label6);
            this.sanatcidüzenlemegroup.Controls.Add(this.textBox7);
            this.sanatcidüzenlemegroup.Controls.Add(this.textBox5);
            this.sanatcidüzenlemegroup.Controls.Add(this.textBox8);
            this.sanatcidüzenlemegroup.Controls.Add(this.label7);
            this.sanatcidüzenlemegroup.Controls.Add(this.textBox6);
            this.sanatcidüzenlemegroup.Controls.Add(this.label8);
            this.sanatcidüzenlemegroup.Controls.Add(this.label9);
            this.sanatcidüzenlemegroup.Location = new System.Drawing.Point(232, 329);
            this.sanatcidüzenlemegroup.Name = "sanatcidüzenlemegroup";
            this.sanatcidüzenlemegroup.Size = new System.Drawing.Size(200, 388);
            this.sanatcidüzenlemegroup.TabIndex = 7;
            this.sanatcidüzenlemegroup.TabStop = false;
            this.sanatcidüzenlemegroup.Text = "Düzenleme";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 248);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(187, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Kaydet";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Password";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(7, 94);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(187, 20);
            this.textBox7.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(7, 180);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(187, 20);
            this.textBox5.TabIndex = 15;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(7, 51);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(187, 20);
            this.textBox8.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Mail";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(7, 137);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(187, 20);
            this.textBox6.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Soyadı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Adı";
            // 
            // adminpanelsanatci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sanatcidüzenlemegroup);
            this.Controls.Add(this.sanatcieklegroup);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sanatcilarDGV);
            this.Name = "adminpanelsanatci";
            this.Size = new System.Drawing.Size(1070, 720);
            this.Load += new System.EventHandler(this.adminpanelsanatci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sanatcilarDGV)).EndInit();
            this.sanatcieklegroup.ResumeLayout(false);
            this.sanatcieklegroup.PerformLayout();
            this.sanatcidüzenlemegroup.ResumeLayout(false);
            this.sanatcidüzenlemegroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView sanatcilarDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sanatci;
        private System.Windows.Forms.DataGridViewTextBoxColumn ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn eposta;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox sanatcieklegroup;
        private System.Windows.Forms.Button sanatcieklebuton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox sanatcidüzenlemegroup;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}
