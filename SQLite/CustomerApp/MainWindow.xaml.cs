using CustomerApp.Objects;
using Microsoft.Win32;
using SQLite;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
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
using System.Drawing;
using System.Drawing.Imaging;


namespace CustomerApp {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        List<Customer> _customers;
        private byte[] _Picture;
        private string _selectedImagePath;



        public MainWindow() {
            InitializeComponent();
            ReadDatabase();
            Clear();
        }


        //セーブ
        private void SaveButton_Click(object sender, RoutedEventArgs e) {
            if (NameTextBox.Name == "") {
                MessageBox.Show("名前が入力されていません。",
                    "エラー",
                    MessageBoxButton.OK
                  );
                return;
            }

            var customer = new Customer() {
                Name = NameTextBox.Text,
                Phone = PhoneTextBox.Text,
                Address = AddressTextBox.Text,
                Picture = _Picture,
            };

            using (var connection = new SQLiteConnection(App.databassPass)) {
                connection.CreateTable<Customer>();
                connection.Insert(customer);

            }

            Clear();
            _Picture = null;

            ReadDatabase();//ListView表示
        }



        //クリア
        private void Clear() {
            NameTextBox.Clear();
            PhoneTextBox.Clear();
            AddressTextBox.Clear();
            SearchTextBox.Clear();
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

            if (_Picture != null) {
                item.Picture = _Picture;
            }

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
            var item = (Customer)CustomerListView.SelectedItem;
            if (SelectImage != null) {
                NameTextBox.Text = item.Name;
                PhoneTextBox.Text = item.Phone;
                AddressTextBox.Text = item.Address;
                SelectImage.Source = item.Image;

            } else {
                SelectImage.Source = null;
            }
        }




        private static Bitmap NewMethod(Customer item) {
            MemoryStream ms = new MemoryStream(item.Picture);
            Bitmap bmp = new Bitmap(ms);
            return bmp;
        }

        //保存する画像を選択
        private void ImageButtonSelect_Click(object sender, RoutedEventArgs e) {
            var openFileDialog = new Microsoft.Win32.OpenFileDialog {
                Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png"
            };

            if (openFileDialog.ShowDialog() == true) {
                _Picture = File.ReadAllBytes(openFileDialog.FileName);
                SelectImage.Source = new BitmapImage(new Uri(openFileDialog.FileName));
            }
        }

        private void ImageButtonClear_Click(object sender, RoutedEventArgs e) {
            SelectImage.Source = null;
            _Picture = null;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e) {
            Clear();
        }



        private byte[] ConvertImageToByteArray(string imagePath) {
            return File.ReadAllBytes(imagePath);
        }

    }
}