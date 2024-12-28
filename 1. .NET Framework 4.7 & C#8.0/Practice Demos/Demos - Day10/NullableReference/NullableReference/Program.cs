using System;

namespace NullableReference
{
    class Car
    {
        //Nullable Property
        public string? Brand { get; set; }
        public string? Make { get; set; }
        //compiler warns you of possible null reference exceptions when you use a nullable property. 
        private static void NullableReferencetype()
        {
            var car = new Car();
            Console.WriteLine(car.Make.Length);

        }
        static void Main(string[] args)
        {
            NullableReferencetype();
           
        }   

    } 
}
    

