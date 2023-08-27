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
        [InlineData("C", "E", "G")]
        public void GetMajorChordReturnsCorrectChord(string note1, string note2, string note3)
        {
            // Arrange
            var service = new ChordService();
            var note = new Note("C");
            var notes = new List<string>()
            {
                note1,
                note2,
                note3
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