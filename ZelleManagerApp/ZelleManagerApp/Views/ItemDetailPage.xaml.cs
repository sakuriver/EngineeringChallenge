using System.ComponentModel;
using Xamarin.Forms;
using ZelleManagerApp.ViewModels;

namespace ZelleManagerApp.Views
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