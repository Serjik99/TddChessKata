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

    public enum FigureColor
    {
        White,

        Black
    }
}