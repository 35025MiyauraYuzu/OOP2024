using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    public static class InchConveter {
        // private const double ratio = 0.0254;
        public static readonly double ratio = 0.0254;

        //メートルからインチを求める
        public static double MeterToInch(double meter) {
            return meter / ratio;
        }
        //インチからメートルを求める
        public static double InchToMeter(double inch) {
            return inch * ratio;
        }
    }
}