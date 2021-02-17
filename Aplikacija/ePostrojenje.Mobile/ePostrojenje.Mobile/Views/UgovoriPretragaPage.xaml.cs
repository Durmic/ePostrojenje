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
    public partial class UgovoriPretragaPage : ContentPage
    {
        private UgovoriPretragaViewModel model = null;
        public UgovoriPretragaPage()
        {
            InitializeComponent();
            BindingContext = model = new UgovoriPretragaViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
            //await model.Sacuvaj();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}