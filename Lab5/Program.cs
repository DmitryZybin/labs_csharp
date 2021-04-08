using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static int[] GenerateArray(int array_size) {
            int[] result = new int[array_size];
            Random rnd = new Random();
            for (int i = 0; i < array_size; i++) {
                result[i] = rnd.Next(-255, 255);
            }
            return result;
        }

        static void PrintArray(int[] array) {
            Console.WriteLine("\nСгенерированный массив:");
            for (int i = 0; i < array.Length; i++) {
                Console.WriteLine("индекс = {0} | значение = {1}",i,array[i]);
            }
        }

        static void CalculateValues(int[] array) {
            int first_negative = 0;
            int first_negative_index = -1; // Индексы найденных элементов для контроля
            int last_positive = 0;
            int last_positive_index = -1; // Индексы найденных элементов для контроля
            double avg;

            for (int i = 0; i < array.Length; i++) {
                if ((array[i] < 0) && (first_negative == 0)) {
                    // Нашли первый отрицательный элемент
                    first_negative = array[i];
                    first_negative_index = i;
                }
                if (array[i] > 0) {
                    last_positive = array[i];
                    // После перебора массива в переменной будет последнее положительное значение
                    last_positive_index = i;
                }
            }

            avg = (first_negative + last_positive) / 2;

            Console.WriteLine("Первый отрицательный элемент: array[{0}]={1}", first_negative_index, first_negative);
            Console.WriteLine("Последний положительный элемент: array[{0}]={1}", last_positive_index, last_positive);
            Console.WriteLine("Среднее арифметическое: {0:f5}", avg);
        }

        static void Main(string[] args)
        {
            Console.Write("Определение среднего арифметического значения первого отрицательного и последнего положительного");
            Console.WriteLine("элементов одномерного массива размером M");

            Console.Write("Введите размер массива M: ");
            int array_size = Convert.ToInt32(Console.ReadLine());

            int[] array = GenerateArray(array_size);

            PrintArray(array);
            CalculateValues(array);


            Console.WriteLine("Для выхода нажмите на Enter");
            Console.ReadLine();
        }
    }
}
