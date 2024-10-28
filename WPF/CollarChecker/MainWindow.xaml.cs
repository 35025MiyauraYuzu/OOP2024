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
            colorSelectComboBox.DataContext = getColorList();//カラーリストをコンボボックスにセット
        }

        //スライダーの値を入手してcoloAreaの背景変更
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

        //ストックボタン
        private void stockButton_Click(object sender, RoutedEventArgs e) {
            ////重複しているか確認
            //bool exists = stockList.Items.Cast<MyColor>().Any(item => item.Color == currentColor.Color);

            ////重複していなければstockListに追加
            //if (!exists) {
            //    stockList.Items.Insert(0, currentColor);
            //}


            //正解バージョン
            if (stockList.Items.Contains((MyColor)currentColor)) {
                MessageBox.Show("登録済みです");
            } else {

                stockList.Items.Insert(0, currentColor);
            }

        }

        //リストを選択
        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {

            coloArea.Background = new SolidColorBrush(((MyColor)stockList.Items[stockList.SelectedIndex]).Color);

            setSilderValue(((MyColor)stockList.Items[stockList.SelectedIndex]).Color);
        }

        //各スライダーの値設定
        private void setSilderValue(Color color) {
            rSilder.Value = color.R;
            gSilder.Value = color.G;
            bSilder.Value = color.B;
        }

        //色取得リスト
        private MyColor[] getColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        //コンボボックスのCollar取得  
        private void colorSelectComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            currentColor = (MyColor)((ComboBox)sender).SelectedItem;

            coloArea.Background = new SolidColorBrush(currentColor.Color);

            setSilderValue(currentColor.Color);

        }
    }
}

