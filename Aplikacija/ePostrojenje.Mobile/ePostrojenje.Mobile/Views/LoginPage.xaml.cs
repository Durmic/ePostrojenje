﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
//using ePostrojenje.Model.vrstaApp;
namespace ePostrojenje.Mobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
            //vrstaApp.GlobalBoolean = true;
            InitializeComponent ();
		}
	}
}