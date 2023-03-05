using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicTheoryApp
{
    public static class Notes
    {
        public static Dictionary<string, int> Dictionary = new Dictionary<string, int>()
        {
            { "A", 0 },
            { "A#", 1 },
            { "Bb", 1 },
            { "B", 3 },
            { "C", 4 },
            { "C#", 5 },
            { "Db", 5 },
            { "D", 7 },
            { "D#", 8 },
            { "Eb", 8 },
            { "E", 9 },
            { "F", 10 },
            { "F#", 11 },
            { "Gb", 11 },
            { "G", 12 },
            { "G#", 13 },
            { "Ab", 13 }
        };
    }
}
