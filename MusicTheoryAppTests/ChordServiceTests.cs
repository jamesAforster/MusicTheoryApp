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
    
        [Fact]
        public void GetMajorChordReturnsCorrectChord()
        {
            // Arrange
            var service = new ChordService();
            var note = new Note("C");
            var notes = new List<string>()
            {
                "C",
                "E",
                "D"
            };

            // Act
            var chord = service.GetMajorChord(note);

            // Assert
            for (int i = 0; i > notes.Count; i++)
            {
                Assert.Equal(notes[i], chord[i].Name);
            }
        }
    }
}