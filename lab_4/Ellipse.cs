using System;
using System.Drawing;


namespace lab_4
{
    public class Ellipse : Figure
    {
        private int radius;



        public Ellipse(Color color) : base(color, 0)
        {
            radius = 10;
        }

        public void GetArc()
        {
            double a;
            a = 2 * radius * Math.PI;

            Console.WriteLine("Довжина елiпса = " + a);
            Console.WriteLine(" ");
        }

        public override void ShowAngle()
        {
            Console.WriteLine("Овал не має кутiв!");
            
        }

        public override bool HasDot(int positionX, int positionY)
        {
            return radius >= positionX && -radius <= positionX && radius >= positionY && -radius <= positionY;
            
        }

        public override void SetAngel()
        {

        }

        public override string ToString()
        {
            return "овал";
        }
    }
}
