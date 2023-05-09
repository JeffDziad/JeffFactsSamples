﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DogFactsSamples
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FactDetailPage : ContentPage
    {
        public FactDetailPage(string ShortFact, string TheFact)
        {
            InitializeComponent();
            shortFact.Text = ShortFact;
            theFact.Text = TheFact;
        }

        private void FactPopupClose(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}