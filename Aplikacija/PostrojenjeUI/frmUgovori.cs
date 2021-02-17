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
    public partial class frmUgovori : Form
    {
        APIService _apiService = new APIService("Ugovori");
        APIService _apiServiceOsoblje = new APIService("Osoblje");
        APIService _apiServiceKupci = new APIService("Kupci");
        APIService _apiServiceTarife = new APIService("TarifniStavovi");
        private readonly APIService _serviceVrsta = new APIService("VrstaAplikacije");
        #region user
        string baza = "baza";
        string user = "desktop";
        string pass = "test";
        #endregion
        public frmUgovori()
        {
            InitializeComponent();
        }

        bool prikaziPritisnut = false;

        private async void txtPretraga_Click(object sender, EventArgs e)
        {
            var search = new Ugovori()
            {
                BrojUgovora = txtIme.Text,
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

            var list = await _apiService.Get<List<ePostrojenje.Model.Ugovori>>(search);
            if (list.Count > 0)
                prikaziPritisnut = true;
            else
                prikaziPritisnut = false;
            dgvOsoblje.AutoGenerateColumns = false;

            dgvOsoblje.DataSource = list;


        }

        private async void frmUgovori_Load(object sender, EventArgs e)
        {
            VrstaAplikacijeInsert vrstaApp = new VrstaAplikacijeInsert();
            vrstaApp.DesktopStatus = 1;
            APIService.Username = baza;
            APIService.Password = baza;
            await _serviceVrsta.Update<dynamic>(1, vrstaApp);
            APIService.Username = user;
            APIService.Password = pass;

            osobljeBindingSource.DataSource = await _apiServiceOsoblje.Get<List<ePostrojenje.Model.Osoblje>>(null);
            kupciBindingSource.DataSource = await _apiServiceKupci.Get<List<ePostrojenje.Model.Kupci>>(null);
            tarifniStavoviBindingSource.DataSource = await _apiServiceTarife.Get<List<ePostrojenje.Model.TarifniStavovi>>(null);
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

        private async void btnUredi_Click(object sender, EventArgs e)
        {
            if (prikaziPritisnut == true && dgvOsoblje.CurrentCell.RowIndex > -1)
            {
                var korisnikId = int.Parse(dgvOsoblje.SelectedRows[0].Cells[0].Value.ToString());


                var obavjestenje = await _apiService.GetById<ePostrojenje.Model.Ugovori>(korisnikId);

                txtImeUnos.Text = obavjestenje.BrojUgovora;

                rtxOpis.Text = obavjestenje.Opis;
                dtpSklapanja.Value = obavjestenje.DatumSklapanja;
                cbSklopljen.Checked = obavjestenje.Status;

                //pbSlicica.Image = ByteToImage(obavjestenje.Slika);
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
        UgovoriUpdateRequest request = new UgovoriUpdateRequest();
        private async void btnSpremi_Click(object sender, EventArgs e)
        {
            if (ValidateChildren() && prikaziPritisnut == true)
            {
                request.BrojUgovora = txtImeUnos.Text;
                request.DatumSklapanja = dtpSklapanja.Value;
                request.Opis = rtxOpis.Text;
                request.OsobljeId = int.Parse(dgvOsoblje.SelectedRows[0].Cells[4].Value.ToString());
                request.Status = cbSklopljen.Checked;
                //if (pbSlicica != null)
                

                UgovoriUpdateRequest entity = null;
                var korisnikId = int.Parse(dgvOsoblje.SelectedRows[0].Cells[0].Value.ToString());
                entity = await _apiService.Update<UgovoriUpdateRequest>(korisnikId, request);
                if (entity != null)
                {
                    MessageBox.Show("Uspješno izvršeno");
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvOsoblje_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnUredi_Click(sender, e);
        }
    }
}
