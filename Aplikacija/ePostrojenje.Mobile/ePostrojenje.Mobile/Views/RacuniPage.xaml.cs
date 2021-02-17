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
    public partial class RacuniPage : ContentPage
    {
        private RacuniViewModel model = null;
        public RacuniPage()
        {
            InitializeComponent();
            BindingContext = model = new RacuniViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
    }
}