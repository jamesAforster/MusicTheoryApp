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
        public void GetMajorChordReturnsCorrectChord(string root, string majorThird, string perfectFifth)
        {
            // Arrange
            var notes = new List<string>()
            {
                root,
                majorThird,
                perfectFifth
            };

            var service = new ChordService();
            var note = new Note(root);

            // Act
            var chord = service.GetMajorChord(note);

            // Assert
            Assert.Equal(chord[0].Name, root);
            Assert.Equal(chord[1].Name, majorThird);
            Assert.Equal(chord[2].Name, perfectFifth);
        }
    }
}