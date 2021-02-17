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
    public class RSII25092020ViewModel : BaseViewModel
    {
        private readonly APIService _RSIIService = new APIService("RSII25092020");
        private readonly APIService _kupciService = new APIService("Kupci");

        public RSII25092020ViewModel()
        {
            InitCommand = new Command(async () => await Init());
            PonistiCommand = new Command(async () => await Ponisti());
        }
        async Task Ponisti()
        {
            RSII25092020SearchRequest search = new RSII25092020SearchRequest();
            search.KupacId = SelectedKupac.KupacId;
            search.PotencijalnoMaliciozan = false;
            var list = await _RSIIService.Get<List<RSII25092020>>(search);
            foreach (var rsii in list)
            {
                RSII25092020InsertRequest unosNovog = new RSII25092020InsertRequest();
                unosNovog.DatumLogiranja = rsii.DatumLogiranja;
                unosNovog.KupacId = rsii.KupacId;
                unosNovog.PotencijalnoMaliciozan = true;
                await _RSIIService.Update<RSII25092020InsertRequest>(rsii.Rsid, unosNovog);
            }
            InitCommand.Execute(null);
            
        }
        public ICommand PonistiCommand { get; set; }

        string _imePrezime = string.Empty;
        public string ImePrezime
        {
            get { return _imePrezime; }
            set { SetProperty(ref _imePrezime, value); }
        }

        bool _potencijalnoMaliciozan = false;
        public bool PotencijalnoMaliciozan
        {
            get { return _potencijalnoMaliciozan; }
            set { SetProperty(ref _potencijalnoMaliciozan, value);            }
        }

        Kupci _selectedKupac = null;
        public Kupci SelectedKupac
        {
            get { return _selectedKupac; }
            set { 
                SetProperty(ref _selectedKupac, value);
                if (value != null)
                    InitCommand.Execute(null);
            }
        }

        DateTime _od = DateTime.Now;
        public DateTime Od
        {
            get { return _od; }
            set { SetProperty(ref _od, value); }
        }

        DateTime _do = DateTime.Now;
        public DateTime Do
        {
            get { return _do; }
            set { SetProperty(ref _do, value); }
        }

        public ObservableCollection<RSII25092020> RSIIList { get; set; } = new ObservableCollection<RSII25092020>();
        public ObservableCollection<Kupci> KupciList { get; set; } = new ObservableCollection<Kupci>();
        public ICommand InitCommand { get; set; }


        public async Task Init()
        {
            if(KupciList.Count == 0)
            {
                var kupciList = await _kupciService.Get<List<Kupci>>(null);
                foreach (var kupac in kupciList)
                {
                    KupciList.Add(kupac);
                }
            }



            if (SelectedKupac != null)
            {
                RSII25092020SearchRequest search = new RSII25092020SearchRequest();
                search.KupacId = SelectedKupac.KupacId;
                search.PotencijalnoMaliciozan = PotencijalnoMaliciozan;
                search.DatumOd = Od;
                search.DatumDo = Do;
                var list = await _RSIIService.Get<IEnumerable<RSII25092020>>(search);


                RSIIList.Clear();
                foreach (var racuni in list)
                {
                    //if (racuni.KupacId == tk[0].KupacId)
                    RSIIList.Add(racuni);
                }
            }
            
        }

    }
}
