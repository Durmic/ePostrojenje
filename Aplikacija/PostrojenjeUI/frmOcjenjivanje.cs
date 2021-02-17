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
    public partial class frmOcjenjivanje : Form
    {
        APIService _apiServiceOsoblje = new APIService("Osoblje");
        APIService _apiServiceOcjene = new APIService("Ocjene");
        APIService _apiServiceReklamacije = new APIService("Reklamacije");
        private readonly APIService _serviceVrsta = new APIService("VrstaAplikacije");
        #region user
        string baza = "baza";
        string user = "desktop";
        string pass = "test";
        #endregion
        public frmOcjenjivanje()
        {
            InitializeComponent();
        }
        bool prikaziPritisnut = false;
        private async void frmOcjenjivanje_Load(object sender, EventArgs e)
        {
            VrstaAplikacijeInsert vrstaApp = new VrstaAplikacijeInsert();
            vrstaApp.DesktopStatus = 1;
            APIService.Username = baza;
            APIService.Password = baza;
            await _serviceVrsta.Update<dynamic>(1, vrstaApp);
            APIService.Username = user;
            APIService.Password = pass;

            osobljeBindingSource.DataSource = await _apiServiceOsoblje.Get<List<ePostrojenje.Model.Osoblje>>(null);
            reklamacijeBindingSource.DataSource = await _apiServiceReklamacije.Get<List<ePostrojenje.Model.Reklamacije>>(null);
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

            OsobljeSearchRequest search = new OsobljeSearchRequest()
            {
                KorisnickoIme = APIService.Username
            };

            var osoblje = await _apiServiceOsoblje.Get<List<Osoblje>>(search);
            int osobljeid = osoblje[0].OsobljeId;

            var searchOcjene = new Ocjene()
            {
                OsobljeId = osobljeid
            };

            
            var list = await _apiServiceOcjene.Get<List<ePostrojenje.Model.Ocjene>>(searchOcjene);
            if (list.Count > 0)
                prikaziPritisnut = true;
            else
                prikaziPritisnut = false;
            dgvOsoblje.AutoGenerateColumns = false;

            dgvOsoblje.DataSource = list;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnUredi_Click(object sender, EventArgs e)
        {
            if (prikaziPritisnut == true )
            {
                var korisnikId = int.Parse(dgvOsoblje.SelectedRows[0].Cells[0].Value.ToString());

                VrstaAplikacijeInsert vrstaApp = new VrstaAplikacijeInsert();
                vrstaApp.DesktopStatus = 1;
                APIService.Username = baza;
                APIService.Password = baza;
                await _serviceVrsta.Update<dynamic>(1, vrstaApp);
                APIService.Username = user;
                APIService.Password = pass;

                var ocjena = await _apiServiceOcjene.GetById<ePostrojenje.Model.Ocjene>(korisnikId);

                nudOcjena.Value = ocjena.Ocjena;
            }
        }

        private async void btnSpremi_Click(object sender, EventArgs e)
        {
            if (prikaziPritisnut == true)
            {
                if (ValidateChildren())
                {
                    var korisnikId = int.Parse(dgvOsoblje.SelectedRows[0].Cells[0].Value.ToString());
                    OcjeneUpdateRequest osoba = await _apiServiceOcjene.GetById<OcjeneUpdateRequest>(korisnikId);
                    //ePostrojenje.Model.Osoblje trenutni = await _apiService.GetById<ePostrojenje.Model.Osoblje>(korisnikId);
                    var request = new OcjeneUpdateRequest()
                    {
                        Ocjena = Convert.ToInt32(nudOcjena.Value),
                        Datum = DateTime.Now,
                        OsobljeId = osoba.OsobljeId,
                        ReklamacijaId = osoba.ReklamacijaId
                        //Password = osoba
                    };



                    await _apiServiceOcjene.Update<OcjeneUpdateRequest>(korisnikId, request);

                    if (request != null)
                    {
                        MessageBox.Show("Uspješno izvršeno");
                        OsobljeSearchRequest search = new OsobljeSearchRequest()
                        {
                            KorisnickoIme = APIService.Username
                        };

                        var osoblje = await _apiServiceOsoblje.Get<List<Osoblje>>(search);
                        int osobljeid = osoblje[0].OsobljeId;

                        var searchOcjene = new Ocjene()
                        {
                            OsobljeId = osobljeid
                        };
                        var list = await _apiServiceOcjene.Get<List<ePostrojenje.Model.Ocjene>>(searchOcjene);
                        dgvOsoblje.DataSource = list;
                    }
                }
            }
        }

        private void nudOcjena_Validating(object sender, CancelEventArgs e)
        {
            if (nudOcjena.Value > 5 || nudOcjena.Value < 1)
            {
                e.Cancel = true;
                errorProvider.SetError(nudOcjena, "Mora biti u rasponu od 1 do 5");
            }
            else
                errorProvider.SetError(nudOcjena, null);
        }
    }
}
