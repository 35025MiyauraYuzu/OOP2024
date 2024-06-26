﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            Exercise1_1(numbers);
            Console.WriteLine("-----");

            Exercise1_2(numbers);
            Console.WriteLine("-----");

            Exercise1_3(numbers);
            Console.WriteLine("-----");

            Exercise1_4(numbers);
            Console.WriteLine("-----");

            Exercise1_5(numbers);
        }

        private static void Exercise1_1(int[] numbers) {
            var max = numbers.Max();
            Console.WriteLine(max.ToString());

        }

        private static void Exercise1_2(int[] numbers) {
            var last = numbers.Skip(numbers.Length - 2).ToArray();
            foreach (var item in last) {
                Console.WriteLine(item);
            }
        }

        private static void Exercise1_3(int[] numbers) {
            var str = numbers.Select(x => x.ToString()).ToArray();
            foreach (var item in str) {
                Console.WriteLine(item);
            }
        }

        private static void Exercise1_4(int[] numbers) {
            var num = numbers.OrderBy(x => x).ToArray().Where(x => x > 0).Take(3);
            foreach (var item in num) {
                Console.WriteLine(item);
            }
        }

        private static void Exercise1_5(int[] numbers) {

            var num = numbers.Distinct().ToArray().Count(n => n > 10);
            Console.WriteLine(num);


        }
    }
}
