using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCounter {
    public class SalesCounter {
        private IEnumerable<Sales> _sales;

        //コンストラクター
        public SalesCounter(string filpath) {
            _sales = RedSales(filpath);

        }

        //売上データを読み込み、saleオブジェクトのリストを返す
        private static IEnumerable<Sales> RedSales(string filpath) {
            List<Sales> sales = new List<Sales>();
            string[] lines = File.ReadAllLines(filpath);
            foreach (var line in lines) {
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

        //店舗別の売り上げを求める
        public IDictionary<string, int> GetPerStoreSales() {
            var dict = new Dictionary<string, int>();
            foreach (var sales in _sales) {
                if (dict.ContainsKey(sales.ShopName))
                    dict[sales.ShopName] += sales.Amount;
                else
                    dict[sales.ShopName] = sales.Amount;
            }
            return dict;
        }

    }
}
