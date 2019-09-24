using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConferenceDemoApp.Sessions
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SessionsPage : ContentPage
    {
        public SessionsPage()
        {
            InitializeComponent();
        }
        private async void SessionSelected(object sender, SelectionChangedEventArgs e)
        {
            await Shell.Current.GoToAsync("sessions/details");
        }

    }
}