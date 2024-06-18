namespace MusicTheoryApp
{
    public class App
    {
        public ChordService _chordService;
        public ScaleService _scaleService;

        public App() 
        { 
            _chordService = new ChordService();
            _scaleService = new ScaleService();
        }

        public void Run()
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
                Console.WriteLine("Press 1 to get chords: ");
                LineBreak();
                Console.WriteLine("Press 2 to get scales: ");
                LineBreak();

                int.TryParse(Console.ReadLine(), out int numberSelection);

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
                        GetChord(note);
                        break;
                    case 2:
                        GetScale(note);
                        break;
                }
            }

            Run();
        }
        
        public void GetScale(Note note)
        {
            Console.Write("Name: " + note.Name);
            LineBreak();
            Console.Write("Index: " + note.Index);
            LineBreak();
            Console.WriteLine("Please make a selection: ");
            Console.WriteLine("1. Major Scale");
            Console.WriteLine("2. Minor Scale");
            LineBreak();
            
            int.TryParse(Console.ReadLine(), out int numberSelection);

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
                    GetMajorScale(note);
                    break;
                case 2:
                    GetMinorScale(note);
                    break;
            }
        }

        public void GetChord(Note note)
        {
            Console.Write("Name: " + note.Name);
            LineBreak();
            Console.Write("Index: " + note.Index);
            LineBreak();
            Console.WriteLine("Please make a selection: ");
            Console.WriteLine("1. Major Chord");
            Console.WriteLine("2. Minor Chord");
            Console.WriteLine("3. Major Seventh Chord");
            Console.WriteLine("4. Dominant Seventh Chord");
            Console.WriteLine("5. Minor Seventh Chord");
            Console.WriteLine("6. Diminshed Chord");
            LineBreak();

            int.TryParse(Console.ReadLine(), out int numberSelection);

            if (numberSelection < 0 || numberSelection > 6)
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
                case 3:
                    GetMajorSeventhChord(note);
                    break;
                case 4:
                    GetDominantSeventhChord(note);
                    break;
                case 5:
                    GetMinorSeventhChord(note);
                    break;
                case 6:
                    GetDiminishedChord(note);
                    break;
            }
        }
        
        public void GetMajorScale(Note note)
        {
            List<Note> scaleNotes = _scaleService.GetMajorScale(note);
            Console.WriteLine($"Notes in {note.Name} Major: ");
            scaleNotes.ForEach(note => Console.WriteLine(note.Name + " "));
        }


        public void GetMinorScale(Note note)
        {
            List<Note> scaleNotes = _scaleService.GetMinorScale(note);
            Console.WriteLine($"Notes in {note.Name} Minor: ");
            scaleNotes.ForEach(note => Console.WriteLine(note.Name + " "));
        }
        
        public void GetMajorChord(Note note)
        {
            List<Note> chordNotes = _chordService.GetMajorChord(note);
            Console.WriteLine($"Notes in {note.Name} Major: ");
            chordNotes.ForEach(note => Console.WriteLine(note.Name + " "));
        }

        public void GetMinorChord(Note note)
        {
            List<Note> chordNotes = _chordService.GetMinorChord(note);
            Console.WriteLine($"Notes in {note.Name} Minor: ");
            chordNotes.ForEach(note => Console.WriteLine(note.Name + " "));
        }

        public void GetMajorSeventhChord(Note note)
        {
            List<Note> chordNotes = _chordService.GetMajorSeventhChord(note);
            Console.WriteLine($"Notes in {note.Name} Major Seventh: ");
            chordNotes.ForEach(note => Console.WriteLine(note.Name + " "));
        }
        public void GetDominantSeventhChord(Note note)
        {
            List<Note> chordNotes = _chordService.GetDominantSeventhChord(note);
            Console.WriteLine($"Notes in {note.Name} Dominant Seventh: ");
            chordNotes.ForEach(note => Console.WriteLine(note.Name + " "));
        }

        public void GetMinorSeventhChord(Note note)
        {
            List<Note> chordNotes = _chordService.GetMinorSeventhChord(note);
            Console.WriteLine($"Notes in {note.Name} Minor Seventh: ");
            chordNotes.ForEach(note => Console.WriteLine(note.Name + " "));
        }

        public void GetDiminishedChord(Note note)
        {
            List<Note> chordNotes = _chordService.GetDiminishedChord(note);
            Console.WriteLine($"Notes in {note.Name} Diminished: ");
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
