using System.Collections.Generic;
using System.Linq;

namespace ConferenceDemoApp.Sessions
{
    public static class SessionData
    {
        public static IList<Session> Sessions { get; }
        public static IList<Session> Favorites
        {
            get { return Sessions.Where(x => x.IsFavorite).ToList(); }
        }

        static SessionData()
        {
            Sessions = new List<Session>
            {
                new Session
                {
                    Id = 1,
                    Title = "EF Core und Xamarin",
                    SpeakerId = 1,
                    Speaker = "Wilhelm Brause",
                    Description = "In diesem Vortrag lernen Sie, wie Sie das EF Core unter Xamarin nutzen.",
                    IsFavorite = true
                },
                new Session
                {
                    Id = 2,
                    Title = "Durchgänngige UIs mit Xamarin.Visuals",
                    SpeakerId = 2,
                    Speaker = "Hans Dampf",
                    Description = "Ein Einblick in Xamarin.Visuals",
                    IsFavorite = false
                },
                new Session
                {
                    Id = 3,
                    Title = "Sichere Datenhaltung in Xamarin Apps",
                    SpeakerId = 3,
                    Speaker = "Anna Gramm",
                    Description =
                        "Anna Gramm erklärt in diesem Vortrag, wie Sie Ihre Daten vor unberechtigten Zugriffen schützen.",
                    IsFavorite = true
                }
            };



        }
    }
}