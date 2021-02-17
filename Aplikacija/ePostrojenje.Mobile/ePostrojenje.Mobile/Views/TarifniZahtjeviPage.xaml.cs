using ePostrojenje.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ePostrojenje.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TarifniZahtjeviPage : ContentPage
    {
        private TarifniZahtjeviViewModel model = null;

        public TarifniZahtjeviPage()
        {
            InitializeComponent();
            BindingContext = model = new TarifniZahtjeviViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
            //await model.Sacuvaj();
        }
    }
}