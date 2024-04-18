using SampleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {
    internal class Program {
        static void Main(string[] args) {

            SampleApp.Product karinto = new SampleApp.Product(123, "かりんとう", 180);
            SampleApp.Product daihuku = new Product(124, "大福", 230);
            Product dorayaki = new Product(98, "どら焼き", 210);
            

            int price = karinto.Price; //税抜きの金額
            int taxIncluded = karinto.GetPriceIncludingTax();//税込みの金額

            Console.WriteLine(karinto.Name+"の税込み金額は" + taxIncluded + "円【税抜き" + price + "円】");


           

             price = karinto.Price; //税抜きの金額
             taxIncluded = karinto.GetPriceIncludingTax();//税込みの金額
            Console.WriteLine(daihuku.Name + "の税込み金額は" + taxIncluded + "円【税抜き" + price + "円】");



            int pric = dorayaki.Price; //税抜きの金額
            int taxInclude = dorayaki.GetPriceIncludingTax();//税込みの金額
            price = dorayaki.Price; //税抜きの金額
            taxIncluded = dorayaki.GetPriceIncludingTax();//税込みの金額
            Console.WriteLine(dorayaki.Name + "の税込み金額は" + taxIncluded + "円【税抜き" + price + "円】");


        }
    }
}
