using ePostrojenje.Model;
using ePostrojenje.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;

namespace ePostrojenje.Mobile.ViewModels
{
    public class TarifniZahtjeviViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("TarifniStavovi");
        private readonly APIService _kupacService = new APIService("Kupci");
        private readonly APIService _ugovoriService = new APIService("Ugovori");
        private readonly APIService _serviceVrsta = new APIService("VrstaAplikacije");
        #region baza
        string baza = "baza";
        string user = "mobile";
        string pass = "test";
        #endregion
        public TarifniZahtjeviViewModel()
        {
            InitCommand = new Command(async () => await Sacuvaj());
        }

        public ICommand InitCommand { get; set; }
        
        public ObservableCollection<TarifniStavovi> TarifniStavoviList { get; set; } = new ObservableCollection<TarifniStavovi>();

        string _opis = string.Empty;
        public string Opis
        {
            get { return _opis; }
            set { SetProperty(ref _opis, value); }
        }

        TarifniStavovi _selectedTarifa = null;

        public TarifniStavovi SelectedTarifa
        {
            get { return _selectedTarifa; }
            set { SetProperty(ref _selectedTarifa, value); }
        }

        public ICommand TarifaCommand { get; set; }

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


            Ugovori novi = new Ugovori();
            novi.BrojUgovora = "NEODOBRENI";
            novi.KupacId = tk[0].KupacId;
            if (SelectedTarifa == null)
            {
                Application.Current.MainPage.DisplayAlert("Greška", "Tarifu niste odabrali/Opis niste unijeli", "OK");
            }
            else
            {
                novi.TarifniStavId = SelectedTarifa.TarifniStavId;

                novi.DatumSklapanja = DateTime.Today;
                novi.OsobljeId = 1;

                if (!string.IsNullOrWhiteSpace(Opis))
                {
                    await _ugovoriService.Insert<Model.Ugovori>(novi);
                    Application.Current.MainPage.DisplayAlert("Uspjesno", "Novi zahtjev podnesen", "OK");
                }
                else
                {
                    Application.Current.MainPage.DisplayAlert("Greška", "Tarifu niste odabrali/Opis niste unijeli", "OK");
                }
            }
        }

        public async Task Init()
        {
            if (TarifniStavoviList.Count == 0)
            {

                APIService.Username = baza;
                APIService.Password = baza;
                VrstaAplikacijeInsert vrstaApp = new VrstaAplikacijeInsert();
                vrstaApp.DesktopStatus = 0;
                await _serviceVrsta.Update<dynamic>(1, vrstaApp);
                APIService.Username = user;
                APIService.Password = pass;

                var list = await _service.Get<List<TarifniStavovi>>(null);
                foreach (var tarifniStavovi in list)
                {
                    TarifniStavoviList.Add(tarifniStavovi);
                }
            }
        }
    }

    
}
