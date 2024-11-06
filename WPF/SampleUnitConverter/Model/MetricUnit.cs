using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUnitConverter {
    //メートル単位を表すクラス
    public class MetricUnit :DistanceUinit{
        private static List<MetricUnit> units = new List<MetricUnit> {
            new MetricUnit {Name ="mm", Conefficient = 1,},
            new MetricUnit {Name ="cm", Conefficient =10,},
            new MetricUnit {Name ="m", Conefficient =10* 100,},
            new MetricUnit {Name ="km", Conefficient =10*100*1000},
        };

        public static ICollection<MetricUnit> Units { get { return units; } }

        /// <summary>
        ///     ヤード単位からメートル単位に変換
        /// </summary>
        /// <param name="unit">ヤード単位</param>
        /// <param name="value">値</param>
        /// <returns></returns>
        public double FromImperialUnit(ImperialUnit unit,double value) {
            return(value * unit.Conefficient)*25.4/this.Conefficient;

        }

    }
}
