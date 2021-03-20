using ApiProyect.ViewModel;
using Refit;
using Xamarin.Forms;

namespace ApiProyect
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new CoachViewModel();
        }

        
    }
}