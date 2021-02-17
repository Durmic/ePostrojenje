using ePostrojenje.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ePostrojenje.Mobile.ViewModels
{
    public class KupacViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Kupci");
        private readonly APIService _serviceVrsta = new APIService("VrstaAplikacije");
        #region baza
        string baza = "baza";
        string user = "mobile";
        string pass = "test";
        #endregion
        public KupacViewModel()
        {
            LoginCommand = new Command(async () => await Sacuvaj());
        }
        string _ime = string.Empty;
        public string Ime
        {
            get { return _ime; }
            set { SetProperty(ref _ime, value); }
        }

        string _prezime = string.Empty;
        public string Prezime
        {
            get { return _prezime; }
            set { SetProperty(ref _prezime, value); }
        }

        string _jmbg = string.Empty;
        public string Jmbg
        {
            get { return _jmbg; }
            set { SetProperty(ref _jmbg, value); }
        }

        string _email = string.Empty;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        DateTime _rodjendan;

        public DateTime Rodjendan
        {
            get { return _rodjendan; }
            set { SetProperty(ref _rodjendan, value); }
        }

        public ICommand LoginCommand { get; set; }

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

            List<Model.Kupci> tk = await _service.Get<List<Model.Kupci>>(trenutni);

            tk[0].Ime = Ime;
            tk[0].Prezime = Prezime;
            tk[0].Mail = Email;
            tk[0].Jmbg = Jmbg;
            tk[0].DatumRodjenja = Rodjendan.Date;

            if (!string.IsNullOrWhiteSpace(Ime))
            {
                await _service.Update<Model.Kupci>(tk[0].KupacId, tk[0]);
                await Application.Current.MainPage.DisplayAlert("Uspjesno", "Profil azuriran", "OK");
            }
            else
                await Application.Current.MainPage.DisplayAlert("Greška", "Ime niste unijeli", "OK");
        }

        public async Task Login()
        {
            APIService.Username = baza;
            APIService.Password = baza;
            VrstaAplikacijeInsert vrstaApp = new VrstaAplikacijeInsert();
            vrstaApp.DesktopStatus = 0;
            await _serviceVrsta.Update<dynamic>(1, vrstaApp);
            APIService.Username = user;
            APIService.Password = pass;

            KupciSearchRequest trenutni = new KupciSearchRequest();
            trenutni.KorisnickoIme = APIService.Username.ToString();
            trenutni.Prezime = null;
            trenutni.Ime = null;
            List<Model.Kupci> tk = await _service.Get<List<Model.Kupci>>(trenutni);

            Ime = tk[0].Ime;
            Prezime = tk[0].Prezime;
            Rodjendan = tk[0].DatumRodjenja.Date;
            Jmbg = tk[0].Jmbg;
            Email = tk[0].Mail;
            //Rodjendan = tk[0].DatumRodjenja;
        }
    }
}
