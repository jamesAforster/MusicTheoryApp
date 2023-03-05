using System.Diagnostics.Metrics;

namespace MusicTheoryApp
{
    public class App
    {
        public static void Run()
        {
            var input = GetInputNote();
            Note note;

            if (input == null)
            {
                Console.WriteLine("Must be a valid note.");
            }
            else
            {
                note = new Note(input);
                Console.Write("Name: " + note.Name);
                Console.WriteLine(" ");
                Console.Write("Index: " + note.Index);
                Console.WriteLine(" ");
            }

            Run();
        }

        private static string GetInputNote()
        {
            Console.WriteLine("Enter a note: ");

            var input = Console.ReadLine();

            if (!input.IsValid())
            {
                return null;
            }

            return input.SanitiseNote();
        }
    }
}
