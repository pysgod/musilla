namespace musilla
{
    partial class tursariklari
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
            this.tursarkilariDGV = new System.Windows.Forms.DataGridView();
            this.turlistgeritus = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tsbegenilenlereeklebtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tursarkilariDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tursarkilariDGV
            // 
            this.tursarkilariDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tursarkilariDGV.Location = new System.Drawing.Point(5, 63);
            this.tursarkilariDGV.Name = "tursarkilariDGV";
            this.tursarkilariDGV.ReadOnly = true;
            this.tursarkilariDGV.Size = new System.Drawing.Size(593, 375);
            this.tursarkilariDGV.TabIndex = 20;
            // 
            // turlistgeritus
            // 
            this.turlistgeritus.Location = new System.Drawing.Point(11, 6);
            this.turlistgeritus.Name = "turlistgeritus";
            this.turlistgeritus.Size = new System.Drawing.Size(75, 23);
            this.turlistgeritus.TabIndex = 19;
            this.turlistgeritus.Text = "Geri Git";
            this.turlistgeritus.UseVisualStyleBackColor = true;
            this.turlistgeritus.Click += new System.EventHandler(this.turlistgeritus_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Şarkılar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(360, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tür Şarkıları";
            // 
            // tsbegenilenlereeklebtn
            // 
            this.tsbegenilenlereeklebtn.Location = new System.Drawing.Point(604, 63);
            this.tsbegenilenlereeklebtn.Name = "tsbegenilenlereeklebtn";
            this.tsbegenilenlereeklebtn.Size = new System.Drawing.Size(107, 34);
            this.tsbegenilenlereeklebtn.TabIndex = 21;
            this.tsbegenilenlereeklebtn.Text = "Seçileni Beğenilen Şarkılara Ekle\r\n";
            this.tsbegenilenlereeklebtn.UseVisualStyleBackColor = true;
            this.tsbegenilenlereeklebtn.Click += new System.EventHandler(this.tsbegenilenlereeklebtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(604, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 34);
            this.button1.TabIndex = 22;
            this.button1.Text = "Seçileni Çalma Listesine Ekle\r\n\r\n";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tursariklari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tsbegenilenlereeklebtn);
            this.Controls.Add(this.tursarkilariDGV);
            this.Controls.Add(this.turlistgeritus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tursariklari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tursariklari";
            this.Load += new System.EventHandler(this.tursariklari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tursarkilariDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tursarkilariDGV;
        private System.Windows.Forms.Button turlistgeritus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tsbegenilenlereeklebtn;
        private System.Windows.Forms.Button button1;
    }
}