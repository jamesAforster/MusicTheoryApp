using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicTheoryApp
{
    public class ChordService
    {
        public List<int> MajorIntervals = new List<int>() { 4, 7 };
        public List<Note> GetMajorChord(Note note)
        {
            var rootIndex = note.Index; // D 5
            var thirdIndex = note.Index + MajorIntervals[0] > 11 ? note.Index + MajorIntervals[0] - 12 : note.Index + MajorIntervals[0];
            var fifthIndex = note.Index + MajorIntervals[1] > 11 ? note.Index + MajorIntervals[1] - 12 : note.Index + MajorIntervals[1];

            Note root = new Note(rootIndex);
            Note third = new Note(thirdIndex);
            Note fifth = new Note(fifthIndex);

            return new List<Note> { root, third, fifth };
        }
    }
}
