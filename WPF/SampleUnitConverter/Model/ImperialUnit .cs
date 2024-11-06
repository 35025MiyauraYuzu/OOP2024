using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUnitConverter {
    //ヤード単位を表すクラス
    public class ImperialUnit :DistanceUinit{
        private static List<ImperialUnit> units = new List<ImperialUnit> {
            new ImperialUnit {Name ="in", Conefficient = 1,},
            new ImperialUnit {Name ="ft", Conefficient =12,},
            new ImperialUnit {Name ="yd", Conefficient =12* 3,},
            new ImperialUnit {Name ="ml", Conefficient =12*3*1760},
        };

        public static ICollection<ImperialUnit> Units { get { return units; } }

        /// <summary>
        ///     メートル単位からヤード単位に変換
        /// </summary>
        /// <param name="unit">メートル単位</param>
        /// <param name="value">値</param>
        /// <returns></returns>
        public double FromMetricunit(MetricUnit unit,double value) {
            return(value * unit.Conefficient)/25.4/this.Conefficient;

        }

    }
}
