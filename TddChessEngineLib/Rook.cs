using System;
namespace TddChessEngineLib
{
    public class Rook
    {
        public string position{get;set;}
        public Rook(string startPosition)
        {
            char[] pos = startPosition.ToCharArray();
            if(Convert.ToInt32(pos[1].ToString()) < 9)
            {
                position = startPosition;
            }
            else throw new ArgumentException("cant spawn rook there");
        }
    }
}