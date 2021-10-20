using MeronCheckRobot.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MeronCheckRobot.Views
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