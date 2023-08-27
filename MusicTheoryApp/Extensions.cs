using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicTheoryApp
{
    public static class StringExtensions
    {
        public static Note? ToNote(this string note)
        {
            if (!note.IsValid())
            {
                return null;
            }

            return new Note(note.Sanitise());
        }
        public static bool IsValid(this string note)
        {
            if (string.IsNullOrWhiteSpace(note) || note.Length > 2)
            {
                return false;
            }

            if (!Notes.Dictionary.ContainsKey(note.Sanitise()))
            {
                return false;
            }

            return true;
        }

        public static string Sanitise(this string note)
        {
            return note.Length == 1 ?
                note[0].ToString().ToUpperInvariant() :
                note[0].ToString().ToUpperInvariant() + note[1];
        }
    }

}
