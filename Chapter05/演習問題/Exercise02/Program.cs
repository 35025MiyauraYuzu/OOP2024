using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            var math =Console.ReadLine();
            int.TryParse(math, out var n);
            Console.WriteLine(n.ToString("#,0"));

            if(int.TryParse(math, out n)) {
                Console.WriteLine("{0:#,#}", n);
            } else {
                Console.WriteLine("数字文字列がありません。");
            }
        }
    }
}
