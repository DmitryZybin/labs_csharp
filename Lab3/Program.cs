using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {

        static void CalculateFunction() {
            Console.WriteLine("\nЗадание №1: вычисление значения функции F");
            Console.Write("Введите X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите Y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите Z: ");
            double z = Convert.ToDouble(Console.ReadLine());

            double max;
            double min;

            if (x > y){
                max = x;
            }else {
                max = y;
            }

            if (x < y) {
                if (x < z){
                    min = x;
                }else {
                    min = z;
                }
            }
            else {
                if (y < z) {
                    min = y;
                }
                else {
                    min = z;
                }
            }

            double numerator = max + y; // Числитель
            double denominator = Math.Pow(min, 2.0) + y*x;

            if (denominator == 0){
                Console.Error.WriteLine("Ошибка, знаменатель равен нулю");
            } else {
                double F = numerator / denominator;
                Console.WriteLine("Дано: X={0:F3}, Y={1:F3}, Z={2:F3}",x,y,z);
                Console.WriteLine("Результат: F={0:F3}",F);
            }

        }

        static void DefineRegion() {
            Console.WriteLine("\nЗадание №2: нахождение номера области");
            Console.Write("Введите для точки M координату по X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите для точки M координату по Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            double y_func = Math.Pow(x, 2);
            int N;

            if ((y == 0) && (x == 0)) {
                // Частный случай - точка на пересечении всех границ, берем максимальный N по условию
                N = 4;
            } else {
                if (y > y_func) {
                    // Точка лежиит строго выше параболы
                    if (x < 0){
                        N = 1;
                    } else {
                        N = 2;
                    }
                } else {
                    // Точка на параболе или ниже
                    if (y > 0) {
                        if (x > 0) {
                            N = 3;
                        }else{
                            N = 4;
                        }
                    }else{
                        if (x >= 0) {
                            N = 4;
                        }else{
                            if (y == 0) {
                                N = 4;
                            }else{
                                N = 3;
                            }
                        }
                    }
                }
            }

            // Выводим результаты
            Console.WriteLine("\t\tРЕЗУЛЬТАТ:");
            Console.WriteLine("Точка М({0:F2},{1:F2}) лежит в области N={2}",x,y,N);
        }

        static void Main(string[] args)
        {
            Console.Write("Введите номер задания (1 или 2): ");
            int ex_number = Convert.ToInt32(Console.ReadLine());
            if (ex_number == 1)
            {
                CalculateFunction();
            }
            if (ex_number == 2)
            {
                bool try_again = true;
                while (try_again)
                {
                    DefineRegion();
                    Console.Write("Ввести ещё одну точку (Y/n)? ");
                    string inp = Console.ReadLine();
                    if (inp.ToLower() == "y") {
                        try_again = true;
                    }else{
                        try_again = false;
                    }
                }

            }

            Console.WriteLine("Для выхода нажмите на Enter");
            Console.ReadLine();

        }
    }
}
