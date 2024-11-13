using CustomerApp.Objects;
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
        public MainWindow() {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e) {
            var customer = new Customer() {
                Name = NameTextBox.Text,
                Phone = PhoneTextBox.Text,

            };
            var databassName = "Shop.db";
            var folderPass = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var databassPass = System.IO.Path.Combine(folderPass, databassName);

            using (var connection = new SQLiteConnection(databassPass)) {
                connection.CreateTable<Customer>();
                connection.Insert(customer);
            }

        }

        private void ReadButton_Click(object sender, RoutedEventArgs e) {
            var databassName = "Shop.db";
            var folderPass = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var databassPass = System.IO.Path.Combine(folderPass, databassName);

            using (var connection = new SQLiteConnection(databassPass)) {
                connection.CreateTable<Customer>();
                var customers = connection.Table<Customer>().ToList();
            }
        }
    }
}
