using ePostrojenje.WinUI;
//using eProdaja.WinUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ePostrojenje.Model;
using ePostrojenje.Model.Requests;
//using ePostrojenje.Model.vrstaApp;

namespace PostrojenjeUI
{
    public partial class frmLogin : Form
    {
        string baza = "baza";
        APIService _service = new APIService("Osoblje");
        APIService _serviceVrsta = new APIService("VrstaAplikacije");
        frmRegistracija frm;
        frmPovratakLozinke frmPovratak;

        public frmLogin()
        {
            InitializeComponent();
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //vrstaApp.GlobalBoolean = true;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            //pictureBox1.Image = Properties.Resources.name_card_icon;
            panel1.BackColor = Color.FromArgb(78, 184, 206);
            txtUsername.ForeColor = Color.FromArgb(78, 184, 206);

            pictureBox2.Image = Properties.Resources.lock_icon;
            panel2.BackColor = Color.WhiteSmoke;
            txtPassword.ForeColor = Color.WhiteSmoke;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtPassword.PasswordChar = '•';
            pictureBox2.Image = Properties.Resources.unlock_icon;
            panel2.BackColor = Color.FromArgb(78, 184, 206);
            txtPassword.ForeColor = Color.FromArgb(78, 184, 206);

            //pictureBox1.Image = Properties.Resources.person_icon;
            panel1.BackColor = Color.WhiteSmoke;
            txtUsername.ForeColor = Color.WhiteSmoke;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar != '\0')
            {
                txtPassword.PasswordChar = '\0';
                pictureBox3.Image = Properties.Resources.hand_icon;
            }
            else
            {
                txtPassword.PasswordChar = '•';
                pictureBox3.Image = Properties.Resources.eye_icon;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm = new frmRegistracija();
            frm.Show();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            frm.Left += 10;
            if (frm.Left >= 830)
            {
                timer1.Stop();
                this.TopMost = false;
                frm.TopMost = true;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            frm.Left -= 10;
            if (frm.Left <= 600)
                timer2.Stop();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            { 
                VrstaAplikacijeInsert vrstaApp = new VrstaAplikacijeInsert();
                vrstaApp.DesktopStatus = 1;
                APIService.Username = baza;
                APIService.Password = baza;
                await _serviceVrsta.Update<dynamic>(1, vrstaApp);
                APIService.Username = txtUsername.Text;
                APIService.Password = txtPassword.Text;
                await _service.Get<dynamic>(null);
                this.Hide();
                Form1 frmdashboard = new Form1();
                frmdashboard.Closed += (s, args) => this.Close();
                frmdashboard.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Authentikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw new Exception("test");
            }
        }

        private void textBox1_Click(object sender, MouseEventArgs e)
        {
            txtUsername.Clear();
            //pictureBox1.Image = Properties.Resources.name_card_icon;
            panel1.BackColor = Color.FromArgb(78, 184, 206);
            txtUsername.ForeColor = Color.FromArgb(78, 184, 206);

            pictureBox2.Image = Properties.Resources.lock_icon;
            panel2.BackColor = Color.WhiteSmoke;
            txtPassword.ForeColor = Color.WhiteSmoke;
        }

        private void textBox2_Click(object sender, MouseEventArgs e)
        {
            txtPassword.Clear();
            txtPassword.PasswordChar = '•';
            pictureBox2.Image = Properties.Resources.unlock_icon;
            panel2.BackColor = Color.FromArgb(78, 184, 206);
            txtPassword.ForeColor = Color.FromArgb(78, 184, 206);

            //pictureBox1.Image = Properties.Resources.person_icon;
            panel1.BackColor = Color.WhiteSmoke;
            txtUsername.ForeColor = Color.WhiteSmoke;
        }

        private void linkPovratak_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPovratak = new frmPovratakLozinke();
            frmPovratak.Show();
            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            frmPovratak.Left += 50;
            if (frmPovratak.Left >= 830)
            {
                timer3.Stop();
                this.TopMost = false;
                frmPovratak.TopMost = true;
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            frmPovratak.Left -= 50;
            if (frmPovratak.Left <= 600)
                timer4.Stop();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
