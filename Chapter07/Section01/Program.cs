using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {

        static private Dictionary<string, string> prefOfficeDict = new Dictionary<string, string>();

        static void Main(string[] args) {
            String pref, prefCaptalLocation;
            Console.WriteLine("県庁所在地の登録");

            while (true) {

                Console.Write("都道府県:");
                pref = Console.ReadLine();
                if (pref == null) {
                    break;
                }

                Console.Write("県庁所在地:");
                prefCaptalLocation = Console.ReadLine();
                if (prefOfficeDict.ContainsKey(pref)) {
                    Console.WriteLine("上書きしますか？(Y/N)");
                    if (Console.ReadLine() == "N") {
                        continue;
                    }
                }
                prefOfficeDict[pref] = prefCaptalLocation;
            }
            Console.WriteLine();

            Boolean endFlag = false;
            while (!endFlag) {
                switch (NewMethod()) {
                    case "1":
                        //一覧出力処理
                        alldisp();
                        break;

                    case "2":
                        //都道府県の入力
                        NewMethod2();
                        break;

                    case "9":
                        endFlag = true; //終了フラグＯＮ
                        break;
                }
            }
        }

        private static void NewMethod2() {
            Console.Write("都道府県:");
            String searchPref = Console.ReadLine();
            Console.WriteLine(searchPref + "の県庁所在地は" + prefOfficeDict[searchPref] + "です");
        }

        private static void alldisp() {
            foreach (var item in prefOfficeDict) {
                Console.WriteLine("{0}の県庁所在地は{1}です。", item.Key, item.Value);
            }
        }

        private static string NewMethod() {
            Console.WriteLine("**** メニュー ****");
            Console.WriteLine("1：一覧表示");
            Console.WriteLine("2：検索");
            Console.WriteLine("9：終了");
            Console.Write(">");
            String menuSelect = Console.ReadLine();
            return menuSelect;
        }
    }
}
