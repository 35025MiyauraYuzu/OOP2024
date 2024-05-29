﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Section01 {
    internal class Program {


        static void Main(string[] args) {
            #region null合体演算子
            string code = "12345";
            var mesage = Getmesage(code) ?? DefaultMesaga();
            Console.WriteLine(mesage);

            #endregion
            
            #region  null条件演算子
            /* Sale sale = new Sale {
                 Amount = 1000,

             };*/
            Sale sale = null;
            //int?はnull許容型、[?.]はnull条件演算子0
            int? ret = sale?.Amount;
            Console.WriteLine(ret);
            #endregion

            Console.Write("整数を入力:");
            string jnpuntNum = Console.ReadLine();
            int num;

            if (int.TryParse(jnpuntNum, out num)) {
                Console.WriteLine("整数に変換した値：" + num);
            } else {
                Console.WriteLine("変換に失敗しました。");
            }




        }

        private static object Getmesage(string code) {
            return null;
        }
        private static object DefaultMesaga() {
            return "DefaultMesaga";
        }
    }
    //売上クラス
    public class Sale {
        //店舗名
        public string ShopName { get; set; }
        //商品カテゴリ
        public string ProductCategory { get; set; }
        //売上高
        public int Amount { get; set; }

    }
}
