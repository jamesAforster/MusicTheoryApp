namespace MusicTheoryApp
{
    public class App
    {
        public static void Run()
        {
            LineBreak();
            Console.WriteLine("Enter a note: ");

            Note note = GetInputNote();

            if (note == null)
            {
                LineBreak();
                Console.WriteLine("Must be a valid note.");
                LineBreak();
                Run();
            }
            else
            {
                LineBreak();
                Console.Write("Name: " + note.Name);
                LineBreak();
                Console.Write("Index: " + note.Index);
                LineBreak();
                Console.WriteLine("Please make a selection: ");
                Console.WriteLine("1. Major Chord");
                Console.WriteLine("2. Minor Chord");
                LineBreak();

                var selection = int.TryParse(Console.ReadLine(), out int numberSelection);

                if (numberSelection < 0 || numberSelection > 2)
                {
                    LineBreak();
                    Console.WriteLine("Must be a valid selection.");
                    LineBreak();
                    Run();
                }

                switch (numberSelection)
                {
                    case 1:
                        GetMajorChord(note);
                        break;
                    case 2:
                        GetMinorChord(note);
                        break;
                }
            }

            Run();
        }

        public static void GetMajorChord(Note note)
        {
            var chordService = new ChordService();
            List<Note> chordNotes = chordService.GetMajorChord(note);
            Console.WriteLine($"Notes in {note.Name} Major: ");
            chordNotes.ForEach(note => Console.WriteLine(note.Name + " "));
        }

        public static void GetMinorChord(Note note)
        {
            var chordService = new ChordService();
            List<Note> chordNotes = chordService.GetMinorChord(note);
            Console.WriteLine($"Notes in {note.Name} Major: ");
            chordNotes.ForEach(note => Console.WriteLine(note.Name + " "));
        }

        private static Note GetInputNote()
        {
            var input = Console.ReadLine();

            return input.ToNote();
        }

        private static void LineBreak()
        {
            Console.WriteLine(" ");
        }
    }
}
