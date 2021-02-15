using System;

namespace Block1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите k: ");
			var k = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите q1: ");
			var q1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите q2: ");
			var q2 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите r: ");
			var r = Convert.ToInt32(Console.ReadLine());

			var F = k * (Math.Abs(q1 * q2)) * Math.Pow(r, 2);
			Console.WriteLine("F = " + F);
			Console.ReadLine();
		}
	}
}
