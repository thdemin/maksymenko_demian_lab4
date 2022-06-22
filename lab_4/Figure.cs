using System;
using System.Drawing;


namespace lab_4
{
    public abstract class Figure
    {
        protected Color Color;
        protected int[] Angels;

        //public string Name { get; set; }
        //public string color { get; set; }
        //public abstract void Color();
        //public string kolor { get; set; }
        //public abstract void Kolor();

        protected Figure(Color color, int countOfAngel) 
        {
            Color = color;
            Angels = new int[countOfAngel];
            
        }

        public void ShowColor()
        {
            Console.WriteLine(Color);

        }

        public virtual void ShowAngle()
        {
            SetAngel();
            Console.WriteLine($"Кути: {ToString()}");
            foreach (var angel in Angels)
            {
                Console.WriteLine(angel);
                
            }
            Console.WriteLine(" ");
        }

        public abstract bool HasDot(int positionX, int positionY);
        public abstract void SetAngel();

    }
}
