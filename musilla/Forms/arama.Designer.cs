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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sarkilarlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchButton = new Guna.UI2.WinForms.Guna2Button();
            this.SearchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.sarkilarDGV = new System.Windows.Forms.DataGridView();
            this.sarkiID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baslik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanatcilar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanatcilarDGV = new System.Windows.Forms.DataGridView();
            this.Kimlik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanatcilarDGVsanatcilar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adsoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullanicilarDGV = new System.Windows.Forms.DataGridView();
            this.kulalniciID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddSongtoList = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.sarkilarDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanatcilarDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // sarkilarlbl
            // 
            this.sarkilarlbl.AutoSize = true;
            this.sarkilarlbl.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sarkilarlbl.Location = new System.Drawing.Point(2, 100);
            this.sarkilarlbl.Name = "sarkilarlbl";
            this.sarkilarlbl.Size = new System.Drawing.Size(55, 17);
            this.sarkilarlbl.TabIndex = 14;
            this.sarkilarlbl.Text = "Şarkılar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Sanatçılar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(804, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Kullanıcılar";
            // 
            // SearchButton
            // 
            this.SearchButton.Animated = true;
            this.SearchButton.AutoRoundedCorners = true;
            this.SearchButton.BackColor = System.Drawing.Color.Transparent;
            this.SearchButton.BorderRadius = 17;
            this.SearchButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SearchButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SearchButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SearchButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SearchButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(222)))), ((int)(((byte)(177)))));
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Image = global::musilla.Properties.Resources.icons8_search_52;
            this.SearchButton.ImageSize = new System.Drawing.Size(25, 25);
            this.SearchButton.Location = new System.Drawing.Point(537, 45);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(77, 36);
            this.SearchButton.TabIndex = 21;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.AutoRoundedCorners = true;
            this.SearchBox.BorderRadius = 17;
            this.SearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchBox.DefaultText = "";
            this.SearchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchBox.Location = new System.Drawing.Point(12, 45);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.PasswordChar = '\0';
            this.SearchBox.PlaceholderText = "";
            this.SearchBox.SelectedText = "";
            this.SearchBox.Size = new System.Drawing.Size(519, 36);
            this.SearchBox.TabIndex = 22;
            // 
            // sarkilarDGV
            // 
            this.sarkilarDGV.AllowUserToAddRows = false;
            this.sarkilarDGV.AllowUserToDeleteRows = false;
            this.sarkilarDGV.AllowUserToResizeColumns = false;
            this.sarkilarDGV.AllowUserToResizeRows = false;
            this.sarkilarDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.sarkilarDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sarkilarDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(222)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sarkilarDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.sarkilarDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.sarkilarDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sarkiID,
            this.baslik,
            this.sanatcilar,
            this.albumler,
            this.tur,
            this.sure});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(222)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sarkilarDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.sarkilarDGV.GridColor = System.Drawing.Color.White;
            this.sarkilarDGV.Location = new System.Drawing.Point(5, 120);
            this.sarkilarDGV.MultiSelect = false;
            this.sarkilarDGV.Name = "sarkilarDGV";
            this.sarkilarDGV.ReadOnly = true;
            this.sarkilarDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(222)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sarkilarDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.sarkilarDGV.RowHeadersVisible = false;
            this.sarkilarDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(222)))), ((int)(((byte)(177)))));
            this.sarkilarDGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.sarkilarDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sarkilarDGV.Size = new System.Drawing.Size(1068, 195);
            this.sarkilarDGV.TabIndex = 23;
            this.sarkilarDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sarkilarDGV_CellClick_1);
            this.sarkilarDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sarkilarDGV_CellDoubleClick_1);
            // 
            // sarkiID
            // 
            this.sarkiID.HeaderText = "sarkiID";
            this.sarkiID.Name = "sarkiID";
            this.sarkiID.ReadOnly = true;
            this.sarkiID.Visible = false;
            // 
            // baslik
            // 
            this.baslik.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.baslik.FillWeight = 50F;
            this.baslik.HeaderText = "Başlık";
            this.baslik.Name = "baslik";
            this.baslik.ReadOnly = true;
            // 
            // sanatcilar
            // 
            this.sanatcilar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sanatcilar.HeaderText = "Sanatcilar";
            this.sanatcilar.Name = "sanatcilar";
            this.sanatcilar.ReadOnly = true;
            // 
            // albumler
            // 
            this.albumler.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.albumler.HeaderText = "Albümler";
            this.albumler.Name = "albumler";
            this.albumler.ReadOnly = true;
            this.albumler.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tur
            // 
            this.tur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tur.HeaderText = "Tür";
            this.tur.Name = "tur";
            this.tur.ReadOnly = true;
            // 
            // sure
            // 
            this.sure.HeaderText = "🕒";
            this.sure.Name = "sure";
            this.sure.ReadOnly = true;
            // 
            // sanatcilarDGV
            // 
            this.sanatcilarDGV.AllowUserToAddRows = false;
            this.sanatcilarDGV.AllowUserToDeleteRows = false;
            this.sanatcilarDGV.AllowUserToResizeColumns = false;
            this.sanatcilarDGV.AllowUserToResizeRows = false;
            this.sanatcilarDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.sanatcilarDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sanatcilarDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(222)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sanatcilarDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.sanatcilarDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.sanatcilarDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kimlik,
            this.sanatcilarDGVsanatcilar,
            this.adsoyad});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(222)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sanatcilarDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.sanatcilarDGV.GridColor = System.Drawing.Color.White;
            this.sanatcilarDGV.Location = new System.Drawing.Point(5, 338);
            this.sanatcilarDGV.MultiSelect = false;
            this.sanatcilarDGV.Name = "sanatcilarDGV";
            this.sanatcilarDGV.ReadOnly = true;
            this.sanatcilarDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(222)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sanatcilarDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.sanatcilarDGV.RowHeadersVisible = false;
            this.sanatcilarDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(222)))), ((int)(((byte)(177)))));
            this.sanatcilarDGV.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.sanatcilarDGV.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.sanatcilarDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sanatcilarDGV.Size = new System.Drawing.Size(793, 303);
            this.sanatcilarDGV.TabIndex = 24;
            this.sanatcilarDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sanatcilarDGV_CellClick_1);
            // 
            // Kimlik
            // 
            this.Kimlik.HeaderText = "Kimlik";
            this.Kimlik.Name = "Kimlik";
            this.Kimlik.ReadOnly = true;
            this.Kimlik.Visible = false;
            // 
            // sanatcilarDGVsanatcilar
            // 
            this.sanatcilarDGVsanatcilar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sanatcilarDGVsanatcilar.FillWeight = 50F;
            this.sanatcilarDGVsanatcilar.HeaderText = "Sanatcilar";
            this.sanatcilarDGVsanatcilar.Name = "sanatcilarDGVsanatcilar";
            this.sanatcilarDGVsanatcilar.ReadOnly = true;
            // 
            // adsoyad
            // 
            this.adsoyad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.adsoyad.HeaderText = "Adı Soyadı";
            this.adsoyad.Name = "adsoyad";
            this.adsoyad.ReadOnly = true;
            this.adsoyad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // kullanicilarDGV
            // 
            this.kullanicilarDGV.AllowUserToAddRows = false;
            this.kullanicilarDGV.AllowUserToDeleteRows = false;
            this.kullanicilarDGV.AllowUserToResizeColumns = false;
            this.kullanicilarDGV.AllowUserToResizeRows = false;
            this.kullanicilarDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.kullanicilarDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kullanicilarDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(222)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.kullanicilarDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.kullanicilarDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.kullanicilarDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kulalniciID,
            this.kullaniciadi});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(222)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.kullanicilarDGV.DefaultCellStyle = dataGridViewCellStyle10;
            this.kullanicilarDGV.GridColor = System.Drawing.Color.White;
            this.kullanicilarDGV.Location = new System.Drawing.Point(804, 338);
            this.kullanicilarDGV.MultiSelect = false;
            this.kullanicilarDGV.Name = "kullanicilarDGV";
            this.kullanicilarDGV.ReadOnly = true;
            this.kullanicilarDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(222)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.kullanicilarDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.kullanicilarDGV.RowHeadersVisible = false;
            this.kullanicilarDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(222)))), ((int)(((byte)(177)))));
            this.kullanicilarDGV.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.kullanicilarDGV.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.kullanicilarDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kullanicilarDGV.Size = new System.Drawing.Size(269, 303);
            this.kullanicilarDGV.TabIndex = 25;
            this.kullanicilarDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kullanicilarDGV_CellClick);
            // 
            // kulalniciID
            // 
            this.kulalniciID.HeaderText = "kullaniciID";
            this.kulalniciID.Name = "kulalniciID";
            this.kulalniciID.ReadOnly = true;
            this.kulalniciID.Visible = false;
            // 
            // kullaniciadi
            // 
            this.kullaniciadi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kullaniciadi.FillWeight = 50F;
            this.kullaniciadi.HeaderText = "Kullanıcılar";
            this.kullaniciadi.Name = "kullaniciadi";
            this.kullaniciadi.ReadOnly = true;
            // 
            // AddSongtoList
            // 
            this.AddSongtoList.Animated = true;
            this.AddSongtoList.AutoRoundedCorners = true;
            this.AddSongtoList.BackColor = System.Drawing.Color.Transparent;
            this.AddSongtoList.BorderRadius = 18;
            this.AddSongtoList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddSongtoList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddSongtoList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddSongtoList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddSongtoList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(222)))), ((int)(((byte)(177)))));
            this.AddSongtoList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddSongtoList.ForeColor = System.Drawing.Color.White;
            this.AddSongtoList.Image = global::musilla.Properties.Resources.icons8_add_50;
            this.AddSongtoList.ImageSize = new System.Drawing.Size(25, 25);
            this.AddSongtoList.Location = new System.Drawing.Point(919, 78);
            this.AddSongtoList.Name = "AddSongtoList";
            this.AddSongtoList.Size = new System.Drawing.Size(154, 39);
            this.AddSongtoList.TabIndex = 26;
            this.AddSongtoList.Text = "Çalma Listesine Ekle";
            // 
            // arama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1085, 650);
            this.Controls.Add(this.AddSongtoList);
            this.Controls.Add(this.kullanicilarDGV);
            this.Controls.Add(this.sanatcilarDGV);
            this.Controls.Add(this.sarkilarDGV);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sarkilarlbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "arama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çalma Listesine Ekle";
            this.Load += new System.EventHandler(this.arama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sarkilarDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanatcilarDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label sarkilarlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button SearchButton;
        private Guna.UI2.WinForms.Guna2TextBox SearchBox;
        private System.Windows.Forms.DataGridView sanatcilarDGV;
        public System.Windows.Forms.DataGridView sarkilarDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sarkiID;
        private System.Windows.Forms.DataGridViewTextBoxColumn baslik;
        private System.Windows.Forms.DataGridViewTextBoxColumn sanatcilar;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumler;
        private System.Windows.Forms.DataGridViewTextBoxColumn tur;
        private System.Windows.Forms.DataGridViewTextBoxColumn sure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kimlik;
        private System.Windows.Forms.DataGridViewTextBoxColumn sanatcilarDGVsanatcilar;
        private System.Windows.Forms.DataGridViewTextBoxColumn adsoyad;
        private System.Windows.Forms.DataGridView kullanicilarDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn kulalniciID;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciadi;
        private Guna.UI2.WinForms.Guna2Button AddSongtoList;
    }
}