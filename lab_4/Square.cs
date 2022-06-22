using System;
using System.Drawing;


namespace lab_4
{
    public class Square : Quadrangle
    {
        public Square(Color color) : base(color)
        {

        }


        public override string ToString()
        {
            return "квадрат";
        }
    }
}
