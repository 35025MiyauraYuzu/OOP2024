using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            //var numbers =Enumerable.Repeat(-1,20).ToList();

            var pages = Books.GetBooks().Max(x => x.Pages);
            var booktitle = Books.GetBooks().OrderByDescending(x => x.Price).ToList();

            foreach (var book in booktitle) {
                Console.WriteLine(book.Title + ":" + book.Price);
            }

          //  booktitle.ForEach(b => Console.WriteLine(b.Title + ":" + b.Price));
        }
    }
}
