using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ConferenceDemoApp.Sessions;
using ConferenceDemoApp.Speakers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConferenceDemoApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        private bool _isLoggedIn;
        public ICommand LoginCommand { get; }

        public AppShell()
        {
            InitializeComponent();
            LoginCommand = new Command(Login);
            BindingContext = this;
            RegisterRoutes();
        }

        private void RegisterRoutes()
        {
            Routing.RegisterRoute("speakers/details", typeof(SpeakerDetailsPage));
            Routing.RegisterRoute("sessions/details", typeof(SessionDetailsPage));
        }

        private void Login()
        {
            _isLoggedIn = !_isLoggedIn;
            DisplayAlert("Info", _isLoggedIn ? "Eingelogged" : "Ausgelogged", "Ok");
        }
    }
}