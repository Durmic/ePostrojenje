using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;

namespace PostrojenjeUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign()
        {
            panelOsobljeSubMenu.Visible = false;
            panelObavjestenjaSubMenu.Visible = false;
            panelReklamacijeSubMenu.Visible = false;
            panelUgovori.Visible = false;
            panel1.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelOsobljeSubMenu.Visible == true)
                panelOsobljeSubMenu.Visible = false;
            if (panelObavjestenjaSubMenu.Visible == true)
                panelObavjestenjaSubMenu.Visible = false;
            if (panelReklamacijeSubMenu.Visible == true)
                panelReklamacijeSubMenu.Visible = false;
            if (panelUgovori.Visible == true)
                panelUgovori.Visible = false;
            if (panel1.Visible == true)
                panel1.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }


        #region Osoblje

        private void btnOsoblje_Click(object sender, EventArgs e)
        {
            showSubMenu(panelOsobljeSubMenu);
        }

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            openChildForm(new frmOsoblje());
            hideSubMenu();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            openChildForm(new frmOsobljeDetalji());
            hideSubMenu();
        }

        public  void btnDodaj_Click2(int id)
        {
            openChildForm(new frmOsobljeDetalji(id));
            hideSubMenu();
        }
        #endregion

        #region Obavjestenja

        private void btnObavjestenja_Click(object sender, EventArgs e)
        {
            showSubMenu(panelObavjestenjaSubMenu);
        }

        private void btnPretragaObavjestenja_Click(object sender, EventArgs e)
        {
            openChildForm(new frmObavjestenja());
            hideSubMenu();
        }

        private void btnDodajObavjestenje_Click(object sender, EventArgs e)
        {
            openChildForm(new frmObavjestenjaDetalji());
            hideSubMenu();
        }
        #endregion

        #region Reklamacije

        private void btnReklamacije_Click(object sender, EventArgs e)
        {
            showSubMenu(panelReklamacijeSubMenu);
        }

        private void btnPretragaReklamacija_Click(object sender, EventArgs e)
        {
            openChildForm(new frmReklamacije());
            hideSubMenu();
        }
        #endregion

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            lblSecond.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("MMM dd yyyy");
            lblDay.Text = DateTime.Now.ToString("dddd");
            lblSecond.Location = new Point(lblTime.Location.X + lblTime.Width - 5, lblSecond.Location.Y);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            PrivateFontCollection pfc = new PrivateFontCollection();
            int fontLength = Properties.Resources.DS_DIGII.Length;

            // create a buffer to read in to
            byte[] fontdata = Properties.Resources.DS_DIGII;

            // create an unsafe memory block for the font data
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

            // copy the bytes to the unsafe memory block
            Marshal.Copy(fontdata, 0, data, fontLength);

            // pass the font to the font collection
            pfc.AddMemoryFont(data, fontLength);
            /*Stream fontStream = this.GetType().Assembly.GetManifestResourceStream("DS-DIGII.ttf");

            byte[] fontdata = new byte[fontStream.Length];
            fontStream.Read(fontdata, 0, (int)fontStream.Length);
            fontStream.Close();
            unsafe
            {
                fixed (byte* pFontData = fontdata)
                {
                    pfc.AddMemoryFont((System.IntPtr)pFontData, fontdata.Length);
                }
            }*/
            //pfc.AddFontFile(Path.Combine(Application.CommonAppDataPath, "DS-DIGII.TTF"));
            //pfc.AddFontFile("C:/Users/Xi/Desktop/ds_digital/DS-DIGII.TTF");
            /*foreach (Control c in this.Controls)
            {
                c.Font = new Font(pfc.Families[0],28, FontStyle.Regular);
            }*/
            /*
            lblSecond.Font = new Font(pfc.Families[0], 35, FontStyle.Regular);
            lblTime.Font = new Font(pfc.Families[0], 50, FontStyle.Regular);
            lblDate.Font = new Font(pfc.Families[0], 35, FontStyle.Regular);
            lblDay.Font = new Font(pfc.Families[0], 35, FontStyle.Regular);*/
            timer.Start();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }
        #region Ugovori
        private void btnPretragaUgovori_Click(object sender, EventArgs e)
        {
            openChildForm(new frmUgovori());
            hideSubMenu();
        }

        private void btnUgovori_Click(object sender, EventArgs e)
        {
            showSubMenu(panelUgovori);
        }

        #endregion

        private void btnOcjene_Click(object sender, EventArgs e)
        {
            openChildForm(new frmOcjenjivanje());
            hideSubMenu();
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            showSubMenu(panel1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new frmKupci());
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new frmKupciDetalji());
            hideSubMenu();
        }
    }
}
