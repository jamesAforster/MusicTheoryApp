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
            }

            Run();
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
