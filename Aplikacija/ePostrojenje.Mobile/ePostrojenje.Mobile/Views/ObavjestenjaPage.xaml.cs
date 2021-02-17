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
    public partial class ObavjestenjaPage : ContentPage
    {
        private ObavjestenjaViewModel model = null;
        public ObavjestenjaPage()
        {
            InitializeComponent();
            BindingContext = model = new ObavjestenjaViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
    }
}