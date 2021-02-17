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
    public partial class RSIIPage : ContentPage
    {
        private RSII25092020ViewModel model = null;
        public RSIIPage()
        {
            InitializeComponent();
            BindingContext = model = new RSII25092020ViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new RacuniPage());
        }
    }
}