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
	public partial class Reklamacije : ContentPage
	{

        private ReklamacijeViewModel model = null;

        public Reklamacije()
        {
            InitializeComponent();
            BindingContext = model = new ReklamacijeViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            //await model.Sacuvaj();
            //await model.Sacuvaj();
        }
    }
}