using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWeightUnitConverter {
    //グラム単位を表すクラス
    public class Gramunit : WeightUnit {
        private static List<Gramunit> units = new List<Gramunit> {
             new Gramunit {Name ="g", Conefficient = 1,},
             new Gramunit {Name ="kg", Conefficient = 1000,},
        };

        public static ICollection<Gramunit> Units { get { return units; } }

        /// <summary>
        /// オンスからグラムに変換
        /// </summary>
        /// <param name="unit"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public double FromoPoundUnit(PoundUnit unit, double value) {
            return (value * unit.Conefficient) / 28.35 / this.Conefficient;

        }


    }


}
