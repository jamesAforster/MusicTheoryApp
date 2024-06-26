﻿using System;
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
            return !note.IsValid() ? null : new Note(note.Sanitise());
        }
        public static bool IsValid(this string note)
        {
            note = note.Trim();

            if (string.IsNullOrWhiteSpace(note) || note.Length > 2)
            {
                return false;
            }

            note = note.Sanitise();

            if (!NotesHelper.Dictionary.ContainsKey(note))
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
