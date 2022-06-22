using System;
using System.Drawing;

namespace lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Ellipse oval = new Ellipse(Color.Black);
            
            Quadrangle quadrangle = new Quadrangle(Color.Blue);
            
            Square square = new Square(Color.DarkRed);
            
            Triangle triangle = new Triangle(Color.Green);



            Figure[] geometricFigures =
            {
                oval,
                quadrangle,
                square,
                triangle
            };

            foreach (var figure in geometricFigures)
            {
                Console.WriteLine(figure);
                figure.ShowColor();
                Console.WriteLine();
            }

            oval.GetArc();

            foreach (var figure in geometricFigures)
            {
                figure.ShowAngle();
            }
            

            int dotPositionX = 7;
            Console.WriteLine("Координата Х:" + dotPositionX);

            int dotPositionY = 8;
            Console.WriteLine("Координата У:" + dotPositionY);

            int radius = 10;
            Console.WriteLine("Радiyс овалу:" + radius);

            int lengthOfSideA = 10; 
            Console.WriteLine("Сторона А 4кутника:" + lengthOfSideA);

            int lengthOfSideB = 15; 
            Console.WriteLine("Сторона В 4кутника:" + lengthOfSideB);

            int lengthOfSquare = 20;
            Console.WriteLine("Сторона квадрата:" + lengthOfSquare);

            int height = 10;
            Console.WriteLine("Висота трикутника:" + height);

            int lengthOfBaseSide = 13;
            Console.WriteLine("Сторона трикутника:" + lengthOfBaseSide);


            foreach (var figure in geometricFigures)
            {
                Console.WriteLine(figure);
                Console.WriteLine(figure.HasDot(dotPositionX, dotPositionY));
                Console.WriteLine(" ");
            }
            

            Console.ReadLine();

        }
    }
}
