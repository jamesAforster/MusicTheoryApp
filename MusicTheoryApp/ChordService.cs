namespace MusicTheoryApp
{
    public class ChordService
    {
        int MajorThirdInterval = 4;
        int PerfectFifthInterval = 7;

        public List<Note> GetMajorChord(Note note)
        {
            var rootIndex = note.Index;
            var thirdIndex = GetIndex(rootIndex, MajorThirdInterval);
            var fifthIndex = GetIndex(rootIndex, PerfectFifthInterval);

            return new List<Note>
            {
                note,
                new Note(thirdIndex),
                new Note(fifthIndex)
            };
        }

        private int GetIndex(int index, int halfSteps)
        {
            return index + halfSteps > 11 ? index + halfSteps - 12 : index + halfSteps;
        }
    }
}
