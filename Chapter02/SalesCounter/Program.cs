using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCounter {
    internal class Program {
        static void Main(string[] args) {
            List<Sales> sales = RedSales(@"C:\Users\infosys\source\repos\OOP2024\Chapter02\SalesCounter\bin\Debug\data\Sales.csv");

            foreach (Sales sale in sales) {
                // Console.WriteLine(sale.ShopName + "" + sale.ProductCategory + "" + sale.Amount);


                Console.WriteLine("店名：{0}　カテゴリー:{1} 売上{2}", sale.ShopName, sale.ProductCategory, sale.Amount);
            }

        }

        //売上データを読み込み、saleオブジェクトのリストを返す
        static List<Sales> RedSales(string filpath) {
            List<Sales> sales = new List<Sales>();
            string[] lines = File.ReadAllLines(filpath);
            foreach (string line in lines) {
                string[] items = line.Split(',');
                Sales sale = new Sales {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2]),
                };
                sales.Add(sale);
            }
            return sales;
        }





    }
}
