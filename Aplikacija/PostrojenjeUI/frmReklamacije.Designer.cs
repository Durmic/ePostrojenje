namespace PostrojenjeUI
{
    partial class frmReklamacije
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
            this.components = new System.ComponentModel.Container();
            this.dgvReklamacije = new System.Windows.Forms.DataGridView();
            this.ReklamacijaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PodnosilacId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.kupciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Naslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumOtvaranja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zavrsena = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.rtxOpis = new System.Windows.Forms.RichTextBox();
            this.cbxStatus = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbOsoblje = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpZatvaranja = new System.Windows.Forms.DateTimePicker();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvPreporuceni = new System.Windows.Forms.DataGridView();
            this.PreporucenaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KupacId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Otvorena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupbox2 = new System.Windows.Forms.GroupBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReklamacije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreporuceni)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupbox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvReklamacije
            // 
            this.dgvReklamacije.AllowUserToAddRows = false;
            this.dgvReklamacije.AllowUserToDeleteRows = false;
            this.dgvReklamacije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReklamacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReklamacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReklamacijaId,
            this.PodnosilacId,
            this.Naslov,
            this.DatumOtvaranja,
            this.Zavrsena});
            this.dgvReklamacije.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReklamacije.Location = new System.Drawing.Point(3, 22);
            this.dgvReklamacije.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvReklamacije.MultiSelect = false;
            this.dgvReklamacije.Name = "dgvReklamacije";
            this.dgvReklamacije.ReadOnly = true;
            this.dgvReklamacije.RowHeadersVisible = false;
            this.dgvReklamacije.RowTemplate.Height = 27;
            this.dgvReklamacije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReklamacije.Size = new System.Drawing.Size(725, 236);
            this.dgvReklamacije.TabIndex = 0;
            this.dgvReklamacije.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReklamacije_CellClick);
            this.dgvReklamacije.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvReklamacije_CellMouseDoubleClick_1);
            // 
            // ReklamacijaId
            // 
            this.ReklamacijaId.DataPropertyName = "ReklamacijaId";
            this.ReklamacijaId.HeaderText = "ReklamacijaId";
            this.ReklamacijaId.Name = "ReklamacijaId";
            this.ReklamacijaId.ReadOnly = true;
            this.ReklamacijaId.Visible = false;
            // 
            // PodnosilacId
            // 
            this.PodnosilacId.DataPropertyName = "KupacId";
            this.PodnosilacId.DataSource = this.kupciBindingSource;
            this.PodnosilacId.DisplayMember = "KorisnickoIme";
            this.PodnosilacId.HeaderText = "Podnosilac";
            this.PodnosilacId.Name = "PodnosilacId";
            this.PodnosilacId.ReadOnly = true;
            this.PodnosilacId.ValueMember = "KupacId";
            // 
            // kupciBindingSource
            // 
            this.kupciBindingSource.DataSource = typeof(ePostrojenje.Model.Kupci);
            this.kupciBindingSource.CurrentChanged += new System.EventHandler(this.kupciBindingSource_CurrentChanged);
            // 
            // Naslov
            // 
            this.Naslov.DataPropertyName = "Naslov";
            this.Naslov.HeaderText = "Naslov";
            this.Naslov.Name = "Naslov";
            this.Naslov.ReadOnly = true;
            // 
            // DatumOtvaranja
            // 
            this.DatumOtvaranja.DataPropertyName = "DatumOtvaranja";
            this.DatumOtvaranja.HeaderText = "Otvorena";
            this.DatumOtvaranja.Name = "DatumOtvaranja";
            this.DatumOtvaranja.ReadOnly = true;
            // 
            // Zavrsena
            // 
            this.Zavrsena.DataPropertyName = "Status";
            this.Zavrsena.HeaderText = "Zavrsena";
            this.Zavrsena.Name = "Zavrsena";
            this.Zavrsena.ReadOnly = true;
            this.Zavrsena.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Zavrsena.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(837, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Opis";
            // 
            // rtxOpis
            // 
            this.rtxOpis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rtxOpis.Location = new System.Drawing.Point(840, 204);
            this.rtxOpis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtxOpis.Name = "rtxOpis";
            this.rtxOpis.Size = new System.Drawing.Size(390, 168);
            this.rtxOpis.TabIndex = 19;
            this.rtxOpis.Text = "";
            // 
            // cbxStatus
            // 
            this.cbxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxStatus.AutoSize = true;
            this.cbxStatus.Location = new System.Drawing.Point(840, 149);
            this.cbxStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(221, 19);
            this.cbxStatus.TabIndex = 18;
            this.cbxStatus.Text = "Reklamacija je zavrsena?";
            this.cbxStatus.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(837, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Osoblje";
            // 
            // cmbOsoblje
            // 
            this.cmbOsoblje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbOsoblje.FormattingEnabled = true;
            this.cmbOsoblje.Location = new System.Drawing.Point(840, 100);
            this.cmbOsoblje.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbOsoblje.Name = "cmbOsoblje";
            this.cmbOsoblje.Size = new System.Drawing.Size(205, 23);
            this.cmbOsoblje.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(837, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Datum zatvaranja";
            // 
            // dtpZatvaranja
            // 
            this.dtpZatvaranja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpZatvaranja.Location = new System.Drawing.Point(840, 35);
            this.dtpZatvaranja.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpZatvaranja.Name = "dtpZatvaranja";
            this.dtpZatvaranja.Size = new System.Drawing.Size(205, 25);
            this.dtpZatvaranja.TabIndex = 14;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1007, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 35);
            this.btnClose.TabIndex = 34;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvPreporuceni
            // 
            this.dgvPreporuceni.AllowUserToAddRows = false;
            this.dgvPreporuceni.AllowUserToDeleteRows = false;
            this.dgvPreporuceni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPreporuceni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreporuceni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PreporucenaId,
            this.KupacId,
            this.Naziv,
            this.Otvorena,
            this.Status});
            this.dgvPreporuceni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPreporuceni.Location = new System.Drawing.Point(3, 22);
            this.dgvPreporuceni.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPreporuceni.Name = "dgvPreporuceni";
            this.dgvPreporuceni.ReadOnly = true;
            this.dgvPreporuceni.RowTemplate.Height = 27;
            this.dgvPreporuceni.Size = new System.Drawing.Size(725, 183);
            this.dgvPreporuceni.TabIndex = 0;
            // 
            // PreporucenaId
            // 
            this.PreporucenaId.DataPropertyName = "ReklamacijaId";
            this.PreporucenaId.HeaderText = "ReklamacijaId";
            this.PreporucenaId.Name = "PreporucenaId";
            this.PreporucenaId.ReadOnly = true;
            this.PreporucenaId.Visible = false;
            // 
            // KupacId
            // 
            this.KupacId.DataPropertyName = "KupacId";
            this.KupacId.DataSource = this.kupciBindingSource;
            this.KupacId.DisplayMember = "KorisnickoIme";
            this.KupacId.HeaderText = "Podnosilac";
            this.KupacId.Name = "KupacId";
            this.KupacId.ReadOnly = true;
            this.KupacId.ValueMember = "KupacId";
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naslov";
            this.Naziv.HeaderText = "Naslov";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Otvorena
            // 
            this.Otvorena.DataPropertyName = "DatumOtvaranja";
            this.Otvorena.HeaderText = "Otvorena";
            this.Otvorena.Name = "Otvorena";
            this.Otvorena.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPreporuceni);
            this.groupBox1.Location = new System.Drawing.Point(23, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(731, 209);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preporuceni";
            // 
            // groupbox2
            // 
            this.groupbox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupbox2.Controls.Add(this.dgvReklamacije);
            this.groupbox2.Location = new System.Drawing.Point(23, 153);
            this.groupbox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupbox2.Name = "groupbox2";
            this.groupbox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupbox2.Size = new System.Drawing.Size(731, 262);
            this.groupbox2.TabIndex = 21;
            this.groupbox2.TabStop = false;
            this.groupbox2.Text = "Reklamacije";
            // 
            // btnSpremi
            // 
            this.btnSpremi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSpremi.Location = new System.Drawing.Point(929, 380);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(116, 35);
            this.btnSpremi.TabIndex = 48;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUredi.Location = new System.Drawing.Point(26, 442);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(103, 37);
            this.btnUredi.TabIndex = 49;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // frmReklamacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1116, 519);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupbox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtxOpis);
            this.Controls.Add(this.cbxStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbOsoblje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpZatvaranja);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmReklamacije";
            this.Text = "frmReklamacije";
            this.Load += new System.EventHandler(this.frmReklamacije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReklamacije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreporuceni)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupbox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvReklamacije;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtxOpis;
        private System.Windows.Forms.CheckBox cbxStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbOsoblje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpZatvaranja;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvPreporuceni;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupbox2;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.BindingSource kupciBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreporucenaId;
        private System.Windows.Forms.DataGridViewComboBoxColumn KupacId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Otvorena;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReklamacijaId;
        private System.Windows.Forms.DataGridViewComboBoxColumn PodnosilacId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumOtvaranja;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Zavrsena;
    }
}