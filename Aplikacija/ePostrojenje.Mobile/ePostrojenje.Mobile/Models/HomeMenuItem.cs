using System;
using System.Collections.Generic;
using System.Text;

namespace ePostrojenje.Mobile.Models
{
    public enum MenuItemType
    {
        Racuni,
        Tarife,
        Profil,
        Reklamacija,
        Ugovori,
        Obavjestenja,
        UgovoriPretraga
        //RSII25092020
        //Pretraga
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
