using System;
using TddChessEngineLib;
using Xunit;


namespace TddChessEngineLibTests
{
    public class RookTests
    {
        [Fact]
        public void TestName()
        {
        //Given
            const string startPosition = "A1";
            Rook rook = new Rook(startPosition);
        //When
            Assert.Equal(rook.position, startPosition);
        //Then
        }
    }
}