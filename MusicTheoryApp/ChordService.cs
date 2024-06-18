namespace MusicTheoryApp
{
    public class ChordService : MusicTheoryAppBase
    {
        public List<Note> GetMajorChord(Note note) // i, iii, v
        {
            var rootIndex = note.Index;
            var thirdIndex = NotesHelper.GetIndex(rootIndex, MajorThirdSemitoneInterval);
            var fifthIndex = NotesHelper.GetIndex(rootIndex, PerfectFifthSemitoneInterval);

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
            var thirdIndex = NotesHelper.GetIndex(rootIndex, MajorThirdSemitoneInterval);
            var fifthIndex = NotesHelper.GetIndex(rootIndex, PerfectFifthSemitoneInterval);
            var fourthIndex = NotesHelper.GetIndex(rootIndex, MajorSeventhSemitoneInterval);

            return new List<Note>
            {
                note,
                new Note(thirdIndex),
                new Note(fifthIndex),
                new Note(fourthIndex)
            };
        }

        public List<Note> GetDominantSeventhChord(Note note) // i, iii, v, viib
        {
            var rootIndex = note.Index;
            var thirdIndex = NotesHelper.GetIndex(rootIndex, MajorThirdSemitoneInterval);
            var fifthIndex = NotesHelper.GetIndex(rootIndex, PerfectFifthSemitoneInterval);
            var fourthIndex = NotesHelper.GetIndex(rootIndex, MinorSeventhSemitoneInterval);

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
            var thirdIndex = NotesHelper.GetIndex(rootIndex, MinorThirdSemitoneInterval);
            var fifthIndex = NotesHelper.GetIndex(rootIndex, PerfectFifthSemitoneInterval);

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
            var thirdIndex = NotesHelper.GetIndex(rootIndex, MinorThirdSemitoneInterval);
            var fifthIndex = NotesHelper.GetIndex(rootIndex, PerfectFifthSemitoneInterval);
            var fourthIndex = NotesHelper.GetIndex(rootIndex, MinorSeventhSemitoneInterval);

            return new List<Note>
            {
                note,
                new Note(thirdIndex),
                new Note(fifthIndex),
                new Note(fourthIndex)
            };
        }

        public List<Note> GetDiminishedChord(Note note) // i, iiib, vb 
        {
            var rootIndex = note.Index;
            var thirdIndex = NotesHelper.GetIndex(rootIndex, MinorThirdSemitoneInterval);
            var fifthIndex = NotesHelper.GetIndex(rootIndex, TritoneInterval);

            return new List<Note>
            {
                note,
                new Note(thirdIndex),
                new Note(fifthIndex)
            };
        }
    }
}
