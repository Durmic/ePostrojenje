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
    public partial class frmOsobljeDetalji : Form
    {
        APIService _service = new APIService("Osoblje");
        APIService _serviceOdjeli = new APIService("Odjeli");
        private readonly APIService _serviceVrsta = new APIService("VrstaAplikacije");
        #region baza
        string baza = "baza";
        string user = "desktop";
        string pass = "test";
        #endregion
        private int? _id = null;
        public frmOsobljeDetalji(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private async void frmOsobljeDetalji_Load(object sender, EventArgs e)
        {
            VrstaAplikacijeInsert vrstaApp = new VrstaAplikacijeInsert();
            vrstaApp.DesktopStatus = 1;
            APIService.Username = baza;
            APIService.Password = baza;
            await _serviceVrsta.Update<dynamic>(1, vrstaApp);
            APIService.Username = user;
            APIService.Password = pass;

            var odjeli = await _serviceOdjeli.Get<List<ePostrojenje.Model.Odjeli>>(null);
            
            clbOdjeli.DataSource = odjeli;
            clbOdjeli.DisplayMember = "Naziv";

            if (_id.HasValue)
            {
                var entity = await _service.GetById<ePostrojenje.Model.Osoblje>(_id);
                txtIme.Text = entity.Ime;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            txtIme.Clear();
            txtPrezime.Clear();
            dtpRodjendan.ResetText();
            txtMail.Clear();
            txtJMBG.Clear();
            clbOdjeli.ClearSelected();
            clbOdjeli.ResetText();
            txtKorisnickoIme.Clear();
            txtLozinka.Clear();
            txtLozinkaPotvrda.Clear();
            txtPitanje.Clear();
            txtOdgovor.Clear();
            //pbSlika.ResetText();
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (await ZauzetoKorisnickoIme() == false)
            {
                if (ValidateChildren())
                {
                    var odjeli = clbOdjeli.CheckedItems.Cast<Odjeli>().Select(x => x.OdjelId).ToList();
                    
                    //ePostrojenje.Model.Osoblje trenutni = await _apiService.GetById<ePostrojenje.Model.Osoblje>(korisnikId);
                    var request = new OsobljeInsertRequest();
                    //request.Odjeli = new List<int>();
                    request.Ime = txtIme.Text;
                    request.Prezime = txtPrezime.Text;
                    request.KorisnickoIme = txtKorisnickoIme.Text;
                    request.DatumRodjenja = dtpRodjendan.Value;
                    request.Mail = txtMail.Text;
                    request.Jmbg = txtJMBG.Text;
                    //clbOdjeli.ClearSelected();

                    request.Password = txtLozinka.Text;
                    request.PasswordConfirmation = txtLozinkaPotvrda.Text;
                    request.Pitanje = txtPitanje.Text;
                    request.Odgovor = txtOdgovor.Text;
                    request.Odjeli = odjeli;
                    //pbSlika.ResetText();

                    VrstaAplikacijeInsert vrstaApp = new VrstaAplikacijeInsert();
                    vrstaApp.DesktopStatus = 1;
                    APIService.Username = baza;
                    APIService.Password = baza;
                    await _serviceVrsta.Update<dynamic>(1, vrstaApp);
                    APIService.Username = user;
                    APIService.Password = pass;

                    await _service.Insert<Osoblje>(request);

                    //await _service.Insert<OsobljeInsertRequest>(request);




                    if (request != null)
                    {
                        MessageBox.Show("Uspješno izvršeno");
                        txtIme.Clear();
                        txtPrezime.Clear();
                        dtpRodjendan.ResetText();
                        txtMail.Clear();
                        txtJMBG.Clear();
                        clbOdjeli.ClearSelected();
                        clbOdjeli.ResetText();
                        clbOdjeli.SetItemChecked(0, false);
                        clbOdjeli.SetItemChecked(1, false);
                        clbOdjeli.SetItemChecked(2, false);
                        //clbOdjeli.Items.
                        txtKorisnickoIme.Clear();
                        txtLozinka.Clear();
                        txtLozinkaPotvrda.Clear();
                        txtPitanje.Clear();
                        txtOdgovor.Clear();
                        //pbSlika.ResetText();
                    }
                }
            }
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtIme, "Obavezno polje!");

            }
            else if (txtIme.Text.Length < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(txtIme, "Mora sadrzavati vise od 3 karaktera!");

            }
            else
            {
                errorProvider.SetError(txtIme, null);
            }
        }

        public async Task<bool> ZauzetoKorisnickoIme()
        {
            OsobljeSearchRequest searchRequest = new OsobljeSearchRequest();
            searchRequest.KorisnickoIme = txtKorisnickoIme.Text;
            //APIService.Username = "desktop";
            //APIService.Password = "test";
            List<Osoblje> lista = await _service.Get<List<Osoblje>>(searchRequest);
            if (lista.Count > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> IstoIme()
        {
            OsobljeSearchRequest searchRequest = new OsobljeSearchRequest();
            searchRequest.KorisnickoIme = txtKorisnickoIme.Text;
            //APIService.Username = "desktop";
            //APIService.Password = "test";
            List<Osoblje> lista = await _service.Get<List<Osoblje>>(searchRequest);
            if (lista[0].KorisnickoIme == txtKorisnickoIme.Text)
                return true;
            else
                return false;

        }

        private async void txtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            bool status = await ZauzetoKorisnickoIme();
            if (string.IsNullOrWhiteSpace(txtKorisnickoIme.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtKorisnickoIme, "Obavezno polje!");

            }
            else if (txtKorisnickoIme.Text.Length < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(txtKorisnickoIme, "Mora sadrzavati vise od 3 karaktera!");

            }
            else if (status == true)
            {
                e.Cancel = true;
                errorProvider.SetError(txtKorisnickoIme, "Korisnicko ime zauzeto!");
            }
            /*else if ()
            {

            }*/
            else
            {
                errorProvider.SetError(txtKorisnickoIme, null);
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

        private void txtLozinkaPotvrda_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLozinkaPotvrda.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtLozinkaPotvrda, "Obavezno polje!");

            }
            else if (txtLozinkaPotvrda.Text.Length < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(txtLozinkaPotvrda, "Mora sadrzavati vise od 3 karaktera!");

            }
            else if (txtLozinka.Text != txtLozinkaPotvrda.Text)
            {
                e.Cancel = true;
                errorProvider.SetError(txtLozinkaPotvrda, "Lozinka i potvrda lozinke se ne slazu!");
            }
            else
            {
                errorProvider.SetError(txtLozinkaPotvrda, null);
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

        private void txtMail_Validating(object sender, CancelEventArgs e)
        {
            bool IsValidEmail(string email)
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(email);
                    return addr.Address == email;
                }
                catch
                {
                    return false;
                }
            }

            if (!IsValidEmail(txtMail.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtMail, "Obavezno polje!");

            }
            else
                errorProvider.SetError(txtMail, null);
        }
    }
}
