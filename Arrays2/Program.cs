using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2
{
    class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            double[] arr = new double[10];
            for(int i = 0; i<arr.Length;i++)
            {
                arr[i] = rnd.Next(-10, 10) + Math.Round(rnd.NextDouble(),2);
                Console.WriteLine($"[{i}] = {arr[i]}");
            }
               
                MultRightMinArray(arr);
                SumBetweenMinusAndSecondPlusArray(arr);
                SumBetweenZeroArray(arr);
                MultBetweeenMudulemaxandMonulemin(arr);
            

        }
        static void MultRightMinArray(double[] array)
        {
            double min = array[0], result = 1;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    count = i;
                }
            }
            for (int i = count + 1; i < array.Length; i++)
            {
                result *= array[i];
            }
            Console.WriteLine($"Добуток елементiв масиву, що розташованi пiсля мiнiмального елемента = {result}");
        }
        static void SumBetweenMinusAndSecondPlusArray(double[] array)
        {
            double result = 0;
            int minus = 0, firstplus = 0, secondplus = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    minus = i;
                    break;
                }
            }
            for (int i = minus; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    firstplus = i;
                    break;
                }
            }
            for (int i = firstplus + 1; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    secondplus = i;
                    break;
                }
            }
            for (int i = minus + 1; i < secondplus; i++)
            {
                result += array[i];
            }
            Console.WriteLine($"Cумa елементiв масиву, що розташованi мiж першим вiд'ємним та другим додатним елементами = {result}");
        }
        static void SumBetweenZeroArray(double[] array)
        {
            int fzero = 0;
            for (int i = 0; i < array.Length;i++)
            {
                if (array[i] == 0)
                {
                    fzero = i;
                    break;
                }
            }
            int lastzero = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] == 0)
                {
                    lastzero = i;
                    break;
                }
            }
            double result = 0;
            for (int i = fzero; i <= lastzero; i++)
            {
                result += array[i];
            }
            Console.WriteLine($"Cумa елементiв масиву, якi розташованi мiж першим i останнiм нульовими елементами = {result}");
        }
        static void MultBetweeenMudulemaxandMonulemin(double[] array)
        {
            double mmax = array[0], mmin = array[0], result = 1;
            int indexmin = 0, indexmax = 0;
            for (var i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) > Math.Abs(mmax))
                {
                    indexmax = i;
                }
            }
            for (var i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) < Math.Abs(mmin))
                {
                    indexmin = i;
                }
            }
            if (indexmax < indexmin)
            {
                for (var i = indexmax + 1; i < indexmin; i++)
                {
                    result *= array[i];
                }
            }
            else if (indexmax > indexmin)
            {
                for (var i = indexmax - 1; i > indexmin; i--)
                {
                    result *= array[i];
                }
            }
            else
            {
                result = array[indexmax];
            }
            Console.WriteLine($"Добуток елементiв масиву, що розташованi мiж максимальним за модулем i мiнiмальним за модулем елементами = {result}");
        }
    }
}
