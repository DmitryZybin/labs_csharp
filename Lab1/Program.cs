using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void PrintOsInfoAndDate() {
            OperatingSystem os = System.Environment.OSVersion;
            System.Console.WriteLine("Платформа: {0}",os.Platform);
            System.Console.WriteLine("Версия ОС: {0}", os.VersionString);
            System.Console.WriteLine("Текущие дата и время: {0}\n", DateTime.Now);
        }

        static double CalculateEquation(double x) {
            double c = 3.7 * Math.Sqrt(5.0 - x) * Math.Cos(3.5 - x) - Math.Pow(5.0 - x, 3.0 / 5.0);
            return c;
        }

        static void Main(string[] args)
        {
            PrintOsInfoAndDate();
            Console.Write("Введите x = ");
            double x = Convert.ToDouble(System.Console.ReadLine());
            double c = CalculateEquation(x);
            Console.WriteLine("c = {0:#0.000}", c);

            Console.Write("Введите x = ");
            x = Convert.ToDouble(Console.ReadLine());
            c = CalculateEquation(x);
            Console.WriteLine("c = {0:#0.000}", c);
            Console.ReadLine();
        }
    }
}
