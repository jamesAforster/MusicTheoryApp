using MusicTheoryApp;
using System.Xml.Linq;
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
            Assert.True(actualNotes[0].Name.Equals(expectednotes[0].Name) || actualNotes[0].AltName.Equals(expectednotes[0].Name));
            Assert.True(actualNotes[1].Name.Equals(expectednotes[1].Name) || actualNotes[1].AltName.Equals(expectednotes[1].Name));
            Assert.True(actualNotes[2].Name.Equals(expectednotes[2].Name) || actualNotes[2].AltName.Equals(expectednotes[2].Name));
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
            Assert.True(actualNotes[0].Name.Equals(expectednotes[0].Name) || actualNotes[0].AltName.Equals(expectednotes[0].Name));
            Assert.True(actualNotes[1].Name.Equals(expectednotes[1].Name) || actualNotes[1].AltName.Equals(expectednotes[1].Name));
            Assert.True(actualNotes[2].Name.Equals(expectednotes[2].Name) || actualNotes[2].AltName.Equals(expectednotes[2].Name));
        }

        [Theory]
        [JsonFileData("scale-degrees.json", "minorSeventhChords")]
        public void GetMinorSeventhChordReturnsCorrectChord(string root, string third, string fifth, string seventh)
        {
            // Arrange
            var expectednotes = new List<Note>()
            {
                new Note(root),
                new Note(third),
                new Note(fifth),
                new Note(seventh)
            };

            var service = new ChordService();
            var note = new Note(root);

            // Act
            var actualNotes = service.GetMinorSeventhChord(note);

            // Assert
            Assert.True(actualNotes[0].Name.Equals(expectednotes[0].Name) || actualNotes[0].AltName.Equals(expectednotes[0].Name));
            Assert.True(actualNotes[1].Name.Equals(expectednotes[1].Name) || actualNotes[1].AltName.Equals(expectednotes[1].Name));
            Assert.True(actualNotes[2].Name.Equals(expectednotes[2].Name) || actualNotes[2].AltName.Equals(expectednotes[2].Name));
            Assert.True(actualNotes[3].Name.Equals(expectednotes[3].Name) || actualNotes[3].AltName.Equals(expectednotes[3].Name));
        }
    }
}