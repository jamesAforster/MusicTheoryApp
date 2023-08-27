using MusicTheoryApp;
using Xunit.Abstractions;

namespace MusicTheoryAppTests
{
    public class ChordServiceTests
    {
        private readonly ITestOutputHelper output;

        public ChordServiceTests(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Theory]
        [JsonFileData("scale-degrees.json", "majorChords")]
        public void GetMajorChordReturnsCorrectChord(string root, string third, string fifth)
        {
            // Arrange
            var expectednotes = new List<Note>()
            {
                new Note(root),
                new Note(third),
                new Note(fifth)
            };

            var service = new ChordService();
            var note = new Note(root);

            // Act
            var actualNotes = service.GetMajorChord(note);


            // Assert
            foreach(Note actualNote in actualNotes)
            {
                var degreeNotes = Notes.Dictionary
                    .Where(x => x.Value == actualNote.Index)
                    .Select(x => x.Key);

                Assert.True(degreeNotes.Contains(root) || degreeNotes.Contains(third) || degreeNotes.Contains(fifth));
            }
        }

        [Theory]
        [JsonFileData("scale-degrees.json", "minorChords")]
        public void GetMinorChordReturnsCorrectChord(string root, string third, string fifth)
        {
            // Arrange
            var expectednotes = new List<Note>()
            {
                new Note(root),
                new Note(third),
                new Note(fifth)
            };

            var service = new ChordService();
            var note = new Note(root);

            // Act
            var actualNotes = service.GetMinorChord(note);


            // Assert
            foreach (Note actualNote in actualNotes)
            {
                var degreeNotes = Notes.Dictionary
                    .Where(x => x.Value == actualNote.Index)
                    .Select(x => x.Key);

                Assert.True(degreeNotes.Contains(root) || degreeNotes.Contains(third) || degreeNotes.Contains(fifth));
            }
        }
    }
}