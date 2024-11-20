using CustomerApp.Objects;
using Microsoft.Win32;
using SQLite;
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

namespace CustomerApp {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        List<Customer> _customers;
        string _image = "";

        public MainWindow() {
            InitializeComponent();
            ReadDatabase();
            Clear();
        }

        //セーブ
        private void SaveButton_Click(object sender, RoutedEventArgs e) {
            var customer = new Customer() {
                Name = NameTextBox.Text,
                Phone = PhoneTextBox.Text,
                Address = AddressTextBox.Text,
                Image = _image,

            };

            using (var connection = new SQLiteConnection(App.databassPass)) {
                connection.CreateTable<Customer>();
                connection.Insert(customer);


            }

            Clear();

            ReadDatabase();//ListView表示

        }

        //クリア
        private void Clear() {
            NameTextBox.Clear();
            PhoneTextBox.Clear();
            AddressTextBox.Clear();
            _image = "";
            SelectImage.Source = null;
        }

        //アップデート
        private void UpdateButton_Click(object sender, RoutedEventArgs e) {
            var item = CustomerListView.SelectedItem as Customer;

            if (item == null) {
                MessageBox.Show("変更する行を選択してください");
                return;
            }

            item.Name = NameTextBox.Text;
            item.Phone = PhoneTextBox.Text;
            item.Address = AddressTextBox.Text;

            using (var connection = new SQLiteConnection(App.databassPass)) {
                connection.CreateTable<Customer>();
                connection.Update(item);
            }
            ReadDatabase();
            Clear();
        }

        //データの読み込み
        private void ReadDatabase() {
            using (var connection = new SQLiteConnection(App.databassPass)) {
                connection.CreateTable<Customer>();
                _customers = connection.Table<Customer>().ToList();

                CustomerListView.ItemsSource = _customers;
            }
        }

        //検索
        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e) {
            var filterList = _customers.Where(x => x.Name.Contains(SearchTextBox.Text)).ToList();
            CustomerListView.ItemsSource = filterList;
        }

        //削除
        private void DeleteButton_Click(object sender, RoutedEventArgs e) {
            var item = CustomerListView.SelectedItem as Customer;
            if (item == null) {
                MessageBox.Show("削除する行を選択してください");
                return;
            }
            using (var connection = new SQLiteConnection(App.databassPass)) {
                connection.CreateTable<Customer>();
                connection.Delete(item);

                ReadDatabase();
                Clear();
            }
        }

        //ビューの選択
        private void CustomerListView_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var item = CustomerListView.SelectedItem as Customer;
            if (item == null) {
                return;
            }
            NameTextBox.Text = item.Name;
            PhoneTextBox.Text = item.Phone;
            AddressTextBox.Text = item.Address;
            //if (_customers[CustomerListView.SelectedIndex] == null) {
            //    return;
            //}
            //NameTextBox.Text = _customers[CustomerListView.SelectedIndex].Name;
            //PhoneTextBox.Text = _customers[CustomerListView.SelectedIndex].Phone;
            //AddressTextBox.Text = _customers[CustomerListView.SelectedIndex].Address;
            //SelectImage.Source = [CustomerListView.SelectedIndex].Image;
            // SelectImage.Source = new BitmapImage(new Uri(_customers[CustomerListView.SelectedIndex].Image));

            if (_customers[CustomerListView.SelectedIndex].Image != null) {
                SelectImage.Source = new BitmapImage(new Uri(_customers[CustomerListView.SelectedIndex].Image));
            }
            return;
        }

        //保存する画像を選択
        private void ImageButtonClear_Click(object sender, RoutedEventArgs e) {

            var di = new OpenFileDialog();
            if (di.ShowDialog() == true) {
                _image = di.FileName;
            }
            if (di.FileName != null) {
                SelectImage.Source = new BitmapImage(new Uri(_image));
            }
        }

        private void ImageButtonClear_Click_1(object sender, RoutedEventArgs e) {
            SelectImage.Source = null;

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e) {
            Clear();
        }
    }
}