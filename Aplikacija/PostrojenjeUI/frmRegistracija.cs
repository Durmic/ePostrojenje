using ePostrojenje.Model;
using ePostrojenje.Model.Requests;
using ePostrojenje.WinUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostrojenjeUI
{
    public partial class frmRegistracija : Form
    {
        //frmLogin frm = new frmLogin();
        string baza = "baza";
        APIService _service = new APIService("Osoblje");
        APIService _serviceVrsta = new APIService("VrstaAplikacije");

        public frmRegistracija()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRegistracija_Load(object sender, EventArgs e)
        {
            //frm.Show();
        }

        private async void btnRegistracija_Click(object sender, EventArgs e)
        {
            if (await ZauzetoKorisnickoIme() == false)
            {

                if (ValidateChildren())
                {
                    //var odjeli = clbOdjeli.CheckedItems.Cast<ePostrojenje.Model.Odjeli>().Select(x => x.OdjelId).ToList();
                    //ePostrojenje.Model.Osoblje trenutni = await _apiService.GetById<ePostrojenje.Model.Osoblje>(korisnikId);
                    var request = new OsobljeInsertRequest()
                    {
                        Ime = txtUsername.Text,
                        KorisnickoIme = txtUsername.Text,

                        Mail = "nije@popunjeno.com",
                        Password = txtPassword.Text,
                        PasswordConfirmation = txtPotvrda.Text,
                        Pitanje = txtPitanje.Text,
                        Odgovor = txtOdgovor.Text,
                        DatumRodjenja = DateTime.Now
                    };
                    VrstaAplikacijeInsert vrstaApp = new VrstaAplikacijeInsert();
                    vrstaApp.DesktopStatus = 1;
                    await _serviceVrsta.Update<dynamic>(1, vrstaApp);
                    await _service.Insert<Osoblje>(request);
                    //await _service.Insert<OsobljeInsertRequest>(request);




                    if (request != null)
                    {
                        MessageBox.Show("Uspješno izvršeno");
                        txtUsername.Clear();
                        txtPassword.Clear();
                        txtPotvrda.ResetText();
                        txtPitanje.Clear();
                        txtOdgovor.Clear();
                        this.Close();
                        //pbSlika.ResetText();
                    }
                }
            }
        }

        public async Task< bool> ZauzetoKorisnickoIme()
        {
            OsobljeSearchRequest searchRequest = new OsobljeSearchRequest();
            searchRequest.KorisnickoIme = txtUsername.Text;
            APIService.Username = baza;
            APIService.Password = baza;
            List<Osoblje> lista = await _service.Get<List<Osoblje>>(searchRequest);
            if (lista.Count > 0)
                return true;
            else
                return false;
        }

        private async void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            bool status = await ZauzetoKorisnickoIme();
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtUsername, "Obavezno polje!");

            }
            else if (txtUsername.Text.Length < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(txtUsername, "Mora sadrzavati vise od 3 karaktera!");

            }
            else if (status == true)
            {
                e.Cancel = true;
                errorProvider.SetError(txtUsername, "Korisnicko ime zauzeto!");
            }
            /*else if ()
            {

            }*/
            else
            {
                errorProvider.SetError(txtUsername, null);
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtPassword, "Obavezno polje!");

            }
            else if (txtPassword.Text.Length < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(txtPassword, "Mora sadrzavati vise od 3 karaktera!");

            }
            else
            {
                errorProvider.SetError(txtPassword, null);
            }
        }

        private void txtPotvrda_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPotvrda.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtPotvrda, "Obavezno polje!");

            }
            else if (txtPotvrda.Text.Length < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(txtPotvrda, "Mora sadrzavati vise od 3 karaktera!");

            }
            else if (txtPassword.Text != txtPotvrda.Text)
            {
                e.Cancel = true;
                errorProvider.SetError(txtPotvrda, "Lozinka i potvrda lozinke se ne slazu!");
            }
            else
            {
                errorProvider.SetError(txtPotvrda, null);
            }
        }

        private void txtPitanje_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPitanje.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtPitanje, "Obavezno polje!");

            }
            else if (txtPitanje.Text.Length < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(txtPitanje, "Mora sadrzavati vise od 3 karaktera!");

            }
            else
            {
                errorProvider.SetError(txtPitanje, null);
            }
        }

        private void txtOdgovor_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOdgovor.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtOdgovor, "Obavezno polje!");

            }
            else if (txtOdgovor.Text.Length < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(txtOdgovor, "Mora sadrzavati vise od 3 karaktera!");

            }
            else
            {
                errorProvider.SetError(txtOdgovor, null);
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            txtUsername.Clear();
            panel1.BackColor = Color.FromArgb(78, 184, 206);
            txtUsername.ForeColor = Color.FromArgb(78, 184, 206);

            panel2.BackColor = Color.WhiteSmoke;
            panel3.BackColor = Color.WhiteSmoke;
            panel4.BackColor = Color.WhiteSmoke;
            panel5.BackColor = Color.WhiteSmoke;
            txtPassword.ForeColor = Color.WhiteSmoke;
            txtPotvrda.ForeColor = Color.WhiteSmoke;
            txtOdgovor.ForeColor = Color.WhiteSmoke;
            txtPitanje.ForeColor = Color.WhiteSmoke;
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtPassword.Clear();
            txtPassword.PasswordChar = '•';
            pictureBox2.Image = Properties.Resources.unlock_icon;
            panel2.BackColor = Color.FromArgb(78, 184, 206);
            txtPassword.ForeColor = Color.FromArgb(78, 184, 206);

            //pictureBox1.Image = Properties.Resources.person_icon;
            panel1.BackColor = Color.WhiteSmoke;
            panel3.BackColor = Color.WhiteSmoke;
            panel4.BackColor = Color.WhiteSmoke;
            panel5.BackColor = Color.WhiteSmoke;
            txtUsername.ForeColor = Color.WhiteSmoke;
            txtPotvrda.ForeColor = Color.WhiteSmoke;
            txtOdgovor.ForeColor = Color.WhiteSmoke;
            txtPitanje.ForeColor = Color.WhiteSmoke;
        }

        private void txtPotvrda_MouseClick(object sender, MouseEventArgs e)
        {
            txtPotvrda.Clear();
            txtPotvrda.PasswordChar = '•';
            pictureBox5.Image = Properties.Resources.unlock_icon;
            pictureBox2.Image = Properties.Resources.lock_icon;
            panel3.BackColor = Color.FromArgb(78, 184, 206);
            txtPotvrda.ForeColor = Color.FromArgb(78, 184, 206);

            //pictureBox1.Image = Properties.Resources.person_icon;
            panel1.BackColor = Color.WhiteSmoke;
            panel2.BackColor = Color.WhiteSmoke;
            panel4.BackColor = Color.WhiteSmoke;
            panel5.BackColor = Color.WhiteSmoke;
            txtUsername.ForeColor = Color.WhiteSmoke;
            txtPassword.ForeColor = Color.WhiteSmoke;
            txtOdgovor.ForeColor = Color.WhiteSmoke;
            txtPitanje.ForeColor = Color.WhiteSmoke;
        }

        private void txtPitanje_MouseClick(object sender, MouseEventArgs e)
        {
            txtPitanje.Clear();
            pictureBox5.Image = Properties.Resources.lock_icon;
            panel4.BackColor = Color.FromArgb(78, 184, 206);
            txtPitanje.ForeColor = Color.FromArgb(78, 184, 206);

            //pictureBox1.Image = Properties.Resources.person_icon;
            panel1.BackColor = Color.WhiteSmoke;
            panel3.BackColor = Color.WhiteSmoke;
            panel2.BackColor = Color.WhiteSmoke;
            panel5.BackColor = Color.WhiteSmoke;
            txtUsername.ForeColor = Color.WhiteSmoke;
            txtPotvrda.ForeColor = Color.WhiteSmoke;
            txtOdgovor.ForeColor = Color.WhiteSmoke;
            txtPassword.ForeColor = Color.WhiteSmoke;
        }

        private void txtOdgovor_MouseClick(object sender, MouseEventArgs e)
        {
            txtOdgovor.Clear();
            pictureBox5.Image = Properties.Resources.lock_icon;
            panel5.BackColor = Color.FromArgb(78, 184, 206);
            txtOdgovor.ForeColor = Color.FromArgb(78, 184, 206);

            //pictureBox1.Image = Properties.Resources.person_icon;
            panel1.BackColor = Color.WhiteSmoke;
            panel3.BackColor = Color.WhiteSmoke;
            panel4.BackColor = Color.WhiteSmoke;
            panel2.BackColor = Color.WhiteSmoke;
            txtUsername.ForeColor = Color.WhiteSmoke;
            txtPotvrda.ForeColor = Color.WhiteSmoke;
            txtPassword.ForeColor = Color.WhiteSmoke;
            txtPitanje.ForeColor = Color.WhiteSmoke;
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (txtPotvrda.PasswordChar != '\0')
            {
                txtPotvrda.PasswordChar = '\0';
                pictureBox4.Image = Properties.Resources.hand_icon;
            }
            else
            {
                txtPotvrda.PasswordChar = '•';
                pictureBox4.Image = Properties.Resources.eye_icon;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
