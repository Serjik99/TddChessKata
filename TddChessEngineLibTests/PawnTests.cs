using System;
using TddChessEngineLib;
using Xunit;

namespace TddChessEngineLibTests {
    public class PawnTests {
        [Fact]
        public void WhenPawnTurnsFromE2ToE4_ThenItsPositionsChanges () {

            const string startPosition = "E2";
            const string finishPosition = "E4";
            Pawn pawn = new Pawn(startPosition,FigureColor.White);

            pawn.Turn(startPosition,finishPosition);

            Assert.Equal(finishPosition,pawn.curentPosition);
        }
        [Fact] public void WhenBlackPawnWantsToGoBack() {
            const string startPosition = "E6";
            const string finishPosition = "E8";
            Pawn pawn = new Pawn(startPosition,FigureColor.Black);

            //pawn.Turn(startPosition,finishPosition);

            Assert.Throws<ArgumentException>(() => pawn.Turn(startPosition , finishPosition));
        }
        [Fact]
        public void WhenWhitePawnTriesGoBack_ThenItsCantGoBack()
        {
            const string startPosition = "E8";
            const string finishPosition = "E6";
            Pawn pawn = new Pawn(startPosition,FigureColor.White);

            //pawn.Turn(startPosition,finishPosition);

            Assert.Throws<ArgumentException>(()=>pawn.Turn(startPosition , finishPosition));
        }

        [Fact]
        public void WhenWhitePawnTurnsFromE3ToE5_ThenItsCantJump()
        {
            const string startPosition = "E3";
            const string finishPosition = "E5";
            Pawn pawn = new Pawn(startPosition,FigureColor.White);

            //pawn.Turn(startPosition,finishPosition);

            Assert.Throws<ArgumentException>(() => pawn.Turn(startPosition , finishPosition));
        }

        }
        public class ElephantTests
        {
            [Fact]
            public void WhenCreatingElephantOnE2_ThenItCurrentPositionE2()
            {
                const string startPosition = "E2";
                Elefant elefant = new Elefant(startPosition);
                Assert.Equal(startPosition, elefant.curentPosition);
            }
            [Fact]
            public void WhenTryCreatingElephantOnE9_ThenItThrowsArgumentException()
            {
                const string startPosition = "E9";
                //Elefant elefant = new Elefant(startPosition);

                Assert.Throws<ArgumentException>(() => new Elefant(startPosition));
            }

            [Fact]
            public void WhenTryToCreateElefantOnP9()
            {
                const string startPosition = "P9";
                Assert.Throws<ArgumentException>(()=> new Elefant(startPosition));
            }
        }
    }
