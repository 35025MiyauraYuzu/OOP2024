using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Book {
        public string Title { get; set; }
        public int Price { get; set; }
        public int Pages { get; set; }
    }
    internal class Program {
        static void Main(string[] args) {
            var books = new List<Book> {
   new Book { Title = "C#プログラミングの新常識", Price = 3800, Pages = 378 },
   new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
   new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
   new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
   new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
   new Book { Title = "私でも分かったASP.NET MVC", Price = 3200, Pages = 453 },
   new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },
};

            Exercise2_1(books);
            Console.WriteLine("-----");

            Exercise2_2(books);

            Console.WriteLine("-----");

            Exercise2_3(books);
            Console.WriteLine("-----");

            Exercise2_4(books);
            Console.WriteLine("-----");

            Exercise2_5(books);
            Console.WriteLine("-----");

            Exercise2_6(books);

            Console.WriteLine("-----");

            Exercise2_7(books);
        }

        private static void Exercise2_1(List<Book> books) {
            var book = books.Where(s => s.Title == "ワンダフル・C#ライフ");
            foreach (var item in book) {
                Console.WriteLine("{0}円{1}ページ", item.Price, item.Pages);
            }
        }

        private static void Exercise2_2(List<Book> books) {
            var count = books.Count(s => s.Title.Contains("C#"));
            Console.WriteLine("C#が含まれている書籍の数" + count);
        }

        private static void Exercise2_3(List<Book> books) {
            var averaeg = books.Where(b => b.Title.Contains("C#")).Average(b => b.Pages);
            Console.WriteLine(averaeg);

        }

        private static void Exercise2_4(List<Book> books) {
            var pri = books.FirstOrDefault(n => n.Price >= 4000);
            if (pri != null) {
                Console.WriteLine(pri.Title);
            }

        }

        private static void Exercise2_5(List<Book> books) {
            var page = books.Where(b => b.Price < 4000).Max(b => b.Pages);
            Console.WriteLine(page);
        }

        private static void Exercise2_6(List<Book> books) {
            var page = books.Where(b => b.Pages >= 400).OrderByDescending(x => x.Price).ToArray();
            foreach (var item in page) {
                Console.WriteLine("{0}{1}円", item.Title, item.Price);
            }
        }

        private static void Exercise2_7(List<Book> books) {
            var ti = books.Where(s => s.Pages <= 500 && s.Title.Contains("C#")).ToArray();
            foreach (var item in ti) {
                Console.WriteLine(item.Title);
            }

        }
    }
}
