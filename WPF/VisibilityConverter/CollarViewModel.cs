using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace VisibilityConverter {
    public class CollarViewModel {
        private static IList<CollarViewModel> colors = new List<CollarViewModel> {
            new CollarViewModel{Name="赤",Color= Colors.Red},
            new CollarViewModel{Name="黄",Color= Colors.Yellow},
            new CollarViewModel{Name="青",Color= Colors.Blue},
        };

        public static IList<CollarViewModel> ColorList { get { return colors; } }

        public string Name { get; set; }
        public Color Color { get; set; }

    }
}
