using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Converters;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CollarChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {

        MyColor currentColor; //現在設定している色情報

        public MainWindow() {
            InitializeComponent();
            //αチャンネルの初期値を設定(起動時すぐにストックボタンが押された時の対応)
            currentColor.Color = Color.FromArgb(255, 0, 0, 0);
            colorSelectComboBox.DataContext = getColorList();
        }

        private void Silder_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            //値を入手

            // currentColor = new MyColor {
            //      Color = Color.FromRgb((byte)rSilder.Value, (byte)gSilder.Value, (byte)bSilder.Value),
            //     Name = "",
            //  };

            currentColor.Color = Color.FromRgb((byte)rSilder.Value, (byte)gSilder.Value, (byte)bSilder.Value);

            //テキストに表示
            //  rVAlue.Text = rvalue.ToString();
            // gVAlue.Text = gvalue.ToString();
            //  bVAlue.Text = bvalue.ToString();

            //coloAreaの背景を変更
            coloArea.Background = new SolidColorBrush(currentColor.Color);
        }

        private void stockButton_Click(object sender, RoutedEventArgs e) {

            if (stockList.Items.Contains(currentColor) == true) {

            }
            stockList.Items.Insert(0, currentColor);
        }

        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {

            coloArea.Background = new SolidColorBrush(((MyColor)stockList.Items[stockList.SelectedIndex]).Color);
            rSilder.Value = ((MyColor)stockList.Items[stockList.SelectedIndex]).Color.R;
            gSilder.Value = ((MyColor)stockList.Items[stockList.SelectedIndex]).Color.G;
            bSilder.Value = ((MyColor)stockList.Items[stockList.SelectedIndex]).Color.B;

        }

        private MyColor[] getColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        private void colorSelectComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var mycolor = (MyColor)((ComboBox)sender).SelectedItem;
            var color = mycolor.Color;
            var name = mycolor.Name;

            coloArea.Background = new SolidColorBrush(mycolor.Color);

           
        }
    }
}

