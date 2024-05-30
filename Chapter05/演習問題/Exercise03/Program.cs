﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Exercise03 {
    internal class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";

            Exercise3_1(text);
            Console.WriteLine("-----");

            Exercise3_2(text);
            Console.WriteLine("-----");

            Exercise3_3(text);
            Console.WriteLine("-----");

            Exercise3_4(text);
            Console.WriteLine("-----");

            Exercise3_5(text);
        }

        private static void Exercise3_1(string text) {

            //     int count = 0;
            //     foreach (var item in text) {
            //         if (item == ' ') {
            //             count++;
            //         }
            //     }
            //    Console.WriteLine(count);
            var count = text.Count(c => c == ' ');
            Console.WriteLine("空白数:{0}", count);
        }

        private static void Exercise3_2(string text) {

            var str = text.Replace("big", "small");
            Console.WriteLine(str);
        }

        private static void Exercise3_3(string text) {

            // foreach (var item in text) {
            //      if (item == ' ') {
            //        count++;
            //     }
            //  }
            //  Console.WriteLine(count);
            int count = text.Split(' ').Length;
            Console.WriteLine("単語数:{0}", count);
        }

        private static void Exercise3_4(string text) {
            var words = text.Split(' ').Where(s => s.Length <= 4);

            foreach (var word in words) {
                Console.WriteLine(word);
            }
        }

        private static void Exercise3_5(string text) {

            var array = text.Split(' ').ToArray();

            var sb = new StringBuilder();
            foreach (var item in array) {
                sb.Append(item);
                sb.Append(' ');

            }
            Console.WriteLine(sb);
        }

    }
}
