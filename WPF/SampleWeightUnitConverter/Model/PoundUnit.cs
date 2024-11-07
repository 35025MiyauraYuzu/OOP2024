using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWeightUnitConverter {
    public class PoundUnit:WeightUnit {
        private static List<PoundUnit> units = new List<PoundUnit> {
              new PoundUnit {Name ="oz", Conefficient = 1,},
              new PoundUnit {Name ="lb", Conefficient = 16,},
        };


        public static ICollection<PoundUnit> Units { get { return units; } }


        /// <summary>
        /// グラムからオンスに変換
        /// </summary>
        /// <param name="unit"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public double FromGramUnit(Gramunit unit, double value) {
            return (value * unit.Conefficient) / 28.35 / this.Conefficient;

        }

    }





}
