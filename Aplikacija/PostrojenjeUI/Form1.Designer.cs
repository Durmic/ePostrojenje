namespace PostrojenjeUI
{
    partial class Form1
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
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panelUgovori = new System.Windows.Forms.Panel();
            this.btnPretragaUgovori = new System.Windows.Forms.Button();
            this.btnUgovori = new System.Windows.Forms.Button();
            this.panelReklamacijeSubMenu = new System.Windows.Forms.Panel();
            this.btnOcjene = new System.Windows.Forms.Button();
            this.btnPretragaReklamacija = new System.Windows.Forms.Button();
            this.btnReklamacije = new System.Windows.Forms.Button();
            this.panelObavjestenjaSubMenu = new System.Windows.Forms.Panel();
            this.btnDodajObavjestenje = new System.Windows.Forms.Button();
            this.btnPretragaObavjestenja = new System.Windows.Forms.Button();
            this.btnObavjestenja = new System.Windows.Forms.Button();
            this.panelOsobljeSubMenu = new System.Windows.Forms.Panel();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.btnOsoblje = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelSideMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelUgovori.SuspendLayout();
            this.panelReklamacijeSubMenu.SuspendLayout();
            this.panelObavjestenjaSubMenu.SuspendLayout();
            this.panelOsobljeSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelNavigation.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.panel1);
            this.panelSideMenu.Controls.Add(this.button3);
            this.panelSideMenu.Controls.Add(this.panelUgovori);
            this.panelSideMenu.Controls.Add(this.btnUgovori);
            this.panelSideMenu.Controls.Add(this.panelReklamacijeSubMenu);
            this.panelSideMenu.Controls.Add(this.btnReklamacije);
            this.panelSideMenu.Controls.Add(this.panelObavjestenjaSubMenu);
            this.panelSideMenu.Controls.Add(this.btnObavjestenja);
            this.panelSideMenu.Controls.Add(this.panelOsobljeSubMenu);
            this.panelSideMenu.Controls.Add(this.btnOsoblje);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 706);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 630);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 86);
            this.panel1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(0, 40);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(229, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Novi kupac";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.LightGray;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(229, 40);
            this.button2.TabIndex = 0;
            this.button2.Text = "Pretraga";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Gainsboro;
            this.button3.Location = new System.Drawing.Point(0, 585);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(229, 45);
            this.button3.TabIndex = 9;
            this.button3.Text = "Kupci";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panelUgovori
            // 
            this.panelUgovori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelUgovori.Controls.Add(this.btnPretragaUgovori);
            this.panelUgovori.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUgovori.Location = new System.Drawing.Point(0, 540);
            this.panelUgovori.Name = "panelUgovori";
            this.panelUgovori.Size = new System.Drawing.Size(229, 45);
            this.panelUgovori.TabIndex = 8;
            // 
            // btnPretragaUgovori
            // 
            this.btnPretragaUgovori.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPretragaUgovori.FlatAppearance.BorderSize = 0;
            this.btnPretragaUgovori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPretragaUgovori.ForeColor = System.Drawing.Color.LightGray;
            this.btnPretragaUgovori.Location = new System.Drawing.Point(0, 0);
            this.btnPretragaUgovori.Name = "btnPretragaUgovori";
            this.btnPretragaUgovori.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPretragaUgovori.Size = new System.Drawing.Size(229, 40);
            this.btnPretragaUgovori.TabIndex = 1;
            this.btnPretragaUgovori.Text = "Pregled";
            this.btnPretragaUgovori.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPretragaUgovori.UseVisualStyleBackColor = true;
            this.btnPretragaUgovori.Click += new System.EventHandler(this.btnPretragaUgovori_Click);
            // 
            // btnUgovori
            // 
            this.btnUgovori.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUgovori.FlatAppearance.BorderSize = 0;
            this.btnUgovori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUgovori.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUgovori.Location = new System.Drawing.Point(0, 495);
            this.btnUgovori.Name = "btnUgovori";
            this.btnUgovori.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUgovori.Size = new System.Drawing.Size(229, 45);
            this.btnUgovori.TabIndex = 7;
            this.btnUgovori.Text = "Ugovori";
            this.btnUgovori.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUgovori.UseVisualStyleBackColor = true;
            this.btnUgovori.Click += new System.EventHandler(this.btnUgovori_Click);
            // 
            // panelReklamacijeSubMenu
            // 
            this.panelReklamacijeSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelReklamacijeSubMenu.Controls.Add(this.btnOcjene);
            this.panelReklamacijeSubMenu.Controls.Add(this.btnPretragaReklamacija);
            this.panelReklamacijeSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReklamacijeSubMenu.Location = new System.Drawing.Point(0, 407);
            this.panelReklamacijeSubMenu.Name = "panelReklamacijeSubMenu";
            this.panelReklamacijeSubMenu.Size = new System.Drawing.Size(229, 88);
            this.panelReklamacijeSubMenu.TabIndex = 6;
            // 
            // btnOcjene
            // 
            this.btnOcjene.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOcjene.FlatAppearance.BorderSize = 0;
            this.btnOcjene.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOcjene.ForeColor = System.Drawing.Color.LightGray;
            this.btnOcjene.Location = new System.Drawing.Point(0, 40);
            this.btnOcjene.Name = "btnOcjene";
            this.btnOcjene.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnOcjene.Size = new System.Drawing.Size(229, 40);
            this.btnOcjene.TabIndex = 1;
            this.btnOcjene.Text = "Ocjenjivanje";
            this.btnOcjene.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOcjene.UseVisualStyleBackColor = true;
            this.btnOcjene.Click += new System.EventHandler(this.btnOcjene_Click);
            // 
            // btnPretragaReklamacija
            // 
            this.btnPretragaReklamacija.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPretragaReklamacija.FlatAppearance.BorderSize = 0;
            this.btnPretragaReklamacija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPretragaReklamacija.ForeColor = System.Drawing.Color.LightGray;
            this.btnPretragaReklamacija.Location = new System.Drawing.Point(0, 0);
            this.btnPretragaReklamacija.Name = "btnPretragaReklamacija";
            this.btnPretragaReklamacija.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPretragaReklamacija.Size = new System.Drawing.Size(229, 40);
            this.btnPretragaReklamacija.TabIndex = 0;
            this.btnPretragaReklamacija.Text = "Pretraga";
            this.btnPretragaReklamacija.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPretragaReklamacija.UseVisualStyleBackColor = true;
            this.btnPretragaReklamacija.Click += new System.EventHandler(this.btnPretragaReklamacija_Click);
            // 
            // btnReklamacije
            // 
            this.btnReklamacije.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReklamacije.FlatAppearance.BorderSize = 0;
            this.btnReklamacije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReklamacije.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReklamacije.Location = new System.Drawing.Point(0, 362);
            this.btnReklamacije.Name = "btnReklamacije";
            this.btnReklamacije.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReklamacije.Size = new System.Drawing.Size(229, 45);
            this.btnReklamacije.TabIndex = 5;
            this.btnReklamacije.Text = "Reklamacije";
            this.btnReklamacije.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReklamacije.UseVisualStyleBackColor = true;
            this.btnReklamacije.Click += new System.EventHandler(this.btnReklamacije_Click);
            // 
            // panelObavjestenjaSubMenu
            // 
            this.panelObavjestenjaSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelObavjestenjaSubMenu.Controls.Add(this.btnDodajObavjestenje);
            this.panelObavjestenjaSubMenu.Controls.Add(this.btnPretragaObavjestenja);
            this.panelObavjestenjaSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelObavjestenjaSubMenu.Location = new System.Drawing.Point(0, 276);
            this.panelObavjestenjaSubMenu.Name = "panelObavjestenjaSubMenu";
            this.panelObavjestenjaSubMenu.Size = new System.Drawing.Size(229, 86);
            this.panelObavjestenjaSubMenu.TabIndex = 4;
            // 
            // btnDodajObavjestenje
            // 
            this.btnDodajObavjestenje.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDodajObavjestenje.FlatAppearance.BorderSize = 0;
            this.btnDodajObavjestenje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajObavjestenje.ForeColor = System.Drawing.Color.LightGray;
            this.btnDodajObavjestenje.Location = new System.Drawing.Point(0, 40);
            this.btnDodajObavjestenje.Name = "btnDodajObavjestenje";
            this.btnDodajObavjestenje.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDodajObavjestenje.Size = new System.Drawing.Size(229, 40);
            this.btnDodajObavjestenje.TabIndex = 1;
            this.btnDodajObavjestenje.Text = "Novo obavjestenje";
            this.btnDodajObavjestenje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajObavjestenje.UseVisualStyleBackColor = true;
            this.btnDodajObavjestenje.Click += new System.EventHandler(this.btnDodajObavjestenje_Click);
            // 
            // btnPretragaObavjestenja
            // 
            this.btnPretragaObavjestenja.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPretragaObavjestenja.FlatAppearance.BorderSize = 0;
            this.btnPretragaObavjestenja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPretragaObavjestenja.ForeColor = System.Drawing.Color.LightGray;
            this.btnPretragaObavjestenja.Location = new System.Drawing.Point(0, 0);
            this.btnPretragaObavjestenja.Name = "btnPretragaObavjestenja";
            this.btnPretragaObavjestenja.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPretragaObavjestenja.Size = new System.Drawing.Size(229, 40);
            this.btnPretragaObavjestenja.TabIndex = 0;
            this.btnPretragaObavjestenja.Text = "Pregled";
            this.btnPretragaObavjestenja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPretragaObavjestenja.UseVisualStyleBackColor = true;
            this.btnPretragaObavjestenja.Click += new System.EventHandler(this.btnPretragaObavjestenja_Click);
            // 
            // btnObavjestenja
            // 
            this.btnObavjestenja.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnObavjestenja.FlatAppearance.BorderSize = 0;
            this.btnObavjestenja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObavjestenja.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnObavjestenja.Location = new System.Drawing.Point(0, 231);
            this.btnObavjestenja.Name = "btnObavjestenja";
            this.btnObavjestenja.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnObavjestenja.Size = new System.Drawing.Size(229, 45);
            this.btnObavjestenja.TabIndex = 3;
            this.btnObavjestenja.Text = "Obavjestenja";
            this.btnObavjestenja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObavjestenja.UseVisualStyleBackColor = true;
            this.btnObavjestenja.Click += new System.EventHandler(this.btnObavjestenja_Click);
            // 
            // panelOsobljeSubMenu
            // 
            this.panelOsobljeSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelOsobljeSubMenu.Controls.Add(this.btnDodaj);
            this.panelOsobljeSubMenu.Controls.Add(this.btnPretraga);
            this.panelOsobljeSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOsobljeSubMenu.Location = new System.Drawing.Point(0, 145);
            this.panelOsobljeSubMenu.Name = "panelOsobljeSubMenu";
            this.panelOsobljeSubMenu.Size = new System.Drawing.Size(229, 86);
            this.panelOsobljeSubMenu.TabIndex = 2;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDodaj.FlatAppearance.BorderSize = 0;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.ForeColor = System.Drawing.Color.LightGray;
            this.btnDodaj.Location = new System.Drawing.Point(0, 40);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDodaj.Size = new System.Drawing.Size(229, 40);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Novo osoblje";
            this.btnDodaj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnPretraga
            // 
            this.btnPretraga.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPretraga.FlatAppearance.BorderSize = 0;
            this.btnPretraga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPretraga.ForeColor = System.Drawing.Color.LightGray;
            this.btnPretraga.Location = new System.Drawing.Point(0, 0);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPretraga.Size = new System.Drawing.Size(229, 40);
            this.btnPretraga.TabIndex = 0;
            this.btnPretraga.Text = "Pretraga";
            this.btnPretraga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // btnOsoblje
            // 
            this.btnOsoblje.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOsoblje.FlatAppearance.BorderSize = 0;
            this.btnOsoblje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOsoblje.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOsoblje.Location = new System.Drawing.Point(0, 100);
            this.btnOsoblje.Name = "btnOsoblje";
            this.btnOsoblje.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnOsoblje.Size = new System.Drawing.Size(229, 45);
            this.btnOsoblje.TabIndex = 1;
            this.btnOsoblje.Text = "Osoblje";
            this.btnOsoblje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOsoblje.UseVisualStyleBackColor = true;
            this.btnOsoblje.Click += new System.EventHandler(this.btnOsoblje_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.lblSecond);
            this.panelLogo.Controls.Add(this.lblTime);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(229, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // lblSecond
            // 
            this.lblSecond.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSecond.AutoSize = true;
            this.lblSecond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSecond.Font = new System.Drawing.Font("SimSun", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSecond.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSecond.Location = new System.Drawing.Point(170, 23);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(67, 59);
            this.lblSecond.TabIndex = 1;
            this.lblSecond.Text = "22";
            this.lblSecond.UseCompatibleTextRendering = true;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTime.AutoSize = true;
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTime.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTime.Location = new System.Drawing.Point(1, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(176, 84);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "22:22";
            this.lblTime.UseCompatibleTextRendering = true;
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelNavigation.Controls.Add(this.lblDay);
            this.panelNavigation.Controls.Add(this.lblDate);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelNavigation.Location = new System.Drawing.Point(250, 566);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(1134, 140);
            this.panelNavigation.TabIndex = 1;
            // 
            // lblDay
            // 
            this.lblDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDay.AutoSize = true;
            this.lblDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDay.Font = new System.Drawing.Font("SimSun", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDay.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDay.Location = new System.Drawing.Point(833, 39);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(208, 74);
            this.lblDay.TabIndex = 5;
            this.lblDay.Text = "SUNDAY";
            this.lblDay.UseCompatibleTextRendering = true;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDate.AutoSize = true;
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDate.Font = new System.Drawing.Font("SimSun", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDate.Location = new System.Drawing.Point(95, 39);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(394, 74);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "JUNE 23 2019";
            this.lblDate.UseCompatibleTextRendering = true;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChildForm.Controls.Add(this.label1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1134, 566);
            this.panelChildForm.TabIndex = 2;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(246, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(770, 120);
            this.label1.TabIndex = 0;
            this.label1.Text = "ePostrojenje";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 706);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelNavigation);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MinimumSize = new System.Drawing.Size(1250, 592);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelUgovori.ResumeLayout(false);
            this.panelReklamacijeSubMenu.ResumeLayout(false);
            this.panelObavjestenjaSubMenu.ResumeLayout(false);
            this.panelOsobljeSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelNavigation.ResumeLayout(false);
            this.panelNavigation.PerformLayout();
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnOsoblje;
        private System.Windows.Forms.Panel panelOsobljeSubMenu;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.Panel panelObavjestenjaSubMenu;
        private System.Windows.Forms.Button btnDodajObavjestenje;
        private System.Windows.Forms.Button btnPretragaObavjestenja;
        private System.Windows.Forms.Button btnObavjestenja;
        private System.Windows.Forms.Panel panelReklamacijeSubMenu;
        private System.Windows.Forms.Button btnPretragaReklamacija;
        private System.Windows.Forms.Button btnReklamacije;
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelUgovori;
        private System.Windows.Forms.Button btnPretragaUgovori;
        private System.Windows.Forms.Button btnUgovori;
        private System.Windows.Forms.Button btnOcjene;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}