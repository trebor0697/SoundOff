using SoundOff.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace SoundOff.Views
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