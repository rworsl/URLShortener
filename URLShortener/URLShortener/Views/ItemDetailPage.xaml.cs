using System.ComponentModel;
using URLShortener.ViewModels;
using Xamarin.Forms;

namespace URLShortener.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}