using ePostrojenje.Mobile.Models;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ePostrojenje.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                //new HomeMenuItem {Id = MenuItemType.Browse, Title="Browse" },
                //new HomeMenuItem {Id = MenuItemType.About, Title="About" },
                new HomeMenuItem {Id = MenuItemType.Profil, Title="Korisnički profil" },
                new HomeMenuItem {Id = MenuItemType.Tarife, Title="Tarifni zahtjev" },
                new HomeMenuItem {Id = MenuItemType.Racuni, Title="Računi" },
                new HomeMenuItem {Id = MenuItemType.Reklamacija, Title="Reklamacija" },
                new HomeMenuItem {Id = MenuItemType.Ugovori, Title="Ugovori" },
                new HomeMenuItem {Id = MenuItemType.Obavjestenja, Title="Obavjestenja" },
                new HomeMenuItem {Id = MenuItemType.UgovoriPretraga, Title="Pretraga" },
                //new HomeMenuItem {Id = MenuItemType.RSII25092020, Title="RSII25092020" }
                //new HomeMenuItem {Id = MenuItemType.Pretraga, Title="Pretraga" },

            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}