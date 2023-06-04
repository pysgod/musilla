namespace musilla
{
    partial class calmalistesi
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
            this.sarkilarDGV = new System.Windows.Forms.DataGridView();
            this.clgeritus = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cikarbuton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sarkilarDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // sarkilarDGV
            // 
            this.sarkilarDGV.AllowUserToAddRows = false;
            this.sarkilarDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.sarkilarDGV.Location = new System.Drawing.Point(5, 63);
            this.sarkilarDGV.Name = "sarkilarDGV";
            this.sarkilarDGV.ReadOnly = true;
            this.sarkilarDGV.RowHeadersVisible = false;
            this.sarkilarDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.sarkilarDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sarkilarDGV.Size = new System.Drawing.Size(783, 265);
            this.sarkilarDGV.TabIndex = 13;
            this.sarkilarDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sarkilarDGV_CellClick);
            this.sarkilarDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sarkilarDGV_CellContentClick);
            this.sarkilarDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sarkilarDGV_CellDoubleClick);
            // 
            // clgeritus
            // 
            this.clgeritus.Location = new System.Drawing.Point(11, 6);
            this.clgeritus.Name = "clgeritus";
            this.clgeritus.Size = new System.Drawing.Size(75, 23);
            this.clgeritus.TabIndex = 12;
            this.clgeritus.Text = "Geri Git";
            this.clgeritus.UseVisualStyleBackColor = true;
            this.clgeritus.Click += new System.EventHandler(this.clgeritus_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Çalma Listeleri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(349, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Çalma Listesi";
            // 
            // cikarbuton
            // 
            this.cikarbuton.Location = new System.Drawing.Point(5, 335);
            this.cikarbuton.Name = "cikarbuton";
            this.cikarbuton.Size = new System.Drawing.Size(113, 34);
            this.cikarbuton.TabIndex = 14;
            this.cikarbuton.Text = "Listeden Çıkar";
            this.cikarbuton.UseVisualStyleBackColor = true;
            this.cikarbuton.Click += new System.EventHandler(this.cikarbuton_Click);
            // 
            // calmalistesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cikarbuton);
            this.Controls.Add(this.sarkilarDGV);
            this.Controls.Add(this.clgeritus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "calmalistesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "calmalistesi";
            this.Load += new System.EventHandler(this.calmalistesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sarkilarDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView sarkilarDGV;
        private System.Windows.Forms.Button clgeritus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cikarbuton;
    }
}