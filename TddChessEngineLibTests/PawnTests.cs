using System;
using TddChessEngineLib;
using Xunit;

namespace TddChessEngineLibTests {
    public class PawnTests {
        [Fact]
        public void WhenPawnTurnsFromE2ToE4_ThenItsPositionsChanges () {

            const string startPosition = "E2";
            const string finishPosition = "E4";
            Pawn pawn = new Pawn(startPosition);

            pawn.Turn(startPosition,finishPosition);
            
            Assert.Equal(finishPosition,pawn.curentPosition);
        }

        }
    }
