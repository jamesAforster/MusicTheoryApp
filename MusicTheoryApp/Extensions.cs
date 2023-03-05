using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicTheoryApp
{
    public static class Extensions
    {
        public static string SanitiseNote(this string note)
        {
            return note.Length == 1 ?
                note[0].ToString().ToUpperInvariant() :
                note[0].ToString().ToUpperInvariant() + note[1];
        }

        public static bool IsValid(this string note)
        {
            if (string.IsNullOrWhiteSpace(note) || note.Length > 2)
            {
                return false;
            }

            if (!Notes.Dictionary.ContainsKey(note.SanitiseNote()))
            {
                return false;
            }

            return true;
        }
    }

}
