namespace MusicTheoryApp
{
    public class Note
    {
        public string Name { get; }
        public int Index { get; }

        public Note(string name)
        {
            Name = name;
            Index = Notes.Dictionary.GetValueOrDefault(name);
        }

        public Note(int index)
        {
            Name = Notes.Dictionary.FirstOrDefault(note => note.Value == index).Key;
            Index = index;
        }
    }
}
