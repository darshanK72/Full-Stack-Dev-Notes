using System;

namespace null_coalescing_assignment__operator
{
    class nullCoalecing
    {
        static void Main(string[] args)
        {
			
			// create a null variable
			string var1 = null;
			string var2 = "Eductaive.io";
			// assign var1 to var3 using ??=
			string var3 = var1 ??= var2;
			//display var3
			Console.WriteLine("Value of var3 is: ");
			Console.WriteLine(var3);

		
			// create nullable value type
			int? var4 = null;
			int var5 = var4 ??= 40;
			Console.WriteLine("Value of var5 is: ");
			Console.WriteLine(var5);

			// condense if else statement
			int? var6 = null;
			int a = 5;

			if (var6 is null)
			{
				var6 = a;
			}

			Console.WriteLine("Value of var6 is: ");
			Console.WriteLine(var6);

			int? var7 = null;
			var7 ??= 20;

			Console.WriteLine("Value of var7 is: ");
			Console.WriteLine(var7);




		}
	}
}

    