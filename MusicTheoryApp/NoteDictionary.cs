namespace MusicTheoryApp
{
    public static class NotesHelper
    {
        public static Dictionary<string, int> Dictionary = new Dictionary<string, int>()
        {
            { "A", 0 },
            { "A#", 1 },
            { "Bb", 1 },
            { "B", 2 },
            { "C", 3 },
            { "C#", 4 },
            { "Db", 4 },
            { "D", 5 },
            { "D#", 6 },
            { "Eb", 6 },
            { "E", 7 },
            { "F", 8 },
            { "F#", 9 },
            { "Gb", 9 },
            { "G", 10 },
            { "G#", 11 },
            { "Ab", 11 }
        };

        public static Dictionary<string, string> AltNameMapping = new Dictionary<string, string>()
        {
            { "A#", "Bb" },
            { "Bb", "A#" },
            { "C#", "Db" },
            { "Db", "C#" },
            { "D#", "Eb" },
            { "Eb", "D#" },
            { "F#", "Gb" },
            { "Gb", "F#" },
            { "G#", "Ab" },
            { "Ab", "G#" }
        };
        
        public static int GetIndex(int index, int halfSteps)
        {
            return index // C
                + halfSteps > 11 // C + 7 > 11?
                    ? index + halfSteps - 12
                    : // 
                    index + halfSteps;
        }
    }
}
