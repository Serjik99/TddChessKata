using System;


namespace TddChessEngineLib {
    public class Pawn {
        public string curentPosition {get; private set;}
        public FigureColor FigureColor{get;}
        public Pawn(string initialPosition , FigureColor figureColor)
        {
            FigureColor = figureColor;
            curentPosition = initialPosition;
        }

        // возможность первого хода
        //1. Есть ли кто-то в точке назначения
        //2. Границы карты
        //3. Направление
        //4. Ввести переменную сходила ли пешка или нет
        //
        public void Turn (string startPosition, string finishPosition) 
        {
            char[] pos1 = startPosition.ToCharArray();
            char[] pos2 = finishPosition.ToCharArray();
            var startLine = Convert.ToInt32(pos1[1].ToString());
            var finishLine = Convert.ToInt32(pos2[1].ToString());
            if(curentPosition == startPosition)
            {
                if(FigureColor == FigureColor.Black && startLine > finishLine)
                {
                    if((startLine - finishLine == 2 && startLine == 7)||(startLine - finishLine == 1)) 
                    {
                         curentPosition = finishPosition;
                    }
                    else
                    {
                        throw new ArgumentException("try go so far");
                    }
                    
                   
                } 
                else if(FigureColor == FigureColor.White && startLine < finishLine)
                {
                    if((finishLine - startLine == 2 && startLine == 2)||(finishLine - startLine == 1)) 
                    {
                        curentPosition = finishPosition;
                    }
                    else
                    {
                        throw new ArgumentException("try go so far");
                    }
                    
                }
                else
                {
                    throw new ArgumentException("Trying to go back");
                }
               
                
            }
            else
            {
                throw new ArgumentException($"Curent position is{curentPosition}");
            }   
        }
    }

    public enum FigureColor
    {
        White,

        Black
    }
}