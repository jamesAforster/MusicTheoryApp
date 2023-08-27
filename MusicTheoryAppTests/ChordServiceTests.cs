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
        [JsonFileData("major-scale-degrees.json")]
        public void GetMajorChordReturnsCorrectChord(IEnumerable<object> test)
        {
            // Arrange
            var service = new ChordService();
            var note = new Note("C");
            var notes = new List<string>()
            {
            };

            // Act
            var chord = service.GetMajorChord(note);

            // Assert
            for (int i = 0; i < notes.Count; i++)
            {
                Assert.Equal(notes[i], chord[i].Name);
            }
        }
    }
}