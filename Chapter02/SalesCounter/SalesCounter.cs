using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCounter {
    public class SalesCounter {
        private List<Sales> _sales;

        //コンストラクター
        public SalesCounter(List<Sales> sales) {
            _sales = sales;

        }

        //店舗別の売り上げを求める
        public Dictionary<string, int> GetPerStoreSales() {

            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (Sales sales in _sales) {
                if (dict.ContainsKey(sales.ShopName))
                    dict[sales.ShopName] += sales.Amount;
                else
                    dict[sales.ShopName] = sales.Amount;
            }
            return dict;
        }
    }
}
