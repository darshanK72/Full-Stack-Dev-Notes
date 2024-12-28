using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsynchrounousPrgs
{
    class asynPrgs
    {

        //Asynchrounous Streams  
        public static async IAsyncEnumerable<int> GenerateSequence()
        {
            for (int i = 0; i < 100; i++)
            {
                await Task.Delay(100);
                yield return i;
            }
        }
        public static async Task PrintSequence()
        {
            await foreach (var number in GenerateSequence())
            {
                Console.WriteLine(number);
            }
        }
    
        static void Main(string[] args)
        {
            PrintSequence().Wait();
        }
    }
}
