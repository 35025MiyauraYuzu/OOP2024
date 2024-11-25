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
        string _image = null;  //画像の記憶
        byte[] binaryData;


        public MainWindow() {
            InitializeComponent();
            ReadDatabase();
            Clear();
        }

        //セーブ
        private void SaveButton_Click(object sender, RoutedEventArgs e) {
            if (SelectImage.Source !=null) {
                Bitmap bmp = new Bitmap($"{SelectImage.Source}");
                MemoryStream ms = new MemoryStream();
                bmp.Save(ms, ImageFormat.Jpeg);
                binaryData = ms.ToArray();
            }
            var customer = new Customer() {
                Name = NameTextBox.Text,
                Phone = PhoneTextBox.Text,
                Address = AddressTextBox.Text,
                Picture = binaryData,

            };
            if (customer.Name == "") {
                MessageBox.Show("名前が入力されていません。",
                    "エラー",
                    MessageBoxButton.OK
                  );
                return;
            }
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
            _image = null;
            SelectImage.Source = null;
            CustomerListView.SelectedItem = null;
        }

        //アップデート
        private void UpdateButton_Click(object sender, RoutedEventArgs e) {
            var item = CustomerListView.SelectedItem as Customer;

            if (item == null) {
                MessageBox.Show("変更する行を選択してください");
                return;
            }
            Bitmap bmp = new Bitmap($"{SelectImage.Source}");
            MemoryStream ms = new MemoryStream();
            bmp.Save(ms, ImageFormat.Jpeg);
            binaryData = ms.ToArray();

            item.Name = NameTextBox.Text;
            item.Phone = PhoneTextBox.Text;
            item.Address = AddressTextBox.Text;
            item.Picture = binaryData;
        

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
            Bitmap bmp = NewMethod(item);
            NameTextBox.Text = item.Name;
            PhoneTextBox.Text = item.Phone;
            AddressTextBox.Text = item.Address;
            SelectImage.Source = bmp;

        }

        private static Bitmap NewMethod(Customer item) {
            MemoryStream ms = new MemoryStream(item.Picture);
            Bitmap bmp = new Bitmap(ms);
            return bmp;
        }

        //保存する画像を選択
        private void ImageButtonSelect_Click(object sender, RoutedEventArgs e) {

            var FilePath = new OpenFileDialog();
            if (FilePath.ShowDialog() == true) {
                _image = FilePath.FileName;
            }
            if (FilePath.FileName != null && _image != "") {
                SelectImage.Source = new BitmapImage(new Uri(_image));
            }
        }

        private void ImageButtonClear_Click(object sender, RoutedEventArgs e) {
            SelectImage.Source = null;

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e) {
            Clear();
        }

        

        
    }
}