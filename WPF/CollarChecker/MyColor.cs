﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace CollarChecker {
    public class MyColor {
        public Color Color { get; set; }
        public string Name { get; set; } =string.Empty;
        public override string ToString() {
            return Name  ;
        }

    }
}
