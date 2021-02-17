using ePostrojenje.Mobile.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ePostrojenje.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

           // MenuPages.Add((int)MenuItemType.Browse, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    
                    case (int)MenuItemType.Racuni:
                        MenuPages.Add(id, new NavigationPage(new RacuniPage()));
                        break;
                    case (int)MenuItemType.Tarife:
                        MenuPages.Add(id, new NavigationPage(new TarifniZahtjeviPage()));
                        break;
                    case (int)MenuItemType.Profil:
                        MenuPages.Add(id, new NavigationPage(new KupacPage()));
                        break;
                    case (int)MenuItemType.Ugovori:
                        MenuPages.Add(id, new NavigationPage(new Ugovori()));
                        break;
                    case (int)MenuItemType.Reklamacija:
                        MenuPages.Add(id, new NavigationPage(new Reklamacije()));
                        break;
                    case (int)MenuItemType.Obavjestenja:
                        MenuPages.Add(id, new NavigationPage(new ObavjestenjaPage()));
                        break;
                    case (int)MenuItemType.UgovoriPretraga:
                        MenuPages.Add(id, new NavigationPage(new UgovoriPretragaPage()));
                        break;
                    //case (int)MenuItemType.RSII25092020:
                        //MenuPages.Add(id, new NavigationPage(new RSIIPage()));
                        //break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}