using ePostrojenje.Model;
using ePostrojenje.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ePostrojenje.Mobile.ViewModels
{
	public class ObavjestenjaViewModel : BaseViewModel
	{
        private readonly APIService _racuniService = new APIService("Obavjestenja");
        private readonly APIService _kupciService = new APIService("Kupci");
        private readonly APIService _serviceVrsta = new APIService("VrstaAplikacije");
        #region baza
        string baza = "baza";
        string user = "mobile";
        string pass = "test";
        #endregion
        public ObavjestenjaViewModel ()
		{
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<Obavjestenja> ObavjestenjaList { get; set; } = new ObservableCollection<Obavjestenja>();

        public ICommand InitCommand { get; set; }

        string _naslovUnos = string.Empty;
        public string NaslovUnos
        {
            get { return _naslovUnos; }
            set { SetProperty(ref _naslovUnos, value); }
        }
        public async void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            await Init();
        }
        public async Task Init()
        {
            KupciSearchRequest trenutni = new KupciSearchRequest();
            trenutni.KorisnickoIme = APIService.Username.ToString();
            //trenutni.Prezime = null;

            APIService.Username = baza;
            APIService.Password = baza;
            VrstaAplikacijeInsert vrstaApp = new VrstaAplikacijeInsert();
            vrstaApp.DesktopStatus = 0;
            await _serviceVrsta.Update<dynamic>(1, vrstaApp);
            APIService.Username = user;
            APIService.Password = pass;

            List<Model.Kupci> tk = await _kupciService.Get<List<Model.Kupci>>(trenutni);
            var list = await _racuniService.Get<IEnumerable<Obavjestenja>>(null);


            ObavjestenjaList.Clear();
            foreach (var racuni in list)
            {
                if(racuni.Naslov.StartsWith(NaslovUnos))
                ObavjestenjaList.Add(racuni);
            }
        }
    }
}