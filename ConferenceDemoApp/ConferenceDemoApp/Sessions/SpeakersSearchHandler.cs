using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace ConferenceDemoApp.Sessions
{
    public class SessionsSearchHandler: SearchHandler
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
                ItemsSource = SessionData.Sessions.Where(
                        x => x.Title.ToLower().Contains(newValue.ToLower())
                        || x.Description.ToLower().Contains(newValue.ToLower())
                        )
                    .ToList();
            }
        }

        protected override async void OnItemSelected(object item)
        {
            base.OnItemSelected(item);
            var id = (item as Session)?.Id;
            if (id.HasValue)
            {
                await Shell.Current.GoToAsync($"sessions/details?id={id.Value}");
            }
        }
    }
}
