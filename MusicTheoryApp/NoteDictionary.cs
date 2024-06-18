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
            return (index + halfSteps) > 11 // if (note index + halfsteps up) > semitones in 1 octave
                    ? (index + halfSteps) - 12 // then return the (note index + halfsteps up) - notes in 1 octave, to loop back around
                    : (index + halfSteps); // else, return (note index + halfsteps up)
        }
    }
}
