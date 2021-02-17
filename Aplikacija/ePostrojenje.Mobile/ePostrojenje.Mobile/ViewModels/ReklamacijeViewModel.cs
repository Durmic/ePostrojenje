using ePostrojenje.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ePostrojenje.Mobile.ViewModels
{
	public class ReklamacijeViewModel : BaseViewModel
	{
        private readonly APIService _service = new APIService("Reklamacije");
        private readonly APIService _kupacService = new APIService("Kupci");
        private readonly APIService _serviceVrsta = new APIService("VrstaAplikacije");
        #region baza
        string baza = "baza";
        string user = "mobile";
        string pass = "test";
        #endregion
        //private readonly APIService _reklamacijeService = new APIService("Ugovori");
        public ReklamacijeViewModel ()
		{
            InitCommand = new Command(async () => await Sacuvaj());
        }

        public ICommand InitCommand { get; set; }

        string _opis = string.Empty;
        public string Opis
        {
            get { return _opis; }
            set { SetProperty(ref _opis, value); }
        }

        string _naslov = string.Empty;
        public string Naslov
        {
            get { return _naslov; }
            set { SetProperty(ref _naslov, value); }
        }

        public async Task Sacuvaj()
        {
            KupciSearchRequest trenutni = new KupciSearchRequest();
            trenutni.KorisnickoIme = APIService.Username.ToString();
            trenutni.Prezime = null;

            APIService.Username = baza;
            APIService.Password = baza;
            VrstaAplikacijeInsert vrstaApp = new VrstaAplikacijeInsert();
            vrstaApp.DesktopStatus = 0;
            await _serviceVrsta.Update<dynamic>(1, vrstaApp);
            APIService.Username = user;
            APIService.Password = pass;

            List<Model.Kupci> tk = await _kupacService.Get<List<Model.Kupci>>(trenutni);


            ReklamacijeInsertRequest novi = new ReklamacijeInsertRequest();
            novi.Naslov = Naslov;
            novi.KupacId = tk[0].KupacId;
            novi.DatumOtvaranja = DateTime.Today;
            novi.DatumZatvaranja = DateTime.Today;
            novi.Status = false;
            novi.OsobljeId = 1;
            novi.Opis = Opis;
                if (!string.IsNullOrWhiteSpace(Naslov) && !string.IsNullOrWhiteSpace(Opis))
                {
                    await _service.Insert<Model.Reklamacije>(novi);
                    await Application.Current.MainPage.DisplayAlert("Uspjesno", "Nova reklamacija podnesena", "OK");
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Naslov/Opis niste unijeli", "OK");
                }
            }
        }
    }
