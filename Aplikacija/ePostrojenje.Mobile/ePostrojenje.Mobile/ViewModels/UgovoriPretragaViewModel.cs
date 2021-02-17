using ePostrojenje.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ePostrojenje.Mobile.ViewModels
{
    public class UgovoriPretragaViewModel : BaseViewModel
    {
        private readonly APIService _serviceUgovori = new APIService("Ugovori");
        private readonly APIService _serviceKupci = new APIService("Kupci");

        public ObservableCollection<Ugovori> UgovoriList { get; set; } = new ObservableCollection<Ugovori>();
        public ObservableCollection<Kupci> KupciList { get; set; } = new ObservableCollection<Kupci>();

        Kupci _selectedKupac = null;

        public Kupci SelectedKupac
        {
            get { return _selectedKupac; }
            set { SetProperty(ref _selectedKupac, value); }
        }

        public UgovoriPretragaViewModel()
        {
            PretragaCommand = new Command(async () => await Pretraga());
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

        public async Task Pretraga()
        {
            Ugovori trazeni = new Ugovori();
            trazeni.DatumOd = Od;
            trazeni.DatumDo = Do;
            //trazeni.KupacId = SelectedKupac.KupacId;

            var list = await _serviceUgovori.Get<IEnumerable<Ugovori>>(trazeni);
            UgovoriList.Clear();
            if (SelectedKupac == null)
            {
                Application.Current.MainPage.DisplayAlert("Greška", "Kupca niste odabrali", "OK");
            }
            else

                foreach (var item in list)
            {
                  if(item.KupacId == SelectedKupac.KupacId)
                  UgovoriList.Add(item);
            }

        }

        public ICommand PretragaCommand { get; set; }

        public async Task Init()
        {
            if (KupciList.Count == 0)
            {

                var list = await _serviceKupci.Get<List<Kupci>>(null);
                foreach (var tarifniStavovi in list)
                {
                    KupciList.Add(tarifniStavovi);
                }
            }
        }
    }
}
