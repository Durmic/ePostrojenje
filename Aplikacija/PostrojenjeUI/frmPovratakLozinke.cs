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
    public partial class frmPovratakLozinke : Form
    {
        APIService _service = new APIService("Osoblje");
        APIService _serviceVrsta = new APIService("VrstaAplikacije");

        string baza = "baza";
        public frmPovratakLozinke()
        {
            InitializeComponent();
        }

        private void frmPovratakLozinke_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            txtUsername.Clear();
            panel1.BackColor = Color.FromArgb(78, 184, 206);
            txtUsername.ForeColor = Color.FromArgb(78, 184, 206);
            pictureBox2.Image = Properties.Resources.lock_icon;
            pictureBox3.Image = Properties.Resources.lock_icon;

            panel2.BackColor = Color.WhiteSmoke;
            panel3.BackColor = Color.WhiteSmoke;
            panel4.BackColor = Color.WhiteSmoke;
            panel5.BackColor = Color.WhiteSmoke;
            txtLozinka.ForeColor = Color.WhiteSmoke;
            txtPotvrda.ForeColor = Color.WhiteSmoke;
            txtOdgovor.ForeColor = Color.WhiteSmoke;
            txtPitanje.ForeColor = Color.WhiteSmoke;
        }

        public async Task<bool> ZauzetoKorisnickoIme()
        {
            if (!string.IsNullOrWhiteSpace(txtUsername.Text) && !string.IsNullOrWhiteSpace(txtOdgovor.Text))
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
            
            else if (status == false)
            {
                e.Cancel = true;
                errorProvider.SetError(txtUsername, "Korisnicko ime ne postoji!");
            }
            else
            {
                OsobljeSearchRequest searchRequest = new OsobljeSearchRequest();
                searchRequest.KorisnickoIme = txtUsername.Text;
                List<Osoblje> osoba = await _service.Get<List<Osoblje>>(searchRequest);
                string pitanje = osoba[0].Pitanje;
                errorProvider.SetError(txtUsername, null);
                txtPitanje.Text = "Učitavanje ...";
                txtPitanje.Text = pitanje;
            }
        }
        public async Task<bool> TacanOdgovor()
        {
            OsobljeSearchRequest searchRequest = new OsobljeSearchRequest();
            searchRequest.Odgovor = txtOdgovor.Text;
            APIService.Username = baza;
            APIService.Password = baza;
            List<Osoblje> lista = await _service.Get<List<Osoblje>>(searchRequest);
            if (lista.Count > 0)
                return true;
            else
                return false;
        }
        private async void txtOdgovor_Validating(object sender, CancelEventArgs e)
        {
            bool status = await TacanOdgovor();
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
            
            else if (status == false)
            {
                e.Cancel = true;
                txtOdgovor.BackColor = Color.Red;
                errorProvider.SetError(txtOdgovor, "Odgovor na pitanje nije tacan!");
            }
            else
            {
                txtOdgovor.BackColor = Color.Green;
                errorProvider.SetError(txtOdgovor, null);
            }
        }

        private void txtLozinka_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLozinka.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtLozinka, "Obavezno polje!");

            }
            else if (txtLozinka.Text.Length < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(txtLozinka, "Mora sadrzavati vise od 3 karaktera!");

            }
            else
            {
                errorProvider.SetError(txtLozinka, null);
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
            else if (txtLozinka.Text != txtPotvrda.Text)
            {
                e.Cancel = true;
                errorProvider.SetError(txtPotvrda, "Lozinka i potvrda lozinke se ne slazu!");
            }
            else
            {
                errorProvider.SetError(txtPotvrda, null);
            }
        }

        private void txtPitanje_MouseClick(object sender, MouseEventArgs e)
        {

            panel4.BackColor = Color.FromArgb(78, 184, 206);
            txtPitanje.ForeColor = Color.FromArgb(78, 184, 206);
            pictureBox2.Image = Properties.Resources.lock_icon;
            pictureBox3.Image = Properties.Resources.lock_icon;

            panel1.BackColor = Color.WhiteSmoke;
            panel3.BackColor = Color.WhiteSmoke;
            panel2.BackColor = Color.WhiteSmoke;
            panel5.BackColor = Color.WhiteSmoke;
            txtUsername.ForeColor = Color.WhiteSmoke;
            txtPotvrda.ForeColor = Color.WhiteSmoke;
            txtOdgovor.ForeColor = Color.WhiteSmoke;
            txtPitanje.ForeColor = Color.WhiteSmoke;
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            
                    if (ValidateChildren())
                    {
                if (await ZauzetoKorisnickoIme() == true)
                {
                    if (await TacanOdgovor() == true)
                    {
                        OsobljeSearchRequest searchRequest = new OsobljeSearchRequest();
                        searchRequest.KorisnickoIme = txtUsername.Text;
                        List<Osoblje> osobljeid = await _service.Get<List<Osoblje>>(searchRequest);
                        List<OsobljeInsertRequest> lista = await _service.Get<List<OsobljeInsertRequest>>(searchRequest);
                        lista[0].Password = txtLozinka.Text;
                        lista[0].PasswordConfirmation = txtPotvrda.Text;
                        VrstaAplikacijeInsert vrstaApp = new VrstaAplikacijeInsert();
                        vrstaApp.DesktopStatus = 1;
                        await _serviceVrsta.Update<dynamic>(1, vrstaApp);
                        await _service.Update<Osoblje>(osobljeid[0].OsobljeId, lista[0]);

                        if (lista[0] != null)
                        {
                            MessageBox.Show("Uspješno izvršeno");
                            txtUsername.Clear();
                            txtLozinka.Clear();
                            txtPotvrda.Clear();
                            txtPitanje.Clear();
                            txtOdgovor.Clear();
                            //pbSlika.ResetText();
                        }
                    }
                }
                //await _service.Insert<OsobljeInsertRequest>(request);



            }
                
            
        }

        private void txtLozinka_MouseClick(object sender, MouseEventArgs e)
        {
            txtLozinka.Clear();
            txtLozinka.PasswordChar = '•';
            pictureBox3.Image = Properties.Resources.unlock_icon;
            pictureBox2.Image = Properties.Resources.lock_icon;
            panel3.BackColor = Color.FromArgb(78, 184, 206);
            txtLozinka.ForeColor = Color.FromArgb(78, 184, 206);

            //pictureBox1.Image = Properties.Resources.person_icon;
            panel1.BackColor = Color.WhiteSmoke;
            panel2.BackColor = Color.WhiteSmoke;
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
            pictureBox2.Image = Properties.Resources.unlock_icon;
            pictureBox3.Image = Properties.Resources.lock_icon;
            panel2.BackColor = Color.FromArgb(78, 184, 206);
            txtPotvrda.ForeColor = Color.FromArgb(78, 184, 206);

            panel1.BackColor = Color.WhiteSmoke;
            panel5.BackColor = Color.WhiteSmoke;
            panel4.BackColor = Color.WhiteSmoke;
            panel3.BackColor = Color.WhiteSmoke;
            txtUsername.ForeColor = Color.WhiteSmoke;
            txtLozinka.ForeColor = Color.WhiteSmoke;
            txtOdgovor.ForeColor = Color.WhiteSmoke;
            txtPitanje.ForeColor = Color.WhiteSmoke;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (txtLozinka.PasswordChar != '\0')
            {
                txtLozinka.PasswordChar = '\0';
                pictureBox4.Image = Properties.Resources.hand_icon;
            }
            else
            {
                txtLozinka.PasswordChar = '•';
                pictureBox4.Image = Properties.Resources.eye_icon;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (txtLozinka.PasswordChar != '\0')
            {
                txtLozinka.PasswordChar = '\0';
                pictureBox5.Image = Properties.Resources.hand_icon;
            }
            else
            {
                txtLozinka.PasswordChar = '•';
                pictureBox5.Image = Properties.Resources.eye_icon;
            }
        }

        private void txtOdgovor_MouseClick(object sender, MouseEventArgs e)
        {

            txtOdgovor.Clear();
            panel5.BackColor = Color.FromArgb(78, 184, 206);
            txtOdgovor.ForeColor = Color.FromArgb(78, 184, 206);

            pictureBox2.Image = Properties.Resources.lock_icon;
            pictureBox3.Image = Properties.Resources.lock_icon;
            panel1.BackColor = Color.WhiteSmoke;
            panel2.BackColor = Color.WhiteSmoke;
            panel4.BackColor = Color.WhiteSmoke;
            panel3.BackColor = Color.WhiteSmoke;
            txtUsername.ForeColor = Color.WhiteSmoke;
            txtLozinka.ForeColor = Color.WhiteSmoke;
            txtPotvrda.ForeColor = Color.WhiteSmoke;
            txtPitanje.ForeColor = Color.WhiteSmoke;
        }
    }
}
