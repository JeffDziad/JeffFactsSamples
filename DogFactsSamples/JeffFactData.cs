using System;
using System.Collections.Generic;
using System.Text;

namespace DogFactsSamples
{
    public class JeffFactData    {
        public static IEnumerable<JeffFactData> All { private set; get; }
        public string TheFact { get; set; }
        public string ShortFact { get; set; }
        public string imageSource { get; set; }
        static JeffFactData()
        {
            List<JeffFactData> all = new List<JeffFactData>();
            all.Add(new JeffFactData() { TheFact = "Jeff's favorite band is The Beatles.", ShortFact = "Favorite Band", imageSource = "thebeatles.jpg" });
            all.Add(new JeffFactData() { TheFact = "Jeff's favorite aircraft is the B-1B Lancer.", ShortFact = "Favorite Aircraft", imageSource = "b1blancer.jpg" });
            all.Add(new JeffFactData() { TheFact = "Jeff uses Fusion360 to create 3D models and prints them on the ender 3 pro.", ShortFact = "3D Modeling/Printing", imageSource = "ender3pro.jpg" });
            all.Add(new JeffFactData() { TheFact = "Jeff started learning to play the Guitar when he was 10 years old.", ShortFact = "Learning Guitar", imageSource = "guitar.jpg" });
            all.Add(new JeffFactData() { TheFact = "Jeff shares a birthday with Payton Manning.", ShortFact = "Shares Birthday", imageSource = "paytonmanning.jpg" });
            All = all;
        }
    }
}
