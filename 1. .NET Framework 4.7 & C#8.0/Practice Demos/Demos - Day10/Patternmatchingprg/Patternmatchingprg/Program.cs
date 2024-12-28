using System;

namespace Patternmatchingprg
{
    
    class Program
    { 
       static void Main(string[] args)
        {

            Rectangular r1 = new Rectangular { Width = 12.34, Height = 56.12 };
            Rectangular r2 = new Rectangular { Width = 56.34, Height = 56.34 };

            Circle c1 = new Circle { Redius = 34.56 };

            CalculateArea(r1);
            CalculateArea(r2);
            CalculateArea(c1);

            Console.ReadLine();



        }
        public class Figure
        {
            public const float pi = 3.14f;
        }
        public class Circle : Figure
        {
            public double Redius { get; set; }
        }
        public class Rectangular : Figure
        {
            public double Width { get; set; }
            public double Height { get; set; }
        }
        public static void CalculateArea(Figure f)
        {
            var value = f
            switch
            {
                Rectangular rec_ when rec_.Width == rec_.Height => rec_.Width * rec_.Height,
        Rectangular rec_ => rec_.Width * rec_.Height,
                Circle cir_ => Circle.pi * cir_.Redius * cir_.Redius,
                _ =>              throw new NotImplementedException()
            };
            Console.WriteLine("Areaf  {0}", value);
        }
    }
}
