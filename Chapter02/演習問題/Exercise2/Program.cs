using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    internal class Program {
        static void Main(string[] args) {

            if (args.Length >= 1 && args[0] == "-tom") {
                //インチからメートルへの対応表を出力
                PrintInchToMeterList(int.Parse(args[1]), int.Parse(args[2]));
            } else {
                //メートルからインチへの対応表を出力
                PrintMeterToInchList(int.Parse(args[1]), int.Parse(args[2]));
            }
        }

        private static void PrintMeterToInchList(int start, int stop) {
            for (int meter = start; meter <= stop; meter++) {
                double feet = InchConveter.MeterToInch(meter);
                Console.WriteLine("{0}m ={1:0.0000}in", meter, feet);
            }
        }

        private static void PrintInchToMeterList(int start, int stop) {
            for (int feet = start; feet <= stop; feet++) {
                double meter = InchConveter.InchToMeter(feet);
                Console.WriteLine("{0} in = {1:0.0000}m", feet, meter);
            }
        }
    }
}