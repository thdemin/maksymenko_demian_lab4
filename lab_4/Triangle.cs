using System;
using System.Drawing;


namespace lab_4
{
    public class Triangle : Figure
    {
        private int height;
        private int lengthOfBaseSide;

        public Triangle(Color color) : base(color, 3)
        {
            height = 10;
            lengthOfBaseSide = 15;
        }


        public override bool HasDot(int positionX, int positionY)
        {
            return height > positionY && lengthOfBaseSide / 2 > positionX;
            Console.WriteLine("висота трикутника" + height);
            Console.WriteLine("сторона трикутника" + lengthOfBaseSide);
        }

        public override void SetAngel()
        {
            for (int i = 0; i < Angels.Length; i++)
            {
                Angels[i] = 60;
            }
        }

        public override string ToString()
        {
            return "трикутник";
        }
    }
}
