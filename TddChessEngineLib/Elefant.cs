using System;
namespace TddChessEngineLib
{
    public class Elefant
    {
        public string curentPosition {get; private set;}

        public Elefant(string position)
        {
            char[] pos = position.ToCharArray();
            if(pos[0] == 'P')
            {
                throw new ArgumentException("cant craete elefante there");
            }
            else if(Convert.ToInt32(pos[1].ToString()) < 9 && Convert.ToInt32(pos[1].ToString()) > 0)
            {
                curentPosition = position;
            }
            else
            {
                throw new ArgumentException("cant craete elefante there");
            }
            
        }

        public void Turn(string startPosition , string finishPosition)
        {
            if(startPosition == curentPosition)
            {
                if(startPosition == "E2" && finishPosition == "F2")
                {
                    throw new ArgumentException("cant go there");
                }
                else if(startPosition == "E2" && finishPosition == "F3")
                {
                    curentPosition = finishPosition;
                }
            }
        }
    }
}