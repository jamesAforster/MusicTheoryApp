using System.Diagnostics.Metrics;

namespace MusicTheoryApp
{
    public class App
    {
        public static void Run()
        {
            var note = GetInputNote();

            if (note == null)
            {
                Console.WriteLine("Must be a valid note.");
            }
            else
            {
                Console.WriteLine(note);
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
