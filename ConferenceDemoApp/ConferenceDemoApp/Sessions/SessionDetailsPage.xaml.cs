using System;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConferenceDemoApp.Sessions
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [QueryProperty("SessionId", "id")]
    public partial class SessionDetailsPage : ContentPage
    {
        public SessionDetailsPage()
        {
            InitializeComponent();
        }
        public string SessionId
        {
            set
            {
                if (int.TryParse(Uri.UnescapeDataString(value), out var id))
                {
                    BindingContext = SessionData.Sessions.FirstOrDefault(x => x.Id == id);
                }

            }
        }


    }
}