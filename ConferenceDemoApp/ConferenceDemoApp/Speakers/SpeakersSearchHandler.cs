using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace ConferenceDemoApp.Speakers
{
    public class SpeakersSearchHandler: SearchHandler
    {
        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);
            if (string.IsNullOrEmpty(newValue))
            {
                ItemsSource = null;
            }
            else
            {
                ItemsSource = SpeakerData.Speakers.Where(x => x.Name.ToLower().Contains(newValue.ToLower()))
                    .ToList<Speaker>();
            }
        }

        protected override async void OnItemSelected(object item)
        {
            base.OnItemSelected(item);
            var id = (item as Speaker)?.Id;
            if (id.HasValue)
            {
                await Shell.Current.GoToAsync($"speakers/details?id={id.Value}");
            }
        }
    }
}
