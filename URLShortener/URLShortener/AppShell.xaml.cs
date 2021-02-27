using System;
using System.Collections.Generic;
using URLShortener.ViewModels;
using URLShortener.Views;
using Xamarin.Forms;

namespace URLShortener
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
