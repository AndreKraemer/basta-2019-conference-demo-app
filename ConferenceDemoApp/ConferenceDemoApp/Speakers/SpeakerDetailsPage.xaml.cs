using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConferenceDemoApp.Speakers
{
    [QueryProperty("SpeakerId", "id")]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SpeakerDetailsPage : ContentPage
    {
        public SpeakerDetailsPage()
        {
            InitializeComponent();
        }

        public string SpeakerId
        {
            set
            {
                if (int.TryParse(Uri.UnescapeDataString(value), out var id))
                {
                    BindingContext = SpeakerData.Speakers.FirstOrDefault(x => x.Id == id);
                }

            }
        }

    }
}