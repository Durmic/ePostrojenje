using ePostrojenje.Model;
using ePostrojenje.Model.Requests;
using ePostrojenje.WinUI;
using PostrojenjeUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostrojenjeUI
{
    public partial class frmObavjestenjaDetalji : Form
    {
        APIService _apiService = new APIService("Obavjestenja");
        APIService _apiServiceOsoblje = new APIService("Osoblje");
        private readonly APIService _serviceVrsta = new APIService("VrstaAplikacije");
        #region user
        string baza = "baza";
        string user = "desktop";
        string pass = "test";
        #endregion
        private int? _id = null;
        public frmObavjestenjaDetalji(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmObavjestenjaDetalji_Load(object sender, EventArgs e)
        {
            VrstaAplikacijeInsert vrstaApp = new VrstaAplikacijeInsert();
            vrstaApp.DesktopStatus = 1;
            APIService.Username = baza;
            APIService.Password = baza;
            await _serviceVrsta.Update<dynamic>(1, vrstaApp);
            APIService.Username = user;
            APIService.Password = pass;

            await LoadAutori();
            await LoadObavjestenja();
        }
        ObavjestenjaInsertRequest request = new ObavjestenjaInsertRequest();
        private void btnUpload_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;

                var file = File.ReadAllBytes(fileName);

                request.Slika = file;
                txtLokacija.Text = fileName;

                Image image = Image.FromFile(fileName);
                pbSlika.Image = image;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            txtNaslov.Clear();
            txtLokacija.Clear();
            pbSlika.ResetText();
            cmbAutor.ResetText();
            cmbVrsta.ResetText();
            rtxSdrzaj.Clear();
            dtpDatumPocetka.ResetText();
        }
        //ObavjestenjaInsertRequest request = new ObavjestenjaInsertRequest();
        private async void btnObjavi_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {

                //ePostrojenje.Model.Osoblje trenutni = await _apiService.GetById<ePostrojenje.Model.Osoblje>(korisnikId);
                request.Naslov = txtNaslov.Text;
                request.DatumPocetka = dtpDatumPocetka.Value;
                request.Tekst = rtxSdrzaj.Text;
                if (cmbAutor.SelectedIndex == 0)
                    request.OsobljeId = 1;
                else
                    request.OsobljeId = int.Parse(cmbAutor.SelectedValue.ToString());
                if (cmbVrsta.SelectedIndex == 0)
                    request.VrstaObavjestenja = "Informacije";
                else
                    request.VrstaObavjestenja = cmbVrsta.Text;
                //VrstaObavjestenja = cmbVrsta.DisplayMember.ToString()


                VrstaAplikacijeInsert vrstaApp = new VrstaAplikacijeInsert();
                vrstaApp.DesktopStatus = 1;
                APIService.Username = baza;
                APIService.Password = baza;
                await _serviceVrsta.Update<dynamic>(1, vrstaApp);
                APIService.Username = user;
                APIService.Password = pass;

                await _apiService.Insert<ObavjestenjaInsertRequest>(request);

                if (request != null)
                {
                    MessageBox.Show("Uspješno izvršeno");
                }
            }
        }

        private void txtNaslov_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaslov.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtNaslov, "Obavezno polje!");

            }
            else if (txtNaslov.Text.Length < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(txtNaslov, "Mora sadrzavati vise od 3 karaktera!");

            }
            else
            {
                errorProvider.SetError(txtNaslov, null);
            }
        }

        private async void cmbVrsta_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private async Task LoadObavjestenja()
        {
            VrsteObavjestenja informacija = new VrsteObavjestenja();
            VrsteObavjestenja cestitka = new VrsteObavjestenja();
            informacija.ObajvestenjeId = 0;
            informacija.Naziv = "Informacije";
            cestitka.ObajvestenjeId = 1;
            cestitka.Naziv = "Cestitka";
            List<VrsteObavjestenja> vrste = new List<VrsteObavjestenja>();
            vrste.Add(informacija);
            vrste.Add(cestitka);
            vrste.Insert(0, new ePostrojenje.Model.VrsteObavjestenja());
            cmbVrsta.DisplayMember = "Naziv";
            cmbVrsta.ValueMember = "ObavjestenjeId";
            cmbVrsta.DataSource = vrste;
        }

        private async Task LoadAutori()
        {
            var result = await _apiServiceOsoblje.Get<List<ePostrojenje.Model.Osoblje>>(null);
            result.Insert(0, new ePostrojenje.Model.Osoblje());
            cmbAutor.DisplayMember = "KorisnickoIme";
            cmbAutor.ValueMember = "OsobljeId";
            cmbAutor.DataSource = result;
        }
    }
}
