using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //Дано случайно число, вы должны вернуть цифры этого числа в массиве в обратном порядке.

            int[] reversList = new int[] { 7, 9, 5, 8, 4, 3 };
            Console.WriteLine("до");
            foreach (var item in reversList)
            {
                Console.Write(item + " ");
            }

            //реверс с помощью linq
            var reverse = (from rev in reversList select rev).Reverse();

            Console.WriteLine("\nпосле");
            foreach (var item in reverse)
            {
                Console.Write(item + " ");
            }



            //количество положительных чисел и сумма отрицательных чисел.
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };

            if (arr == null || arr.Length == 0)
            {
                return;
            }
            else
            {
                //количество положительных чисел
            var countNum = arr.Where(p => p > 0).Count();
            Console.WriteLine("\n\n" + "количество положительных чисел\n" + countNum);


            //сумма отрицательных чисел
            var sumNum = arr.Where(p => p < 0).Sum();
            Console.WriteLine("сумма отрицательных чисел\n" + sumNum);
            }





            //вернуть отсортированный массив от самой короткой до самой длинной строки.
            string[] stringArr = new string[] { "Telescopes", "Glasses", "Eyes", "Monocles" };

            Console.WriteLine("\n\nдо");
            foreach (var item in stringArr)
            {
                Console.Write(item + " ");
            }

            //отсортировывает по возрастанию
            var order = stringArr.OrderBy(p => p.Length);

            Console.WriteLine("\nпосле");
            foreach (var item in order)
            {
                Console.Write(item + " ");
            }


            //Верните уникальное число.
            int[] uniq = new int[] { 1, 1, 1, 2, 1, 1 };

            var findUniq = uniq.GroupBy(p => p).Where(p => p.Count() == 1).Select(p => p.Key);

            Console.WriteLine("\n\n" + "уникальное(ые) число(а)");
            foreach (var item in findUniq)
            {
                Console.WriteLine(item);
            }
        }
    }
}
