using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace AsyncDisposePrg
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await using (var disposableObject = new Foo())
            {
                Console.WriteLine("Hello World!");
            }

            Console.WriteLine("Done!");
        }
    }

    class Foo : IAsyncDisposable
    {
        public async ValueTask DisposeAsync()
        {
            Console.WriteLine("Delaying!");
            await Task.Delay(1000);
            Console.WriteLine("Disposed!");
        }
    }
}
