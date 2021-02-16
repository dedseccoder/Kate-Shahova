using System;
using System.Drawing;

namespace Block2
{
	class Program
	{
		static void Main(string[] args)
		{
			int x1, x2, x3;
			int y1, y2, y3;
			Point point1, point2, point3;

			Console.Write("Введите Х первой точки: ");
			x1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите Y первой точки: ");
			y1 = Convert.ToInt32(Console.ReadLine());
			point1 = new Point(x1, y1);
			Console.WriteLine("X = " + point1.X + "\t Y = " + point1.Y);

			Console.Write("Введите Х второй точки: ");
			x2 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите Y второй точки: ");
			y2 = Convert.ToInt32(Console.ReadLine());
			point2 = new Point(x2, y2);
			Console.WriteLine("X = " + point2.X + "\t Y = " + point2.Y);

			Console.Write("Введите Х третьей точки: ");
			x3 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите Y третьей точки: ");
			y3 = Convert.ToInt32(Console.ReadLine());
			point3 = new Point(x3, y3);
			Console.WriteLine("X = " + point3.X + "\t Y = " + point3.Y);

			var distance = Math.Sqrt((point2.X - point1.X) + (point2.Y - point1.Y));
			var distance2 = Math.Sqrt((point3.X - point2.X) + (point3.Y - point2.Y));
			var distance3 = Math.Sqrt((point1.X - point3.X) + (point1.Y - point3.Y));

			if (distance == distance2 && distance == distance3 && distance2 == distance3)
			{
				Console.WriteLine("\nТреугольник равнобедренный");
			}
			else
			{
				Console.WriteLine("\nТреугольник не равнобедренный");
			}

			Console.ReadLine();
		}
	}
}
