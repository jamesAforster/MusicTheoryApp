namespace MusicTheoryApp
{
    public class Note
    {
        public string Name { get; }
        public int Index { get; }

        public string AltName { get; }

        public Note(string name)
        {
            Name = name;
            Index = NotesHelper.Dictionary.GetValueOrDefault(name);
            AltName = GetAltName();
        }

        public Note(int index)
        {
            Name = NotesHelper.Dictionary.FirstOrDefault(note => note.Value == index).Key;
            Index = index;
            AltName = GetAltName();
        }

        private string GetAltName()
        {
            NotesHelper.AltNameMapping.TryGetValue(Name, out string? name);

            return name ?? "";
        }
    }
}
