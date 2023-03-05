namespace MusicTheoryApp
{
    internal class Note
    {
        public string Name { get; }
        public int Index { get; }

        public Note(string name)
        {
            Name = name;
            Index = Notes.Dictionary.GetValueOrDefault(name);
        }
    }
}
