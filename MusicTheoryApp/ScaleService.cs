namespace MusicTheoryApp
{
    public class ScaleService : MusicTheoryAppBase
    {
        public List<Note> GetMajorScale(Note note) // i, ii, iii, iv, v, vi, vii
        {
            var rootIndex = note.Index;
            var secondIndex = NotesHelper.GetIndex(rootIndex, MajorSecondSemitoneInterval);
            var thirdIndex = NotesHelper.GetIndex(rootIndex, MajorThirdSemitoneInterval);
            var fourthIndex = NotesHelper.GetIndex(rootIndex, PerfectFourthSemitoneInterval);
            var fifthIndex = NotesHelper.GetIndex(rootIndex, PerfectFifthSemitoneInterval);
            var sixthIndex = NotesHelper.GetIndex(rootIndex, MajorSixthSemitoneInterval);
            var seventhIndex = NotesHelper.GetIndex(rootIndex, MajorSeventhSemitoneInterval);

            var thing = new List<Note>
            {
                note,
                new Note(secondIndex),
                new Note(thirdIndex),
                new Note(fourthIndex),
                new Note(fifthIndex),                
                new Note(sixthIndex),
                new Note(seventhIndex),
            };

            return thing;
        }
        
        public List<Note> GetMinorScale(Note note) // i, ii, iiib, iv, v, vib, viib
        {
            var rootIndex = note.Index;
            var secondIndex = NotesHelper.GetIndex(rootIndex, MajorSecondSemitoneInterval);
            var thirdIndex = NotesHelper.GetIndex(rootIndex, MinorThirdSemitoneInterval);
            var fourthIndex = NotesHelper.GetIndex(rootIndex, PerfectFourthSemitoneInterval);
            var fifthIndex = NotesHelper.GetIndex(rootIndex, PerfectFifthSemitoneInterval);
            var sixthIndex = NotesHelper.GetIndex(rootIndex, MinorSixthSemitoneInterval);
            var seventhIndex = NotesHelper.GetIndex(rootIndex, MinorSeventhSemitoneInterval);

            return new List<Note>
            {
                note,
                new Note(secondIndex),
                new Note(thirdIndex),
                new Note(fourthIndex),
                new Note(fifthIndex),                
                new Note(sixthIndex),
                new Note(seventhIndex),
            };
        }
    }
}
