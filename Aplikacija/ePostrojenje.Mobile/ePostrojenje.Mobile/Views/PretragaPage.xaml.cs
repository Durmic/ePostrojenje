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
    public partial class PretragaPage : ContentPage
    {
        private PretragaViewModel model = null;
        public PretragaPage()
        {
            InitializeComponent();
            BindingContext = model = new PretragaViewModel();
        }
    }
}