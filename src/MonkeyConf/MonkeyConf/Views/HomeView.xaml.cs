using MonkeyConf.ViewModels;
using Xamarin.Forms;

namespace MonkeyConf.Views
{
    public partial class HomeView : ContentPage
    {
        public HomeView()
        {
            InitializeComponent();

            BindingContext = new HomeViewModel();
        }
    }
}