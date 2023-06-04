namespace musilla
{
    partial class arama
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.aramatxt = new System.Windows.Forms.TextBox();
            this.aramabuton = new System.Windows.Forms.Button();
            this.sarkilarDGV = new System.Windows.Forms.DataGridView();
            this.turlerDGV = new System.Windows.Forms.DataGridView();
            this.sanatcilarDGV = new System.Windows.Forms.DataGridView();
            this.sarkilarlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.albumlerDGV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.kullanicilarDGV = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sarkilarDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turlerDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanatcilarDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumlerDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // aramatxt
            // 
            this.aramatxt.Location = new System.Drawing.Point(12, 11);
            this.aramatxt.Multiline = true;
            this.aramatxt.Name = "aramatxt";
            this.aramatxt.Size = new System.Drawing.Size(488, 20);
            this.aramatxt.TabIndex = 0;
            // 
            // aramabuton
            // 
            this.aramabuton.Location = new System.Drawing.Point(506, 11);
            this.aramabuton.Name = "aramabuton";
            this.aramabuton.Size = new System.Drawing.Size(75, 20);
            this.aramabuton.TabIndex = 1;
            this.aramabuton.Text = "Ara";
            this.aramabuton.UseVisualStyleBackColor = true;
            this.aramabuton.Click += new System.EventHandler(this.aramabuton_Click);
            // 
            // sarkilarDGV
            // 
            this.sarkilarDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.sarkilarDGV.Location = new System.Drawing.Point(5, 59);
            this.sarkilarDGV.Name = "sarkilarDGV";
            this.sarkilarDGV.ReadOnly = true;
            this.sarkilarDGV.RowHeadersVisible = false;
            this.sarkilarDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.sarkilarDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sarkilarDGV.Size = new System.Drawing.Size(997, 110);
            this.sarkilarDGV.TabIndex = 2;
            this.sarkilarDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sarkilarDGV_CellClick);
            this.sarkilarDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sarkilarDGV_CellContentClick);
            this.sarkilarDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sarkilarDGV_CellDoubleClick);
            // 
            // turlerDGV
            // 
            this.turlerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.turlerDGV.Location = new System.Drawing.Point(1008, 59);
            this.turlerDGV.Name = "turlerDGV";
            this.turlerDGV.ReadOnly = true;
            this.turlerDGV.RowHeadersVisible = false;
            this.turlerDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.turlerDGV.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.turlerDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.turlerDGV.Size = new System.Drawing.Size(113, 374);
            this.turlerDGV.TabIndex = 3;
            this.turlerDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.turlerDGV_CellClick);
            // 
            // sanatcilarDGV
            // 
            this.sanatcilarDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.sanatcilarDGV.Location = new System.Drawing.Point(5, 192);
            this.sanatcilarDGV.Name = "sanatcilarDGV";
            this.sanatcilarDGV.ReadOnly = true;
            this.sanatcilarDGV.RowHeadersVisible = false;
            this.sanatcilarDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.sanatcilarDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sanatcilarDGV.Size = new System.Drawing.Size(344, 241);
            this.sanatcilarDGV.TabIndex = 13;
            this.sanatcilarDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sanatcilarDGV_CellClick);
            this.sanatcilarDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sanatcilarDGV_CellDoubleClick);
            // 
            // sarkilarlbl
            // 
            this.sarkilarlbl.AutoSize = true;
            this.sarkilarlbl.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sarkilarlbl.Location = new System.Drawing.Point(2, 39);
            this.sarkilarlbl.Name = "sarkilarlbl";
            this.sarkilarlbl.Size = new System.Drawing.Size(55, 17);
            this.sarkilarlbl.TabIndex = 14;
            this.sarkilarlbl.Text = "Şarkılar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Sanatçılar";
            // 
            // albumlerDGV
            // 
            this.albumlerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.albumlerDGV.Location = new System.Drawing.Point(355, 192);
            this.albumlerDGV.Name = "albumlerDGV";
            this.albumlerDGV.ReadOnly = true;
            this.albumlerDGV.RowHeadersVisible = false;
            this.albumlerDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.albumlerDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.albumlerDGV.Size = new System.Drawing.Size(344, 241);
            this.albumlerDGV.TabIndex = 16;
            this.albumlerDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.albumlerDGV_CellClick);
            this.albumlerDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.albumlerDGV_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(352, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Albümler";
            // 
            // kullanicilarDGV
            // 
            this.kullanicilarDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.kullanicilarDGV.Location = new System.Drawing.Point(705, 192);
            this.kullanicilarDGV.Name = "kullanicilarDGV";
            this.kullanicilarDGV.ReadOnly = true;
            this.kullanicilarDGV.RowHeadersVisible = false;
            this.kullanicilarDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.kullanicilarDGV.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.kullanicilarDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kullanicilarDGV.Size = new System.Drawing.Size(297, 241);
            this.kullanicilarDGV.TabIndex = 18;
            this.kullanicilarDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kullanicilarDGV_CellClick);
            this.kullanicilarDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kullanicilarDGV_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(702, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Kullanıcılar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1008, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Türler";
            // 
            // arama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kullanicilarDGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.albumlerDGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sarkilarlbl);
            this.Controls.Add(this.sanatcilarDGV);
            this.Controls.Add(this.turlerDGV);
            this.Controls.Add(this.sarkilarDGV);
            this.Controls.Add(this.aramabuton);
            this.Controls.Add(this.aramatxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "arama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çalma Listesine Ekle";
            this.Load += new System.EventHandler(this.arama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sarkilarDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turlerDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanatcilarDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumlerDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox aramatxt;
        private System.Windows.Forms.Button aramabuton;
        private System.Windows.Forms.DataGridView sarkilarDGV;
        private System.Windows.Forms.DataGridView turlerDGV;
        private System.Windows.Forms.DataGridView sanatcilarDGV;
        private System.Windows.Forms.Label sarkilarlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView albumlerDGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView kullanicilarDGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}