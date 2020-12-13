using System;
using TddChessEngineLib;
using Xunit;


namespace TddChessEngineLibTests
{
    public class RookTests
    {
        [Fact]
        public void SpawnRookTest()
        {
        //Given
            const string startPosition = "A1";
            Rook rook = new Rook(startPosition);
        //When
            Assert.Equal(rook.position, startPosition);
        //Then
        }

        [Fact]
        public void SpawnWithErrorPositionRookTest()
        {
            const string startPosition = "A9";
           // Rook rook = new Rook(startPosition);

            Assert.Throws<ArgumentException>(() => new Rook(startPosition));
        }
    }
}