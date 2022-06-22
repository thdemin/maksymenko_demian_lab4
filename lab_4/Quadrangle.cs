using System;
using System.Drawing;


namespace lab_4
{
    public class Quadrangle : Figure
    {
        private int lengthOfSideA;
        private int lengthOfSideB;


        public Quadrangle(Color color) : base(color, 4)
        {
            lengthOfSideA = 10;
            lengthOfSideB = 15;
        }


        public override bool HasDot(int positionX, int positionY)
        {
            return lengthOfSideA >= positionX && lengthOfSideB >= positionY && positionX >= 0 && positionY >= 0;
            Console.WriteLine("");
        }

        public override void SetAngel()
        {
            for (int i = 0; i < Angels.Length; i++)
            {
                Angels[i] = 90;
            }
        }

        public override string ToString()
        {
            return "чотирикутник";
        }
    }
}
