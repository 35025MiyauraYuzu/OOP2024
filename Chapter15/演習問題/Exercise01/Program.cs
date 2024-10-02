using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var max = Library.Books.Max(b => b.Price);
            var book = Library.Books.First(b => b.Price == max);
            Console.WriteLine(book);
        }

        private static void Exercise1_3() {
            var query = Library.Books
                .GroupBy(b => b.PublishedYear)
                .Select(g => new { PublishedYear = g.Key, Count = g.Count() })
                .OrderBy(g => g.PublishedYear);

            foreach (var item in query) {
                Console.WriteLine("{0}年 {1}冊", item.PublishedYear, item.Count);
            }
        }

        private static void Exercise1_4() {
            var query = Library.Books
                .Join(Library.Categories,   //結合する２番目のシーケンス
                        book => book.CategoryId,//対象シーケンスの結合キー
                        category => category.Id,//２番目のシーケンスの結合キー
                        (book, category) => new {//オブジェクト生成関数
                            book.Title,
                            book.PublishedYear,
                            book.Price,
                            CategoryName = category.Name,
                        })
                        .OrderByDescending(x => x.PublishedYear)
                        .ThenByDescending(x => x.Price);

            foreach (var item in query)
                Console.WriteLine("{0}年 {1}円 {2} ({3})",
                              item.PublishedYear,
                              item.Price,
                              item.Title,
                              item.CategoryName
                             );

        }

        private static void Exercise1_5() {
            var puery = Library.Books
                .Where(b => b.PublishedYear == 2016)
                .Join(Library.Categories, //結合する2番目のシーケンス
                book => book.CategoryId,  //対象シーケンスの結合キー
                category => category.Id,  //２番目のシーケンスの
                (book, category) => category.Name)
                .Distinct();

            foreach (var item in puery) {
                Console.WriteLine(item);
            }

        }

        private static void Exercise1_6() {
            var query = Library.Books
                .Join(Library.Categories, //結合する2番目のシーケンス
                      book => book.CategoryId,  //対象シーケンスの結合キー
                      category => category.Id,  //２番目のシーケンスの統合キー
                      (book, category) => new {
                          book.Title,
                          CategoryName = category.Name,
                      })
                .GroupBy(x => x.CategoryName)
                .OrderBy(x => x.Key);

            foreach (var item in query) {
                Console.WriteLine("#{0}", item.Key);
                foreach (var grouup in item) {
                    Console.WriteLine("  {0}", grouup.Title);
                }
            }
        }

        private static void Exercise1_7() {
            var categoryid = Library.Categories
              .Single(c => c.Name == "Development")
              .Id;

            var query = Library.Books.Where(b => b.CategoryId == categoryid)
                                     .GroupBy(b => b.PublishedYear)
                                     .OrderBy(b => b.Key);


            foreach (var item in query) {
                Console.WriteLine("#{0}年", item.Key);
                foreach (var grouup in item) {
                    Console.WriteLine("  {0}", grouup.Title);
                }
            }


        }

        private static void Exercise1_8() {

        }
    }
}
