﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            var names = new List<string> {
                 "Tokyo", "New Delhi", "Bangkok", "London",
                "Paris", "Berlin", "Canberra", "Hong Kong",
            };
            Console.WriteLine("***3.2.1***");
            Exercise2_1(names);
            Console.WriteLine();

            Console.WriteLine("***3.2.2***");
            Exercise2_2(names);
            Console.WriteLine();

            Console.WriteLine("***3.2.3***");
            Exercise2_3(names);
            Console.WriteLine();

            Console.WriteLine("***3.2.4***");
            Exercise2_4(names);
        }

        private static void Exercise2_1(List<string> names) {
            Console.WriteLine("都市名を入力。空行で終了");

            do {
                var line = Console.ReadLine();

                if (string.IsNullOrEmpty(line))
                    break;//空行だと抜ける

                Console.WriteLine(names.FindIndex(s => s == line));

            } while (true);

        }

        private static void Exercise2_2(List<string> names) {
           
        }

        private static void Exercise2_3(List<string> names) {
        }

        private static void Exercise2_4(List<string> names) {
        }
    }
}
