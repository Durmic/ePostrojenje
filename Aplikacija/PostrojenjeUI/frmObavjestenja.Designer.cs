namespace PostrojenjeUI
{
    partial class frmObavjestenja
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
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.txtPretraga = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDo = new System.Windows.Forms.DateTimePicker();
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpObjave = new System.Windows.Forms.DateTimePicker();
            this.txtNaslovA = new System.Windows.Forms.TextBox();
            this.txtNaslovUnos = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvObavjestenja = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbVrsta = new System.Windows.Forms.ComboBox();
            this.pbSlicica = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAutor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtxTekst = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnDodaj = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.osobljeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ObavjestenjeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPocetka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrstaObavjestenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
            this.OsobljeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tekst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObavjestenja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlicica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.osobljeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtNaslov);
            this.groupBox1.Controls.Add(this.txtPretraga);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtpDo);
            this.groupBox1.Controls.Add(this.dtpOd);
            this.groupBox1.Location = new System.Drawing.Point(3, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 77);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arhiva obavijesti";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 15);
            this.label11.TabIndex = 27;
            this.label11.Text = "Rijeci u naslovu:";
            // 
            // txtNaslov
            // 
            this.txtNaslov.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNaslov.Location = new System.Drawing.Point(206, 17);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(383, 25);
            this.txtNaslov.TabIndex = 6;
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
            this.label10.Location = new System.Drawing.Point(387, 56);
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
            this.label9.Size = new System.Drawing.Size(199, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Objavljeno u periodu: od";
            // 
            // dtpDo
            // 
            this.dtpDo.Location = new System.Drawing.Point(422, 49);
            this.dtpDo.Name = "dtpDo";
            this.dtpDo.Size = new System.Drawing.Size(167, 25);
            this.dtpDo.TabIndex = 24;
            // 
            // dtpOd
            // 
            this.dtpOd.Location = new System.Drawing.Point(206, 49);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(167, 25);
            this.dtpOd.TabIndex = 23;
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOtkazi.Location = new System.Drawing.Point(816, 432);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(116, 35);
            this.btnOtkazi.TabIndex = 48;
            this.btnOtkazi.Text = "Otkazi";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSpremi.Location = new System.Drawing.Point(949, 432);
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
            this.btnUredi.Location = new System.Drawing.Point(3, 473);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(132, 35);
            this.btnUredi.TabIndex = 46;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(813, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 39;
            this.label3.Text = "Datum objave";
            // 
            // dtpObjave
            // 
            this.dtpObjave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpObjave.Location = new System.Drawing.Point(816, 106);
            this.dtpObjave.Name = "dtpObjave";
            this.dtpObjave.Size = new System.Drawing.Size(249, 25);
            this.dtpObjave.TabIndex = 38;
            // 
            // txtNaslovA
            // 
            this.txtNaslovA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNaslovA.Location = new System.Drawing.Point(816, 59);
            this.txtNaslovA.Name = "txtNaslovA";
            this.txtNaslovA.Size = new System.Drawing.Size(249, 25);
            this.txtNaslovA.TabIndex = 35;
            this.txtNaslovA.TextChanged += new System.EventHandler(this.txtNaslovA_TextChanged);
            this.txtNaslovA.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaslovA_Validating);
            // 
            // txtNaslovUnos
            // 
            this.txtNaslovUnos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNaslovUnos.AutoSize = true;
            this.txtNaslovUnos.Location = new System.Drawing.Point(813, 41);
            this.txtNaslovUnos.Name = "txtNaslovUnos";
            this.txtNaslovUnos.Size = new System.Drawing.Size(55, 15);
            this.txtNaslovUnos.TabIndex = 34;
            this.txtNaslovUnos.Text = "Naslov";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1006, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 35);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvObavjestenja
            // 
            this.dgvObavjestenja.AllowUserToAddRows = false;
            this.dgvObavjestenja.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvObavjestenja.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvObavjestenja.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvObavjestenja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvObavjestenja.BackgroundColor = System.Drawing.Color.White;
            this.dgvObavjestenja.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvObavjestenja.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvObavjestenja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvObavjestenja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObavjestenja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ObavjestenjeId,
            this.Naslov,
            this.DatumPocetka,
            this.VrstaObavjestenja,
            this.Slika,
            this.OsobljeId,
            this.Tekst});
            this.dgvObavjestenja.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvObavjestenja.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvObavjestenja.Location = new System.Drawing.Point(3, 115);
            this.dgvObavjestenja.Name = "dgvObavjestenja";
            this.dgvObavjestenja.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvObavjestenja.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvObavjestenja.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvObavjestenja.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvObavjestenja.RowTemplate.DividerHeight = 1;
            this.dgvObavjestenja.RowTemplate.Height = 25;
            this.dgvObavjestenja.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvObavjestenja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObavjestenja.Size = new System.Drawing.Size(763, 352);
            this.dgvObavjestenja.TabIndex = 32;
            this.dgvObavjestenja.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvObavjestenja_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(813, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 15);
            this.label1.TabIndex = 51;
            this.label1.Text = "Vrsta obavjestenja";
            // 
            // cmbVrsta
            // 
            this.cmbVrsta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbVrsta.FormattingEnabled = true;
            this.cmbVrsta.Location = new System.Drawing.Point(816, 154);
            this.cmbVrsta.Name = "cmbVrsta";
            this.cmbVrsta.Size = new System.Drawing.Size(249, 23);
            this.cmbVrsta.TabIndex = 52;
            // 
            // pbSlicica
            // 
            this.pbSlicica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSlicica.Location = new System.Drawing.Point(816, 199);
            this.pbSlicica.Name = "pbSlicica";
            this.pbSlicica.Size = new System.Drawing.Size(116, 69);
            this.pbSlicica.TabIndex = 53;
            this.pbSlicica.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(813, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 54;
            this.label2.Text = "Sličica";
            // 
            // cmbAutor
            // 
            this.cmbAutor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAutor.FormattingEnabled = true;
            this.cmbAutor.Location = new System.Drawing.Point(816, 290);
            this.cmbAutor.Name = "cmbAutor";
            this.cmbAutor.Size = new System.Drawing.Size(249, 23);
            this.cmbAutor.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(813, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 55;
            this.label4.Text = "Autor";
            // 
            // rtxTekst
            // 
            this.rtxTekst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxTekst.Location = new System.Drawing.Point(816, 345);
            this.rtxTekst.Name = "rtxTekst";
            this.rtxTekst.Size = new System.Drawing.Size(249, 83);
            this.rtxTekst.TabIndex = 57;
            this.rtxTekst.Text = "";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(813, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 58;
            this.label5.Text = "Sadrzaj";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDodaj.Location = new System.Drawing.Point(990, 245);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 59;
            this.btnDodaj.Text = "...";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // osobljeBindingSource
            // 
            this.osobljeBindingSource.DataSource = typeof(ePostrojenje.Model.Osoblje);
            // 
            // ObavjestenjeId
            // 
            this.ObavjestenjeId.DataPropertyName = "ObavjestenjeId";
            this.ObavjestenjeId.HeaderText = "ObavjestenjeId";
            this.ObavjestenjeId.Name = "ObavjestenjeId";
            this.ObavjestenjeId.ReadOnly = true;
            this.ObavjestenjeId.Visible = false;
            // 
            // Naslov
            // 
            this.Naslov.DataPropertyName = "Naslov";
            this.Naslov.HeaderText = "Naslov";
            this.Naslov.Name = "Naslov";
            this.Naslov.ReadOnly = true;
            // 
            // DatumPocetka
            // 
            this.DatumPocetka.DataPropertyName = "DatumPocetka";
            this.DatumPocetka.HeaderText = "Datum";
            this.DatumPocetka.Name = "DatumPocetka";
            this.DatumPocetka.ReadOnly = true;
            // 
            // VrstaObavjestenja
            // 
            this.VrstaObavjestenja.DataPropertyName = "VrstaObavjestenja";
            this.VrstaObavjestenja.HeaderText = "Vrsta";
            this.VrstaObavjestenja.Name = "VrstaObavjestenja";
            this.VrstaObavjestenja.ReadOnly = true;
            this.VrstaObavjestenja.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Slika
            // 
            this.Slika.DataPropertyName = "Slika";
            this.Slika.HeaderText = "Sličica";
            this.Slika.Name = "Slika";
            this.Slika.ReadOnly = true;
            this.Slika.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Slika.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // OsobljeId
            // 
            this.OsobljeId.DataPropertyName = "OsobljeId";
            this.OsobljeId.HeaderText = "Autor";
            this.OsobljeId.Name = "OsobljeId";
            this.OsobljeId.ReadOnly = true;
            this.OsobljeId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OsobljeId.Visible = false;
            // 
            // Tekst
            // 
            this.Tekst.DataPropertyName = "Tekst";
            this.Tekst.HeaderText = "Sadrzaj";
            this.Tekst.Name = "Tekst";
            this.Tekst.ReadOnly = true;
            // 
            // frmObavjestenja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1116, 519);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtxTekst);
            this.Controls.Add(this.cmbAutor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbSlicica);
            this.Controls.Add(this.cmbVrsta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpObjave);
            this.Controls.Add(this.txtNaslovA);
            this.Controls.Add(this.txtNaslovUnos);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvObavjestenja);
            this.Name = "frmObavjestenja";
            this.Text = "Obavjestenja";
            this.Load += new System.EventHandler(this.frmObavjestenja_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObavjestenja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlicica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.osobljeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Button txtPretraga;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpDo;
        private System.Windows.Forms.DateTimePicker dtpOd;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpObjave;
        private System.Windows.Forms.TextBox txtNaslovA;
        private System.Windows.Forms.Label txtNaslovUnos;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvObavjestenja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbVrsta;
        private System.Windows.Forms.PictureBox pbSlicica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAutor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtxTekst;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource osobljeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObavjestenjeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPocetka;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrstaObavjestenja;
        private System.Windows.Forms.DataGridViewImageColumn Slika;
        private System.Windows.Forms.DataGridViewTextBoxColumn OsobljeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tekst;
    }
}