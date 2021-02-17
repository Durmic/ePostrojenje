namespace PostrojenjeUI
{
    partial class frmOcjenjivanje
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvOsoblje = new System.Windows.Forms.DataGridView();
            this.nudOcjena = new System.Windows.Forms.NumericUpDown();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUredi = new System.Windows.Forms.Button();
            this.osobljeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reklamacijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OcjenaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReklamacijaId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OsobljeId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOsoblje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOcjena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.osobljeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reklamacijeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOsoblje
            // 
            this.dgvOsoblje.AllowUserToAddRows = false;
            this.dgvOsoblje.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOsoblje.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvOsoblje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOsoblje.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOsoblje.BackgroundColor = System.Drawing.Color.White;
            this.dgvOsoblje.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvOsoblje.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOsoblje.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvOsoblje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOsoblje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OcjenaId,
            this.ReklamacijaId,
            this.Ocjena,
            this.Datum,
            this.OsobljeId});
            this.dgvOsoblje.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOsoblje.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvOsoblje.Location = new System.Drawing.Point(92, 96);
            this.dgvOsoblje.Name = "dgvOsoblje";
            this.dgvOsoblje.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOsoblje.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvOsoblje.RowHeadersVisible = false;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOsoblje.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvOsoblje.RowTemplate.DividerHeight = 1;
            this.dgvOsoblje.RowTemplate.Height = 27;
            this.dgvOsoblje.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOsoblje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOsoblje.Size = new System.Drawing.Size(910, 317);
            this.dgvOsoblje.TabIndex = 4;
            // 
            // nudOcjena
            // 
            this.nudOcjena.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudOcjena.Location = new System.Drawing.Point(477, 439);
            this.nudOcjena.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudOcjena.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudOcjena.Name = "nudOcjena";
            this.nudOcjena.Size = new System.Drawing.Size(217, 25);
            this.nudOcjena.TabIndex = 5;
            this.nudOcjena.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudOcjena.Validating += new System.ComponentModel.CancelEventHandler(this.nudOcjena_Validating);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1007, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 35);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSpremi.Location = new System.Drawing.Point(886, 431);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(116, 35);
            this.btnSpremi.TabIndex = 28;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Ocjena:";
            // 
            // btnUredi
            // 
            this.btnUredi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUredi.Location = new System.Drawing.Point(92, 431);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(132, 35);
            this.btnUredi.TabIndex = 30;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // osobljeBindingSource
            // 
            this.osobljeBindingSource.DataSource = typeof(ePostrojenje.Model.Osoblje);
            // 
            // reklamacijeBindingSource
            // 
            this.reklamacijeBindingSource.DataSource = typeof(ePostrojenje.Model.Reklamacije);
            // 
            // OcjenaId
            // 
            this.OcjenaId.DataPropertyName = "OcjenaId";
            this.OcjenaId.HeaderText = "OcjenaId";
            this.OcjenaId.Name = "OcjenaId";
            this.OcjenaId.ReadOnly = true;
            this.OcjenaId.Visible = false;
            // 
            // ReklamacijaId
            // 
            this.ReklamacijaId.DataPropertyName = "ReklamacijaId";
            this.ReklamacijaId.DataSource = this.reklamacijeBindingSource;
            this.ReklamacijaId.DisplayMember = "Naslov";
            this.ReklamacijaId.HeaderText = "Reklamacija";
            this.ReklamacijaId.Name = "ReklamacijaId";
            this.ReklamacijaId.ReadOnly = true;
            this.ReklamacijaId.ValueMember = "ReklamacijaId";
            // 
            // Ocjena
            // 
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.Name = "Ocjena";
            this.Ocjena.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // OsobljeId
            // 
            this.OsobljeId.DataPropertyName = "OsobljeId";
            this.OsobljeId.DataSource = this.osobljeBindingSource;
            this.OsobljeId.DisplayMember = "KorisnickoIme";
            this.OsobljeId.HeaderText = "Ocjenio";
            this.OsobljeId.Name = "OsobljeId";
            this.OsobljeId.ReadOnly = true;
            this.OsobljeId.ValueMember = "OsobljeId";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmOcjenjivanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1116, 519);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.nudOcjena);
            this.Controls.Add(this.dgvOsoblje);
            this.Name = "frmOcjenjivanje";
            this.Text = "frmOcjenjivanje";
            this.Load += new System.EventHandler(this.frmOcjenjivanje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOsoblje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOcjena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.osobljeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reklamacijeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOsoblje;
        private System.Windows.Forms.BindingSource osobljeBindingSource;
        private System.Windows.Forms.BindingSource reklamacijeBindingSource;
        private System.Windows.Forms.NumericUpDown nudOcjena;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.DataGridViewTextBoxColumn OcjenaId;
        private System.Windows.Forms.DataGridViewComboBoxColumn ReklamacijaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewComboBoxColumn OsobljeId;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}