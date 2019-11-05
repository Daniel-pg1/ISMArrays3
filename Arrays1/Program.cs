using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            double[] arr = new double[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-10, 10) + Math.Round(rnd.NextDouble(), 2);
                Console.WriteLine($"[{i}] = {arr[i]}");
            }
            negative_sum(arr);
                MaxArrayNum(arr);
                MaxArrayIndex(arr);
                ModuleMaxArray(arr);
                IndexSumArray(arr);
                NumberintArray(arr);
            
            

        }
         static void negative_sum(double[] array)
        {
            double sum = 0;
            if (array.Length == 0)
            {
                Console.WriteLine("Пустой массив!");
                sum = 0;
                return;
            }
            else
            {
                foreach (var i in array)
                {
                    if (i < 0)
                    {
                        sum += i;
                    }
                }
                Console.WriteLine($"Сума вiд'ємних значень = {sum}");
            }
        }
        static void MaxArrayNum(double[] array)
        {
            double max = array[0];
            foreach (var i in array)
            {
                if (i > max)
                {
                    max = i;
                }

            }
            Console.WriteLine($"Mаксимальний елемент масиву = {max}");
        }
        static void MaxArrayIndex(double[] array)
        {
            int maxIndex = 0;
            double max = array[0];
            for (var i = 0; i < array.Length; i++) 
            {
                if (max < array[i])
                {
                    max = array[i];
                    maxIndex = i;
                }
                
            }
            Console.WriteLine($"Iндекс максимального елемента масиву = {maxIndex}");

        }
        static void ModuleMaxArray(double[] array)
        {
            double mmax = array[0];
            for (var i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) > Math.Abs(mmax))
                {

                    mmax = array[i];
                }

            }
            Console.WriteLine($"Максимальний за модулем елемент масиву = {mmax}");

        }
        static void IndexSumArray(double[] array)
        {
            int indexSum = 0;
            for (int i = 0; i < array.Length; i++) 
            {
                if(array[i]>0)
                {
                    indexSum += i;
                }
            }
            Console.WriteLine($"Cумa iндексiв додатних елементiв = {indexSum}");

        }
        static void NumberintArray(double[] array)
        {
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 1 == 0)
                {
                    j++;
                }
            }
            Console.WriteLine($"Kiлькiсть цiлих чисел у масивi = {j}");

        }
    }
}
