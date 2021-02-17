using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ePostrojenje.Mobile.Views;
using ePostrojenje.Model;
using ePostrojenje.Model.Requests;
using Xamarin.Forms;
//using ePostrojenje.Model.vrstaApp;

namespace ePostrojenje.Mobile.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Kupci");
        private readonly APIService _serviceVrsta = new APIService("VrstaAplikacije");
        private readonly APIService _serviceRSII25092020 = new APIService("RSII25092020");
        string baza = "baza";

        public LoginViewModel()
        {
            //vrstaApp.GlobalBoolean = true;
            LoginCommand = new Command(async () => await Login());
            //ManualCommand = new Command(async () => await Manual());

        }
        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        public ICommand LoginCommand { get; set; }

        async Task Login()
        {
            IsBusy = true;
            
            try
            {
                APIService.Username = baza;
                APIService.Password = baza;
                VrstaAplikacijeInsert vrstaApp = new VrstaAplikacijeInsert();
                vrstaApp.DesktopStatus = 0;
                await _serviceVrsta.Update<dynamic>(1, vrstaApp);
                APIService.Username = Username;
                APIService.Password = Password;
                await _service.Get<dynamic>(null);
                Application.Current.MainPage = new MainPage();
                KupciSearchRequest uneseni = new KupciSearchRequest();
                uneseni.KorisnickoIme = Username;
                List<Kupci> upisani = await _service.Get<List<Kupci>>(uneseni);
                if (upisani.Count > 0)
                {
                    RSII25092020InsertRequest novi = new RSII25092020InsertRequest();
                    novi.DatumLogiranja = DateTime.Now;
                    novi.KupacId = upisani[0].KupacId;
                    await _serviceRSII25092020.Insert<RSII25092020InsertRequest>(novi);
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Niste authentificirani", "OK");
                APIService.Username = baza;
                APIService.Password = baza;
                KupciSearchRequest uneseni = new KupciSearchRequest();
                uneseni.KorisnickoIme = Username;
                List<Kupci> upisani = await _service.Get<List<Kupci>>(uneseni);
                if (upisani.Count > 0)
                {
                    RSII25092020InsertRequest novi = new RSII25092020InsertRequest();
                    novi.KupacId = upisani[0].KupacId;
                    List<RSII25092020> listaUpisanih = await _serviceRSII25092020.Get<List<RSII25092020>>(novi);
                    int brojPronadjeni = listaUpisanih.Count();
                    novi.DatumLogiranja = DateTime.Now;
                    if (brojPronadjeni > 1)
                        if (listaUpisanih.Last().DatumLogiranja.Date == DateTime.Now.Date)
                            if ((listaUpisanih.Last().PotencijalnoMaliciozan == false))
                                novi.PotencijalnoMaliciozan = true;
                    await _serviceRSII25092020.Insert<RSII25092020InsertRequest>(novi);
                }
            }
        }
    }
}
