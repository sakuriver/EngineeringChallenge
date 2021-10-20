using MeronCalcApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MeronCalcApp.Views
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