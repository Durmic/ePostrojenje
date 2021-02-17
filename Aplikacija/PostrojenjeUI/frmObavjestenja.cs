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
    public partial class frmObavjestenja : Form
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
        public frmObavjestenja(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void txtPretraga_Click(object sender, EventArgs e)
        {
            var search = new ObavjestenjaSearchRequest()
            {
                Naslov = txtNaslov.Text,
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

            var list = await _apiService.Get<List<ePostrojenje.Model.Obavjestenja>>(search);
            if (list.Count > 0)
                prikaziPritisnut = true;
            else
                prikaziPritisnut = false;
            ePostrojenje.Model.Obavjestenja zadnji = new ePostrojenje.Model.Obavjestenja()
            {
                ObavjestenjeId = list.Count,
                VrstaObavjestenja = "Ukupno",
                Tekst = list.Count.ToString()
            };
            list.Add(zadnji);
            dgvObavjestenja.AutoGenerateColumns = false;

            dgvObavjestenja.DataSource = list;

            dgvObavjestenja.Rows[list.Count - 1].DefaultCellStyle.BackColor = Color.FromArgb(109, 122, 224);
            dgvObavjestenja.Rows[list.Count - 1].DefaultCellStyle.ForeColor = Color.White;
        }

        private async void frmObavjestenja_Load(object sender, EventArgs e)
        {
            VrstaAplikacijeInsert vrstaApp = new VrstaAplikacijeInsert();
            vrstaApp.DesktopStatus = 1;
            APIService.Username = baza;
            APIService.Password = baza;
            await _serviceVrsta.Update<dynamic>(1, vrstaApp);
            APIService.Username = user;
            APIService.Password = pass;

            osobljeBindingSource.DataSource = await _apiServiceOsoblje.Get<List<ePostrojenje.Model.Osoblje>>(null);
            dgvObavjestenja.BorderStyle = BorderStyle.None;
            dgvObavjestenja.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dgvObavjestenja.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvObavjestenja.DefaultCellStyle.SelectionBackColor = Color.FromArgb(229, 226, 244);
            dgvObavjestenja.DefaultCellStyle.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dgvObavjestenja.DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
            dgvObavjestenja.BackgroundColor = Color.White;

            dgvObavjestenja.EnableHeadersVisualStyles = false;
            dgvObavjestenja.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvObavjestenja.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(109, 122, 224);
            dgvObavjestenja.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            
            //await LoadObavjestenja();
        }

        private async void dgvObavjestenja_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (prikaziPritisnut == true && dgvObavjestenja.CurrentCell.RowIndex > -1 && dgvObavjestenja.CurrentCell.RowIndex < dgvObavjestenja.RowCount - 1)
            {
                await LoadAutori();
                await LoadObavjestenja();
                var korisnikId = int.Parse(dgvObavjestenja.SelectedRows[0].Cells[0].Value.ToString());

                var obavjestenje = await _apiService.GetById<ePostrojenje.Model.Obavjestenja>(korisnikId);
                if (obavjestenje.OsobljeId != null)
                {
                    var osoblje = await _apiServiceOsoblje.GetById<ePostrojenje.Model.Osoblje>(obavjestenje.OsobljeId);
                    cmbAutor.DisplayMember = osoblje.KorisnickoIme;
                }

                txtNaslovA.Text = obavjestenje.Naslov;
                dtpObjave.Value = obavjestenje.DatumPocetka;
                cmbVrsta.DisplayMember = obavjestenje.VrstaObavjestenja;
                byte[] imageSource = obavjestenje.Slika;
                Bitmap image;
                using (MemoryStream stream = new MemoryStream(imageSource))
                {
                    image = new Bitmap(stream);
                }
                pbSlicica.Image = image;

                rtxTekst.Text = obavjestenje.Tekst;

            }
        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        private async void btnUredi_Click(object sender, EventArgs e)
        {
            if (prikaziPritisnut == true && dgvObavjestenja.CurrentCell.RowIndex > -1 && dgvObavjestenja.CurrentCell.RowIndex < dgvObavjestenja.RowCount - 1)
            {
                await LoadAutori();
                await LoadObavjestenja();
                var korisnikId = int.Parse(dgvObavjestenja.SelectedRows[0].Cells[0].Value.ToString());


                var obavjestenje = await _apiService.GetById<ePostrojenje.Model.Obavjestenja>(korisnikId);

                if (obavjestenje.OsobljeId != null)
                {
                    var osoblje = await _apiServiceOsoblje.GetById<ePostrojenje.Model.Osoblje>(obavjestenje.OsobljeId);
                    cmbAutor.DisplayMember = osoblje.KorisnickoIme;
                }

                byte[] imageSource = obavjestenje.Slika;
                Bitmap image;
                using (MemoryStream stream = new MemoryStream(imageSource))
                {
                    image = new Bitmap(stream);
                }
                pbSlicica.Image = image;
                txtNaslovA.Text = obavjestenje.Naslov;
                dtpObjave.Value = obavjestenje.DatumPocetka;
                cmbVrsta.DisplayMember = obavjestenje.VrstaObavjestenja;
                rtxTekst.Text = obavjestenje.Tekst;
                //pbSlicica.Image = ByteToImage(obavjestenje.Slika);
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            txtNaslovA.Clear();
            cmbVrsta.ResetText();
            dtpObjave.ResetText();
            pbSlicica.ResetText();
            cmbAutor.ResetText();
            rtxTekst.Clear();
        }
        ObavjestenjaInsertRequest request = new ObavjestenjaInsertRequest();

        bool prikaziPritisnut = false;
        private async void btnSpremi_Click(object sender, EventArgs e)
        {
            if (ValidateChildren() && prikaziPritisnut == true)
            {
                request.Naslov = txtNaslovA.Text;
                request.DatumPocetka = dtpObjave.Value;
                request.Tekst = rtxTekst.Text;
                request.OsobljeId = int.Parse(cmbAutor.SelectedValue.ToString());
                request.VrstaObavjestenja = cmbVrsta.Text.ToString();
                //if (pbSlicica != null)
                request.Slika = imageToByteArray(pbSlicica.Image);
                    //Tekst = rtxTekst.Text,
                    //OsobljeId = int.Parse(cmbAutor.ValueMember.ToString()),
                    //VrstaObavjestenja = cmbVrsta.ValueMember

                ePostrojenje.Model.Obavjestenja entity = null;
                var korisnikId = int.Parse(dgvObavjestenja.SelectedRows[0].Cells[0].Value.ToString());
                entity = await _apiService.Update<ePostrojenje.Model.Obavjestenja>(korisnikId, request);
                if (entity != null)
                {
                    MessageBox.Show("Uspješno izvršeno");
                }

            }
        }

        private void txtNaslovA_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaslovA.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtNaslovA, Resources.Validation_RequiredField);
            }
            else
            {
                errorProvider.SetError(txtNaslovA, null);
            }
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;

                var file = File.ReadAllBytes(fileName);

                request.Slika = file;
                //txtSlikaInput.Text = fileName;
                
                Image image = Image.FromFile(fileName);
                pbSlicica.Image = image;
            }
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {

        }

        private void txtNaslovA_TextChanged(object sender, EventArgs e)
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
            var korisnikId = int.Parse(dgvObavjestenja.SelectedRows[0].Cells[0].Value.ToString());
            var obavjestenje = await _apiService.GetById<ePostrojenje.Model.Obavjestenja>(korisnikId);
            VrsteObavjestenja vrsta = new VrsteObavjestenja();
            vrsta.ObajvestenjeId = 2;
            vrsta.Naziv = obavjestenje.VrstaObavjestenja;
            vrste.Insert(0, vrsta);
            cmbVrsta.DisplayMember = "Naziv";
            cmbVrsta.ValueMember = "ObavjestenjeId";
            cmbVrsta.DataSource = vrste;
        }

        private async Task LoadAutori()
        {
            var result = await _apiServiceOsoblje.Get<List<ePostrojenje.Model.Osoblje>>(null);
            var korisnikId = int.Parse(dgvObavjestenja.SelectedRows[0].Cells[0].Value.ToString());
            var obavjestenje = await _apiService.GetById<ePostrojenje.Model.Obavjestenja>(korisnikId);
            ePostrojenje.Model.Osoblje trenutni = new ePostrojenje.Model.Osoblje();
            trenutni = await _apiServiceOsoblje.GetById<ePostrojenje.Model.Osoblje>(obavjestenje.OsobljeId);
            result.Insert(0, trenutni);
            cmbAutor.DisplayMember = "KorisnickoIme";
            cmbAutor.ValueMember = "OsobljeId";
            cmbAutor.DataSource = result;
        }
    }
}
