﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace PDC6_Module06
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConnectivityPage : ContentPage
    {
        public ConnectivityPage()
        {
            InitializeComponent();
        }
        private void Connectivity_Clicked(object sender, EventArgs e)
        {
            if(Connectivity.NetworkAccess != NetworkAccess.Internet) 
            {
                DisplayAlert("No Internet", "Please check your internet access.", "Ok");
                return;
            }
            if (Connectivity.NetworkAccess != NetworkAccess.None)
            {
                DisplayAlert("Connected to Internet", "You can now browse through this mobile app.", "Ok");
                return;
            }
        }

    }
}