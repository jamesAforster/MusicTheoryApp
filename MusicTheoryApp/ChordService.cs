namespace MusicTheoryApp
{
    public class ChordService
    {
        int MinorThirdSemitoneInterval = 3;
        int MajorThirdSemitoneInterval = 4;
        int PerfectFifthSemitoneInterval = 7;
        int MinorSeventhSemitoneInterval = 10;
        int MajorSemitoneInterval = 11;

        public List<Note> GetMajorChord(Note note) // i, iii, v
        {
            var rootIndex = note.Index;
            var thirdIndex = GetIndex(rootIndex, MajorThirdSemitoneInterval);
            var fifthIndex = GetIndex(rootIndex, PerfectFifthSemitoneInterval);

            return new List<Note>
            {
                note,
                new Note(thirdIndex),
                new Note(fifthIndex)
            };
        }

        public List<Note> GetMajorSeventhChord(Note note) // i, iii, v, vii
        {
            var rootIndex = note.Index;
            var thirdIndex = GetIndex(rootIndex, MajorThirdSemitoneInterval);
            var fifthIndex = GetIndex(rootIndex, PerfectFifthSemitoneInterval);
            var fourthIndex = GetIndex(rootIndex, MajorSemitoneInterval);

            return new List<Note>
            {
                note,
                new Note(thirdIndex),
                new Note(fifthIndex),
                new Note(fourthIndex)
            };
        }

        public List<Note> GetDominanteventhChord(Note note) // i, iii, v, viib
        {
            var rootIndex = note.Index;
            var thirdIndex = GetIndex(rootIndex, MajorThirdSemitoneInterval);
            var fifthIndex = GetIndex(rootIndex, PerfectFifthSemitoneInterval);
            var fourthIndex = GetIndex(rootIndex, MinorSeventhSemitoneInterval);

            return new List<Note>
            {
                note,
                new Note(thirdIndex),
                new Note(fifthIndex),
                new Note(fourthIndex)
            };
        }

        public List<Note> GetMinorChord(Note note) // i, iib, v
        {
            var rootIndex = note.Index;
            var thirdIndex = GetIndex(rootIndex, MinorThirdSemitoneInterval);
            var fifthIndex = GetIndex(rootIndex, PerfectFifthSemitoneInterval);

            return new List<Note>
            {
                note,
                new Note(thirdIndex),
                new Note(fifthIndex)
            };
        }

        public List<Note> GetMinorSeventhChord(Note note) // i, iib, v, viib
        {
            var rootIndex = note.Index;
            var thirdIndex = GetIndex(rootIndex, MinorThirdSemitoneInterval);
            var fifthIndex = GetIndex(rootIndex, PerfectFifthSemitoneInterval);
            var fourthIndex = GetIndex(rootIndex, MinorSeventhSemitoneInterval);

            return new List<Note>
            {
                note,
                new Note(thirdIndex),
                new Note(fifthIndex),
                new Note(fourthIndex)
            };
        }

        private int GetIndex(int index, int halfSteps)
        {
            return index // C
                + halfSteps > 11 // C + 7 > 11?
                ? 
                index + halfSteps - 12 : // 
                index + halfSteps;
        }
    }
}
