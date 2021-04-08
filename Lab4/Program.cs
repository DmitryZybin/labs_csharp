using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {

        static double Factorial(int n) {
            //отдельная функция вычисления факториала
            //возвращает long а не int, так как факториалы растут ооочень быстро
            double result = 1;
            for (int multiplier = 1; multiplier <= n; multiplier++) {
                result *= multiplier;
            }
            return result;
        }

        static void Task1() {
            StreamWriter writer = new StreamWriter("LAB4.res");
            Console.WriteLine("Задание №1: Вычисление значения функции для каждого из заданных значений параметра a");
            Console.WriteLine("для значений аргумента х в определённом диапазоне");
            writer.WriteLine("|-------------------------------|");
            writer.WriteLine("|------РЕЗУЛЬТАТЫ РАСЧЁТА-------|");
            writer.WriteLine("|-------------------------------|");

            for (float a = 0.1f; a <= 0.4f; a += 0.1f) {
                writer.WriteLine("|  Агрумент а = {0:f1}             |", a);
                writer.WriteLine("|-------------------------------|");
                for (float x = 0.0f; x <= 2.0f; x += 0.05f) {
                    double y = 1.0 / Math.Sqrt(Math.Pow(1 - Math.Pow(x, 2), 2) + 4 * Math.Pow(a, 2) * Math.Pow(x, 2));
                    writer.WriteLine("|  x = {0:f2} |   y = {1:f7}   |",x,y);
                }
                writer.WriteLine("|-------------------------------|");
            }
            writer.Close();
            Console.WriteLine("Результаты вычислений сохранены в файл LAB4.res");
        }

        static void Task2() {
            Console.WriteLine("Задание №2: Вычисление суммы ряда s(x) и значения контрольной функции");
            
            for (double x = Math.PI / 6.0; x <= 25.0 * Math.PI / 6; x += 12.0 * Math.PI / 6) {
                // Перебираем аргумент x в диапазоне pi/6, 13pi/6, 25pi/6
                Console.WriteLine("    Вычисляем значение функции y = sin(x) * sin(x), при х = {0:f6}рад", x);
                Console.WriteLine("       ПРОМЕЖУТОЧНЫЕ РЕЗУЛЬТАТЫ:");

                int n = 1; // Начальное значение ряда
                double S = 0; // Сумма ряда
                double Sn = 0; // n-й член ряда

                do
                {
                    Console.WriteLine("         ИТЕРАЦИЯ №{0}", n);
                    double chisl = Math.Pow(-1, n - 1) * (Math.Pow(2, 2 * n - 1)) * Math.Pow(x, 2 * n);
                    double znam = Factorial(2 * n);
                    Sn =  (chisl / znam);
                    S += Sn;
                    // Выводим сумму ряда и n-й член ряда 
                    Console.WriteLine(" S={0:f9}, Sn={1:f9}", S, Sn);
                    n++;
                } while (Math.Abs(Sn) >= 1.0e-6);
                double y_func = Math.Pow(Math.Sin(x), 2);
                Console.WriteLine("         РЕЗУЛЬТАТЫ:");
                Console.WriteLine("Значение переметра х: {0:f9}", x);
                Console.WriteLine("Вычисленная сумма ряда S: {0:f9}", S);
                Console.WriteLine("Количество членов ряда - {0}", n);
                Console.WriteLine("Функция sin(x) * sin(x) = {0:f9}\n", y_func);
            }

        }

        static void Main(string[] args)
        {
            Console.Write("Введите номер задания (1 или 2): ");
            int ex_number = Convert.ToInt32(Console.ReadLine());
            if (ex_number == 1)
            {
                Task1();
            }
            if (ex_number == 2)
            {
                Task2();
            }

            Console.WriteLine("Для выхода нажмите на Enter");
            Console.ReadLine();
        }
    }
}
