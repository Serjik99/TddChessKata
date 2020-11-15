using System;


namespace TddChessEngineLib {
    public class Pawn {
        public string curentPosition {get; private set;}

        public Pawn(string initialPosition)
        {
            curentPosition = initialPosition;
        }

        public void Turn (string startPosition, string finishPosition) 
        {
            if(curentPosition == startPosition)
            {
                curentPosition = finishPosition;
            }
            else
            {
                throw new ArgumentException($"Curent position is{curentPosition}");
            }   
        }
    }
}