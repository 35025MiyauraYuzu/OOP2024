﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUnitConverter {
    public class DistanceUinit {
        public string Name { get; set; } //単位の名称
        public double Conefficient { get; set; } // 係数
        public override string ToString() { 
            return this.Name;
        }
    }
}