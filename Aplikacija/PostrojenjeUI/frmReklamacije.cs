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
    public partial class frmReklamacije : Form
    {
        
        private readonly APIService _kupci = new APIService("Kupci");
        private readonly APIService _osoblje = new APIService("Osoblje");
        private readonly APIService _reklamacije = new APIService("Reklamacije");
        private readonly APIService _serviceVrsta = new APIService("VrstaAplikacije");
        #region user
        string baza = "baza";
        string user = "desktop";
        string pass = "test";
        #endregion
        public frmReklamacije()
        {
            InitializeComponent();
        }

        private async void frmReklamacije_Load(object sender, EventArgs e)
        {

            VrstaAplikacijeInsert vrstaApp = new VrstaAplikacijeInsert();
            vrstaApp.DesktopStatus = 1;
            APIService.Username = baza;
            APIService.Password = baza;
            await _serviceVrsta.Update<dynamic>(1, vrstaApp);
            APIService.Username = user;
            APIService.Password = pass;

            kupciBindingSource.DataSource = await _kupci.Get<List<ePostrojenje.Model.Kupci>>(null);
            var list = await _reklamacije.Get<List<ePostrojenje.Model.Reklamacije>>(null);
            dgvReklamacije.AutoGenerateColumns = false;
            dgvReklamacije.DataSource = list;
            await LoadPreporuceni();
            //await LoadKupci();

        }

        private async Task LoadKupci()
        {
            var result = await _kupci.Get<List<ePostrojenje.Model.Kupci>>(null);
            result.Insert(0, new ePostrojenje.Model.Kupci());
            //cmbKupci.DisplayMember = "KorisnickoIme";
            //cmbKupci.ValueMember = "KupacId";
            //cmbKupci.DataSource = result;
        }


        private async void dgvReklamacije_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            VrstaAplikacijeInsert vrstaApp = new VrstaAplikacijeInsert();
            vrstaApp.DesktopStatus = 1;
            APIService.Username = baza;
            APIService.Password = baza;
            await _serviceVrsta.Update<dynamic>(1, vrstaApp);
            APIService.Username = user;
            APIService.Password = pass;

            var korisnikId = int.Parse(dgvReklamacije.SelectedRows[0].Cells[0].Value.ToString());

            var obavjestenje = await _reklamacije.GetById<ePostrojenje.Model.Reklamacije>(korisnikId);

            //dtpZatvaranja.Value = obavjestenje.DatumZatvaranja.Value;
            cbxStatus.Checked = obavjestenje.Status.Value;
            rtxOpis.Text = obavjestenje.Opis;

            var result = await _osoblje.Get<List<ePostrojenje.Model.Osoblje>>(null);
            result.Insert(0, await _osoblje.GetById<ePostrojenje.Model.Osoblje>(obavjestenje.OsobljeId));
            cmbOsoblje.DisplayMember = "KorisnickoIme";
            cmbOsoblje.ValueMember = "OsobljeId";
            cmbOsoblje.DataSource = result;

        }

        private async void btnSpremi_Click(object sender, EventArgs e)
        {
            VrstaAplikacijeInsert vrstaApp = new VrstaAplikacijeInsert();
            vrstaApp.DesktopStatus = 1;
            APIService.Username = baza;
            APIService.Password = baza;
            await _serviceVrsta.Update<dynamic>(1, vrstaApp);
            APIService.Username = user;
            APIService.Password = pass;

            var reklamacijaid = int.Parse(dgvReklamacije.SelectedRows[0].Cells[0].Value.ToString());
            var list = await _reklamacije.Get<List<ePostrojenje.Model.Reklamacije>>(null);
            var request = list.Find(x => x.ReklamacijaId == reklamacijaid);

            request.DatumZatvaranja = dtpZatvaranja.Value;
            request.Status = cbxStatus.Checked;
            request.OsobljeId = int.Parse(cmbOsoblje.SelectedValue.ToString());
            request.Opis = rtxOpis.Text;
                ePostrojenje.Model.Reklamacije entity = null;
                entity = await _reklamacije.Update<ePostrojenje.Model.Reklamacije>(reklamacijaid, request);

                if (entity != null)
                {
                var listnova = await _reklamacije.Get<List<ePostrojenje.Model.Reklamacije>>(null);
                //dgvReklamacije.AutoGenerateColumns = false;
                dgvReklamacije.DataSource = listnova;
                MessageBox.Show("Uspješno izvršeno");
                cbxStatus.Checked = false;
                rtxOpis.Clear();
                cmbOsoblje.ResetText();
                dtpZatvaranja.ResetText();
                
                }
        }

        /*private async void dgvReklamacije_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            await LoadPreporuceni();
        }*/

        private async Task LoadPreporuceni()
        {
            VrstaAplikacijeInsert vrstaApp = new VrstaAplikacijeInsert();
            vrstaApp.DesktopStatus = 1;
            APIService.Username = baza;
            APIService.Password = baza;
            await _serviceVrsta.Update<dynamic>(1, vrstaApp);
            APIService.Username = user;
            APIService.Password = pass;

            var reklamacijaid = int.Parse(dgvReklamacije.SelectedRows[0].Cells[0].Value.ToString());
            var list = await _reklamacije.GetById<List<ePostrojenje.Model.Reklamacije>>(reklamacijaid);
            
            dgvPreporuceni.AutoGenerateColumns = false;
            dgvPreporuceni.DataSource = list;
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnUredi_Click(object sender, EventArgs e)
        {
            VrstaAplikacijeInsert vrstaApp = new VrstaAplikacijeInsert();
            vrstaApp.DesktopStatus = 1;
            APIService.Username = baza;
            APIService.Password = baza;
            await _serviceVrsta.Update<dynamic>(1, vrstaApp);
            APIService.Username = user;
            APIService.Password = pass;

            var reklamacijaid = int.Parse(dgvReklamacije.SelectedRows[0].Cells[0].Value.ToString());
            var list = await _reklamacije.Get<List<ePostrojenje.Model.Reklamacije>>(null);
            var request = list.Find(x => x.ReklamacijaId == reklamacijaid);

            //var obavjestenje = await _reklamacije.Get<List<ePostrojenje.Model.Reklamacije>>(request);

            dtpZatvaranja.Value = request.DatumZatvaranja.Value;
            cbxStatus.Checked = request.Status.Value;
            rtxOpis.Text = request.Opis;

            var result = await _osoblje.Get<List<ePostrojenje.Model.Osoblje>>(null);
            result.Insert(0, await _osoblje.GetById<ePostrojenje.Model.Osoblje>(request.OsobljeId));
            cmbOsoblje.DisplayMember = "KorisnickoIme";
            cmbOsoblje.ValueMember = "OsobljeId";
            cmbOsoblje.DataSource = result;
        }

        private async void dgvReklamacije_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            await LoadPreporuceni();
        }

        private void kupciBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dgvReklamacije_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnUredi_Click(sender, e);
        }
    }
}
