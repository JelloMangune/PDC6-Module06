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
    public partial class GeoLocationPage : ContentPage
    {
        bool isGettingLocation;
        public GeoLocationPage()
        {
            InitializeComponent();
        }

        async void Start_Locate(System.Object sender, System.EventArgs e)
        {
            isGettingLocation = true;
            while (isGettingLocation)
            {
                var result = await Geolocation.GetLocationAsync(new GeolocationRequest(GeolocationAccuracy.Default, TimeSpan.FromMinutes(1)));

                resultLocation.Text += $"lat: {result.Latitude}, lng: {result.Longitude}{Environment.NewLine}";
            }
        }
        async void Stop_Locate(System.Object sender, System.EventArgs e)
        {
            isGettingLocation = false;
        }
    }
}