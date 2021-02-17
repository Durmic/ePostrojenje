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
    public class PretragaViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Racuni");
        public ObservableCollection<Racuni> RacuniList { get; set; } = new ObservableCollection<Racuni>();

        public PretragaViewModel()
        {
            PretragaCommand = new Command(async () => await Pretraga());
        }

        public async Task Pretraga()
        {
            
            var list = await _service.Get<IEnumerable<Racuni>>(null);
            RacuniList.Clear();
            _suma = 0;
            foreach (var item in list)
            {
                
                if (Convert.ToDecimal(item.Napomena) >= Od && Convert.ToDecimal(item.Napomena) <= Do)
                {

                    _suma += Convert.ToDecimal(item.Napomena);
                    RacuniList.Add(item);

                }
            }
                Racuni zadnji = new Racuni();
                zadnji.RacunId = 500;
                zadnji.Napomena = Convert.ToDecimal(_suma).ToString();
                zadnji.Referenca = "Iznos: ";
                RacuniList.Add(zadnji);

        }

        decimal _suma = 0;

        public decimal Suma
        {
            get { return _suma; }
            set { SetProperty(ref _suma, value); }
        }

        decimal _od = 0;
        public decimal Od
        {
            get { return _od; }
            set { SetProperty(ref _od, value); }
        }

        decimal _do = 0;

        public decimal Do
        {
            get { return _do; }
            set { SetProperty(ref _do, value); }
        }

        public ICommand PretragaCommand { get; set; }

    }
}
