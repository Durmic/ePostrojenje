namespace PostrojenjeUI
{
    partial class frmUgovori
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPretraga = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDo = new System.Windows.Forms.DateTimePicker();
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.txtImeUnos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvOsoblje = new System.Windows.Forms.DataGridView();
            this.UgovorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojUgovora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumSklapanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.OsobljeId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.osobljeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KupacId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.kupciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TarifniStavId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tarifniStavoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rtxOpis = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpSklapanja = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSklopljen = new System.Windows.Forms.CheckBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOsoblje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.osobljeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarifniStavoviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Controls.Add(this.txtPretraga);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtpDo);
            this.groupBox1.Controls.Add(this.dtpOd);
            this.groupBox1.Location = new System.Drawing.Point(2, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 77);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registar ugovora";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(56, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 15);
            this.label11.TabIndex = 27;
            this.label11.Text = "Broj ugovora:";
            // 
            // txtIme
            // 
            this.txtIme.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtIme.Location = new System.Drawing.Point(194, 17);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(200, 25);
            this.txtIme.TabIndex = 6;
            // 
            // txtPretraga
            // 
            this.txtPretraga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPretraga.Location = new System.Drawing.Point(632, 42);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(132, 35);
            this.txtPretraga.TabIndex = 4;
            this.txtPretraga.Text = "Prikazi";
            this.txtPretraga.UseVisualStyleBackColor = true;
            this.txtPretraga.Click += new System.EventHandler(this.txtPretraga_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(397, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 15);
            this.label10.TabIndex = 26;
            this.label10.Text = "do";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(191, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Sklopljen u periodu: od";
            // 
            // dtpDo
            // 
            this.dtpDo.Location = new System.Drawing.Point(424, 49);
            this.dtpDo.Name = "dtpDo";
            this.dtpDo.Size = new System.Drawing.Size(200, 25);
            this.dtpDo.TabIndex = 24;
            // 
            // dtpOd
            // 
            this.dtpOd.Location = new System.Drawing.Point(194, 49);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(200, 25);
            this.dtpOd.TabIndex = 23;
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOtkazi.BackColor = System.Drawing.Color.White;
            this.btnOtkazi.Location = new System.Drawing.Point(815, 438);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(116, 35);
            this.btnOtkazi.TabIndex = 48;
            this.btnOtkazi.Text = "Otkazi";
            this.btnOtkazi.UseVisualStyleBackColor = false;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSpremi.Location = new System.Drawing.Point(948, 438);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(116, 35);
            this.btnSpremi.TabIndex = 47;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUredi.Location = new System.Drawing.Point(2, 479);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(132, 35);
            this.btnUredi.TabIndex = 46;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // txtImeUnos
            // 
            this.txtImeUnos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImeUnos.Location = new System.Drawing.Point(815, 108);
            this.txtImeUnos.Name = "txtImeUnos";
            this.txtImeUnos.Size = new System.Drawing.Size(249, 25);
            this.txtImeUnos.TabIndex = 35;
            this.txtImeUnos.Validating += new System.ComponentModel.CancelEventHandler(this.txtImeUnos_Validating);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(812, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 34;
            this.label1.Text = "Broj ugovora";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1007, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 35);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvOsoblje
            // 
            this.dgvOsoblje.AllowUserToAddRows = false;
            this.dgvOsoblje.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOsoblje.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOsoblje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOsoblje.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOsoblje.BackgroundColor = System.Drawing.Color.White;
            this.dgvOsoblje.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvOsoblje.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOsoblje.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOsoblje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOsoblje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UgovorId,
            this.BrojUgovora,
            this.DatumSklapanja,
            this.Status,
            this.OsobljeId,
            this.KupacId,
            this.TarifniStavId});
            this.dgvOsoblje.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOsoblje.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOsoblje.Location = new System.Drawing.Point(2, 121);
            this.dgvOsoblje.Name = "dgvOsoblje";
            this.dgvOsoblje.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOsoblje.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOsoblje.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOsoblje.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvOsoblje.RowTemplate.DividerHeight = 1;
            this.dgvOsoblje.RowTemplate.Height = 27;
            this.dgvOsoblje.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOsoblje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOsoblje.Size = new System.Drawing.Size(763, 352);
            this.dgvOsoblje.TabIndex = 32;
            this.dgvOsoblje.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOsoblje_CellMouseDoubleClick);
            // 
            // UgovorId
            // 
            this.UgovorId.DataPropertyName = "UgovorId";
            this.UgovorId.HeaderText = "UgovorId";
            this.UgovorId.Name = "UgovorId";
            this.UgovorId.ReadOnly = true;
            this.UgovorId.Visible = false;
            // 
            // BrojUgovora
            // 
            this.BrojUgovora.DataPropertyName = "BrojUgovora";
            this.BrojUgovora.HeaderText = "Šifra";
            this.BrojUgovora.Name = "BrojUgovora";
            this.BrojUgovora.ReadOnly = true;
            // 
            // DatumSklapanja
            // 
            this.DatumSklapanja.DataPropertyName = "DatumSklapanja";
            this.DatumSklapanja.HeaderText = "Sklopljen";
            this.DatumSklapanja.Name = "DatumSklapanja";
            this.DatumSklapanja.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Odobren?";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // OsobljeId
            // 
            this.OsobljeId.DataPropertyName = "OsobljeId";
            this.OsobljeId.DataSource = this.osobljeBindingSource;
            this.OsobljeId.DisplayMember = "KorisnickoIme";
            this.OsobljeId.HeaderText = "Osoblje";
            this.OsobljeId.Name = "OsobljeId";
            this.OsobljeId.ReadOnly = true;
            this.OsobljeId.ValueMember = "OsobljeId";
            // 
            // osobljeBindingSource
            // 
            this.osobljeBindingSource.DataSource = typeof(ePostrojenje.Model.Osoblje);
            // 
            // KupacId
            // 
            this.KupacId.DataPropertyName = "KupacId";
            this.KupacId.DataSource = this.kupciBindingSource;
            this.KupacId.DisplayMember = "KorisnickoIme";
            this.KupacId.HeaderText = "Kupac";
            this.KupacId.Name = "KupacId";
            this.KupacId.ReadOnly = true;
            this.KupacId.ValueMember = "KupacId";
            // 
            // kupciBindingSource
            // 
            this.kupciBindingSource.DataSource = typeof(ePostrojenje.Model.Kupci);
            // 
            // TarifniStavId
            // 
            this.TarifniStavId.DataPropertyName = "TarifniStavId";
            this.TarifniStavId.DataSource = this.tarifniStavoviBindingSource;
            this.TarifniStavId.DisplayMember = "Naziv";
            this.TarifniStavId.HeaderText = "Tarifa";
            this.TarifniStavId.Name = "TarifniStavId";
            this.TarifniStavId.ReadOnly = true;
            this.TarifniStavId.ValueMember = "TarifniStavId";
            // 
            // tarifniStavoviBindingSource
            // 
            this.tarifniStavoviBindingSource.DataSource = typeof(ePostrojenje.Model.TarifniStavovi);
            // 
            // rtxOpis
            // 
            this.rtxOpis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxOpis.Location = new System.Drawing.Point(815, 156);
            this.rtxOpis.Name = "rtxOpis";
            this.rtxOpis.Size = new System.Drawing.Size(249, 177);
            this.rtxOpis.TabIndex = 50;
            this.rtxOpis.Text = "";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(812, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 51;
            this.label2.Text = "Opis";
            // 
            // dtpSklapanja
            // 
            this.dtpSklapanja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpSklapanja.Location = new System.Drawing.Point(815, 364);
            this.dtpSklapanja.Name = "dtpSklapanja";
            this.dtpSklapanja.Size = new System.Drawing.Size(249, 25);
            this.dtpSklapanja.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(812, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 53;
            this.label3.Text = "Datum sklapanja";
            // 
            // cbSklopljen
            // 
            this.cbSklopljen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSklopljen.AutoSize = true;
            this.cbSklopljen.Location = new System.Drawing.Point(815, 405);
            this.cbSklopljen.Name = "cbSklopljen";
            this.cbSklopljen.Size = new System.Drawing.Size(165, 19);
            this.cbSklopljen.TabIndex = 54;
            this.cbSklopljen.Text = "Ugovor sklopljen?";
            this.cbSklopljen.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmUgovori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1116, 519);
            this.Controls.Add(this.cbSklopljen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpSklapanja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtxOpis);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.txtImeUnos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvOsoblje);
            this.MinimumSize = new System.Drawing.Size(1022, 437);
            this.Name = "frmUgovori";
            this.Text = "Ugovori";
            this.Load += new System.EventHandler(this.frmUgovori_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOsoblje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.osobljeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kupciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarifniStavoviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Button txtPretraga;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpDo;
        private System.Windows.Forms.DateTimePicker dtpOd;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.TextBox txtImeUnos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvOsoblje;
        private System.Windows.Forms.RichTextBox rtxOpis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpSklapanja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbSklopljen;
        private System.Windows.Forms.BindingSource osobljeBindingSource;
        private System.Windows.Forms.BindingSource kupciBindingSource;
        private System.Windows.Forms.BindingSource tarifniStavoviBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn UgovorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojUgovora;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumSklapanja;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
        private System.Windows.Forms.DataGridViewComboBoxColumn OsobljeId;
        private System.Windows.Forms.DataGridViewComboBoxColumn KupacId;
        private System.Windows.Forms.DataGridViewComboBoxColumn TarifniStavId;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}