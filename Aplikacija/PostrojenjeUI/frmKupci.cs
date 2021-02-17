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
    public partial class frmKupci : Form
    {
        APIService _apiService = new APIService("Kupci");
        private readonly APIService _serviceVrsta = new APIService("VrstaAplikacije");
        #region user
        string baza = "baza";
        string user = "desktop";
        string pass = "test";
        #endregion
        public frmKupci()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool prikaziPritisnut = false;
        private async void txtPretraga_Click(object sender, EventArgs e)
        {
            var search = new KupciSearchRequest()
            {
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                DatumOd = dtpOd.Value,
                DatumDo = dtpDo.Value
            };

            VrstaAplikacijeInsert vrstaApp = new VrstaAplikacijeInsert();
            vrstaApp.DesktopStatus = 1;
            APIService.Username = baza;
            APIService.Password = baza;
            await _serviceVrsta.Update<dynamic>(1, vrstaApp);
            APIService.Username = user;
            APIService.Password = pass;

            var list = await _apiService.Get<List<ePostrojenje.Model.Kupci>>(search);
            if (list.Count > 0)
                prikaziPritisnut = true;
            else
                prikaziPritisnut = false;
            ePostrojenje.Model.Kupci zadnji = new ePostrojenje.Model.Kupci()
            {
                KupacId = list.Count,
                Ime = "",
                Prezime = "",
                Jmbg = "Ukupno",
                Mail = list.Count.ToString()
            };
            list.Add(zadnji);
            dgvOsoblje.AutoGenerateColumns = false;

            dgvOsoblje.DataSource = list;

            dgvOsoblje.Rows[list.Count - 1].DefaultCellStyle.BackColor = Color.FromArgb(109, 122, 224);
            dgvOsoblje.Rows[list.Count - 1].DefaultCellStyle.ForeColor = Color.White;
        }

        private void frmOsoblje_Load(object sender, EventArgs e)
        {
            dgvOsoblje.BorderStyle = BorderStyle.None;
            dgvOsoblje.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dgvOsoblje.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvOsoblje.DefaultCellStyle.SelectionBackColor = Color.FromArgb(229, 226, 244);
            dgvOsoblje.DefaultCellStyle.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dgvOsoblje.DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
            dgvOsoblje.BackgroundColor = Color.White;

            dgvOsoblje.EnableHeadersVisualStyles = false;
            dgvOsoblje.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvOsoblje.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(109, 122, 224);
            dgvOsoblje.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }
        public bool IstoIme()
        {
            if (txtKorisnickoIme.Text == "baza")
                return true;
            else
                return false;

        }
        private async void btnUredi_Click(object sender, EventArgs e)
        {
            if (prikaziPritisnut == true && dgvOsoblje.CurrentCell.RowIndex > -1 && dgvOsoblje.CurrentCell.RowIndex < dgvOsoblje.RowCount - 1)
            {
                var korisnikId = int.Parse(dgvOsoblje.SelectedRows[0].Cells[0].Value.ToString());

                var osoblje = await _apiService.GetById<ePostrojenje.Model.Kupci>(korisnikId);


                txtImeUnos.Text = osoblje.Ime;
                txtPrezimeUnos.Text = osoblje.Prezime;
                dtpRodjendan.Value = osoblje.DatumRodjenja;
                txtJmbg.Text = osoblje.Jmbg;
                txtMail.Text = osoblje.Mail;
                txtKorisnickoIme.Text = osoblje.KorisnickoIme;
                bool status = IstoIme();
                if (status)
                    txtKorisnickoIme.ReadOnly = true;
                else
                    txtKorisnickoIme.ReadOnly = false;
            }
        }

        private void dgvOsoblje_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnUredi_Click(sender, e);
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            txtImeUnos.Clear();
            txtPrezimeUnos.Clear();
            dtpRodjendan.ResetText();
            txtJmbg.Clear();
            txtMail.Clear();
            txtKorisnickoIme.Clear();
        }

        private async void btnSpremi_Click(object sender, EventArgs e)
        {
            if (prikaziPritisnut == true)
            {
                if (ValidateChildren() && await ZauzetoKorisnickoIme() == false)
                {
                    var korisnikId = int.Parse(dgvOsoblje.SelectedRows[0].Cells[0].Value.ToString());
                    KupciInsertRequest osoba = await _apiService.GetById<KupciInsertRequest>(korisnikId);
                    //ePostrojenje.Model.Osoblje trenutni = await _apiService.GetById<ePostrojenje.Model.Osoblje>(korisnikId);
                    var request = new KupciInsertRequest()
                    {
                        Mail = txtMail.Text,
                        Ime = txtImeUnos.Text,
                        Prezime = txtPrezimeUnos.Text,
                        DatumRodjenja = dtpRodjendan.Value,
                        Jmbg = txtJmbg.Text,
                        KorisnickoIme = txtKorisnickoIme.Text,
                        Pitanje = osoba.Pitanje,
                        Odgovor = osoba.Odgovor
                        //Password = osoba
                    };



                    await _apiService.Update<ePostrojenje.Model.Kupci>(korisnikId, request);

                    if (request != null)
                    {
                        MessageBox.Show("Uspješno izvršeno");
                    }
                }
            }
        }

        private void txtImeUnos_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtImeUnos.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtImeUnos, "Obavezno polje!");

            }
            else if (txtImeUnos.Text.Length < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(txtImeUnos, "Mora sadrzavati vise od 3 karaktera!");

            }
            else
            {
                errorProvider.SetError(txtImeUnos, null);
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
        public async Task<bool> ZauzetoKorisnickoIme()
        {
            KupciSearchRequest searchRequest = new KupciSearchRequest();
            searchRequest.KorisnickoIme = txtKorisnickoIme.Text;
            List<Kupci> lista = await _apiService.Get<List<Kupci>>(searchRequest);
            Kupci oznaceni = await _apiService.GetById<Kupci>(int.Parse(dgvOsoblje.SelectedRows[0].Cells[0].Value.ToString()));
            if (lista.Count > 0 && lista[0].KorisnickoIme != oznaceni.KorisnickoIme)
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
            else
            {
                errorProvider.SetError(txtKorisnickoIme, null);
            }
        }

        private async void frmKupci_Load(object sender, EventArgs e)
        {
            VrstaAplikacijeInsert vrstaApp = new VrstaAplikacijeInsert();
            vrstaApp.DesktopStatus = 1;
            APIService.Username = baza;
            APIService.Password = baza;
            await _serviceVrsta.Update<dynamic>(1, vrstaApp);
            APIService.Username = user;
            APIService.Password = pass;

            dgvOsoblje.BorderStyle = BorderStyle.None;
            dgvOsoblje.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dgvOsoblje.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvOsoblje.DefaultCellStyle.SelectionBackColor = Color.FromArgb(229, 226, 244);
            dgvOsoblje.DefaultCellStyle.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dgvOsoblje.DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
            dgvOsoblje.BackgroundColor = Color.White;

            dgvOsoblje.EnableHeadersVisualStyles = false;
            dgvOsoblje.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvOsoblje.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(109, 122, 224);
            dgvOsoblje.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
}
