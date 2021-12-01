using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Упражнение_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Введите длины сторон первого треугольника");
			double x = Convert.ToDouble(Console.ReadLine());
			double y = Convert.ToDouble(Console.ReadLine());
			double z = Convert.ToDouble(Console.ReadLine());
			double S1 = MetodArea(x, y, z);
			Console.WriteLine("Площадь треугольника равна {0}", S1);

			Console.WriteLine("Введите длины сторон второго треугольника");
			x = Convert.ToDouble(Console.ReadLine());
			y = Convert.ToDouble(Console.ReadLine());
			z = Convert.ToDouble(Console.ReadLine());
			double S2 = MetodArea(x, y, z);
			Console.WriteLine("Площадь треугольника равна {0}", S2);

			if (S1 > S2)
				Console.WriteLine("Площадь первого треугольника больше. {0:f2} > {1:f2}", S1, S2);
			if (S2 > S1)
				Console.WriteLine("Площадь второго треугольника больше. {1:f2} > {0:f2}", S1, S2);
			if (S1 == S2)
				Console.WriteLine("Площади треугольников равны. {0:f2} = {1:f2}", S1, S2);

			Console.WriteLine();
			Console.Write("Для завершения нажмите любую клавишу на клавиатуре");
			Console.ReadKey();
		}
		static double MetodArea(double x, double y, double z)
        {
			double P = x + y + z;
			double p = P / 2;
			double S = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
			return S;
					
		}
    }
}
