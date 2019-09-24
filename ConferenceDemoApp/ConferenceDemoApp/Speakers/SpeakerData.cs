using System.Collections.Generic;

namespace ConferenceDemoApp.Speakers
{
    public static class SpeakerData
    {
        public static IList<Speaker> Speakers { get; private set; }

        static SpeakerData()
        {
            Speakers = new List<Speaker>();
            Speakers.Add(new Speaker
            {
                Id = 1,
                Name = "Wilhelm Brause",
                Company = "Software-Brause GmbH",
                Bio = "Wilhelm Brause ist Senior Developer bei der Software Brause GmbH."
            });

            Speakers.Add(new Speaker
            {
                Id = 2,
                Name = "Hans Dampf",
                Company = "SteamBytes Gbr",
                Bio = "Hans Dampf ist Junior Developer bei der SteamBytes Gbr."
            });


            Speakers.Add(new Speaker
            {
                Id = 3,
                Name = "Anna Gramm",
                Company = "CryptoBytes AG",
                Bio = "Anna Gramm ist Security-Spezialist  bei der CryptoBytes AG."
            });
        }
    }
}