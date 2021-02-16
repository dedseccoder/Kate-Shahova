using System;

namespace Block3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите a: ");
			int a = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите b: ");
			int b = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите c: ");
			int c = Convert.ToInt32(Console.ReadLine());

			var x = 3 * Math.Cos((Math.PI / 3) + 2 * a) + Math.Abs( Math.Log((2*a*b / c), Math.E));
			var y = (1 / (Math.Sqrt(Math.Abs(a + 1)) + Math.Sqrt(b - 2))) - Math.Sin(a);
			Console.WriteLine("X = " + x + "\nY = " + y);
			Console.ReadLine();
		}
	}
}
