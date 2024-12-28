using System;

namespace ReadonlyPrgs
{

    public struct Rectangle
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public readonly double Area => (Height * Width);
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }
        public readonly override string ToString()
        {
            return $"(Total area for height: {Height}, width: {Width}) is {Area}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle obj = new Rectangle(10,4);

            Console.WriteLine(obj);
        }
    }
}
