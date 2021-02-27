using System;
using System.Collections.Generic;
using System.ComponentModel;
using URLShortener.Models;
using URLShortener.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace URLShortener.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}