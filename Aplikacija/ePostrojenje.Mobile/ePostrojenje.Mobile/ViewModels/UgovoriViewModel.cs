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
    public class UgovoriViewModel
    {
        private readonly APIService _ugovoriService = new APIService("Ugovori");
        private readonly APIService _kupciService = new APIService("Kupci");
        private readonly APIService _serviceVrsta = new APIService("VrstaAplikacije");
        #region baza
        string baza = "baza";
        string user = "mobile";
        string pass = "test";
        #endregion
        public UgovoriViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Ugovori> UgovoriList { get; set; } = new ObservableCollection<Ugovori>();

        public ICommand InitCommand { get; set; }
        public async Task Init()
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

            List<Model.Kupci> tk = await _kupciService.Get<List<Model.Kupci>>(trenutni);
            var list = await _ugovoriService.Get<IEnumerable<Ugovori>>(null);


            UgovoriList.Clear();
            foreach (var ugovori in list)
            {
                if (ugovori.KupacId == tk[0].KupacId)
                    UgovoriList.Add(ugovori);
            }
        }
    }
}
