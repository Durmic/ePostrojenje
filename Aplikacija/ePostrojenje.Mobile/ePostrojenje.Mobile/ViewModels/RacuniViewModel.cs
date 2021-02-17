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
    public class RacuniViewModel
    {
        //private readonly _150217Context _context = new _150217Context();

        private readonly APIService _racuniService = new APIService("Racuni");
        private readonly APIService _kupciService = new APIService("Kupci");
        private readonly APIService _serviceVrsta = new APIService("VrstaAplikacije");
        #region baza
        string baza = "baza";
        string user = "mobile";
        string pass = "test";
        #endregion
        public RacuniViewModel()
        {
            InitCommand = new Command(async () => await Init());
            PlaceniCommand = new Command(async () => await Placeni());
            NeplaceniCommand = new Command(async () => await Neplaceni());
        }

        public ICommand PlaceniCommand { get; set; }

        public async Task Placeni()
        {
            Racuni trazi = new Racuni();
            trazi.Placen = true;
            var list = await _racuniService.Get<IEnumerable<Racuni>>(trazi);


            PlaceniRacuniList.Clear();
            foreach (var racuni in list)
            {
                if (racuni.Placen == true)
                    PlaceniRacuniList.Add(racuni);
            }
        }


        public ICommand NeplaceniCommand { get; set; }

        public async Task Neplaceni()
        {
            Racuni trazi = new Racuni();
            trazi.Placen = false;
            var list = await _racuniService.Get<IEnumerable<Racuni>>(trazi);


            PlaceniRacuniList.Clear();
            foreach (var racuni in list)
            {
                if (racuni.Placen == false)
                    PlaceniRacuniList.Add(racuni);
            }
        }
        public ObservableCollection<Racuni> RacuniList { get; set; } = new ObservableCollection<Racuni>();
        public ObservableCollection<Racuni> PlaceniRacuniList { get; set; } = new ObservableCollection<Racuni>();
        public ObservableCollection<Racuni> NeplaceniRacuniList { get; set; } = new ObservableCollection<Racuni>();

        public ICommand InitCommand { get; set; }
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
            var list = await _racuniService.Get<IEnumerable<Racuni>>(null);
            

            RacuniList.Clear();
            foreach (var racuni in list)
            {
                if(racuni.KupacId == tk[0].KupacId)
                    RacuniList.Add(racuni);
            }
        }
    }
}
