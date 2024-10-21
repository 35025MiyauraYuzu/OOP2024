using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CollarChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Silder_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            var rvalue = (int)rSilder.Value;
            var gvalue = (int)gSilder.Value;
            var bvalue = (int)bSilder.Value;

            //rVAlue.Text = rvalue;
            //gVAlue =
            //bVAlue =

            coloArea.Background = new SolidColorBrush(Color.FromRgb((byte)rvalue,
                                                                    (byte)gvalue,
                                                                    (byte)bvalue));

        }
    }
}
