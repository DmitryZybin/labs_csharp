using System;
using System.IO;

namespace Lab2
{
    class Program
    {

        static void Exercise1() {
            Console.WriteLine("\nЗадание №1, консольный ввод переменных A, I, C, L, Name и их форматированный вывод");
            float a;
            int i;
            double c;
            bool l;
            string name;

            Console.Write("Введите a: ");
            a = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите i: ");
            i = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите с: ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите l: ");
            l = Convert.ToBoolean(Console.ReadLine());
            Console.Write("Введите отчество: ");
            name = Console.ReadLine();

            Console.WriteLine("\nРезультаты форматирования:\na = {0,8:e2}, i = {1,4}, c = {2,5:f3}", a, i, c);
            Console.WriteLine("Name: {0, 10}, l: {1, 5}\n", name, l);
        }

        static void Exercise2() {
            Console.WriteLine("Задание №2, вычисление и печать значений функции из файла и в файл");
            StreamReader reader = new StreamReader("lab2.txt");
            StreamWriter writer = new StreamWriter("lab2.res");

            writer.WriteLine("+-------------------------------------+");
            writer.WriteLine("+   Аргумент       +    Функция       +");
            writer.WriteLine("+-------------------------------------+");

            string line = reader.ReadLine();
            while (line != null) {
                double x = Convert.ToDouble(line);
                double y = 2.0f * Math.PI / (Math.Pow(x, 2) - Math.PI);
                writer.WriteLine("+  X={0,6:f3}        +  Y={1,6:f3}        +", x, y);
                line = reader.ReadLine();
            }
            writer.WriteLine("+-------------------------------------+");
            writer.WriteLine("Составила: Зыбина Анастасия Станиславовна");
            reader.Close();
            writer.Close();

        }

        static void Main(string[] args)
        {
            Console.Write("Введите номер задания (1 или 2): ");
            int ex_number = Convert.ToInt32(Console.ReadLine());
            if (ex_number == 1) {
                Exercise1();
            }
            if (ex_number == 2) {
                Exercise2();
            }

            Console.WriteLine("Для выхода нажмите на Enter");
            Console.ReadLine();
        }
    }
}
