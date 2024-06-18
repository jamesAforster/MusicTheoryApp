using MusicTheoryApp;
using Xunit.Abstractions;

namespace MusicTheoryAppTests
{
    public class ScaleServiceTests
    {
        private readonly ITestOutputHelper output;

        public ScaleServiceTests(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Theory]
        [JsonFileData("scale-degrees.json", "majorScales")]
        public void GetMajorScaleReturnsCorrectNotes(
            string root, 
            string second,
            string third,
            string fourth,
            string fifth,
            string sixth,
            string seventh)
        {
            // Arrange
            var expectednotes = new List<Note>()
            {
                new Note(root),
                new Note(second),
                new Note(third),
                new Note(fourth),
                new Note(fifth),
                new Note(sixth),
                new Note(seventh)
            };

            var service = new ScaleService();
            var note = new Note(root);

            // Act
            var actualNotes = service.GetMajorScale(note);

            // Assert
            Assert.True(actualNotes[0].Name.Equals(expectednotes[0].Name) || actualNotes[0].AltName.Equals(expectednotes[0].Name));
            Assert.True(actualNotes[1].Name.Equals(expectednotes[1].Name) || actualNotes[1].AltName.Equals(expectednotes[1].Name));
            Assert.True(actualNotes[2].Name.Equals(expectednotes[2].Name) || actualNotes[2].AltName.Equals(expectednotes[2].Name));
            Assert.True(actualNotes[3].Name.Equals(expectednotes[3].Name) || actualNotes[3].AltName.Equals(expectednotes[3].Name));
            Assert.True(actualNotes[4].Name.Equals(expectednotes[4].Name) || actualNotes[4].AltName.Equals(expectednotes[4].Name));
            Assert.True(actualNotes[5].Name.Equals(expectednotes[5].Name) || actualNotes[5].AltName.Equals(expectednotes[5].Name));
            Assert.True(actualNotes[6].Name.Equals(expectednotes[6].Name) || actualNotes[6].AltName.Equals(expectednotes[6].Name));
        }
    }
}