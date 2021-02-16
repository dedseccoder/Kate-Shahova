using System;

namespace Block4
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите x: ");
			var x = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите a: ");
			var a = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите b: ");
			var b = Convert.ToInt32(Console.ReadLine());
			double F;

			if (x < 2)
			{
				F = Math.Log(Math.Abs(x / (a + b)), Math.E);
			}
			else
			{
				F = a + b * Math.Pow(Math.Tan(x), 2);
			}
			var Y = Math.Cos(F);
			Console.WriteLine("Y = " + Y);
			Console.ReadLine();
		}
	}
}
