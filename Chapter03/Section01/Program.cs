using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };

            int count = numbers.Count(n => n % 2 == 0);

            int total = numbers.Where(n => 5 < n).Sum();
            double num = numbers.Where(n => 5 < n).Average();

            int nums = numbers.Count(n => n > 5);



            Console.WriteLine(num);
            Console.WriteLine(total);
            Console.WriteLine(nums);




        }

        /* public static int Count(int[] numbers, Predicate<int> judge) {
             int count = 0;
             foreach (var n in numbers) {
                 if (judge(n) == true)
                     count++;
             }
             return count;
         }
        */
    }
}
