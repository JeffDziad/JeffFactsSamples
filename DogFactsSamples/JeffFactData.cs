using System;
using System.Collections.Generic;
using System.Text;

namespace DogFactsSamples
{
    public class JeffFactData    {
        public static IEnumerable<JeffFactData> All { private set; get; }
        public string TheFact { get; set; }
        public string ShortFact { get; set; }
        static JeffFactData()
        {
            List<JeffFactData> all = new List<JeffFactData>();
            all.Add(new JeffFactData() { TheFact = "Jeff's favorite band is The Beatles.", ShortFact = "Favorite Band" });
            all.Add(new JeffFactData() { TheFact = "Jeff's favorite aircraft is the B-1B Lancer.", ShortFact = "Favorite Aircraft" });
            all.Add(new JeffFactData() { TheFact = "The last dish Jeff had in Poland was Pierogi.", ShortFact = "Last Dish in Poland" });
            all.Add(new JeffFactData() { TheFact = "Jeff started learning to play the Guitar when he was 10 years old.", ShortFact = "Learning Guitar" });
            all.Add(new JeffFactData() { TheFact = "Jeff plays Guitar in a couple of bands ranging in genre from Classic Rock to Jazz Fusion.", ShortFact = "Playing In Bands" });
            All = all;
        }
    }
}
