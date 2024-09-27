using Microsoft.Web.WebView2.WinForms;

using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Linq;

using System.Net;

using System.Text;

using System.Threading.Tasks;

using System.Windows.Forms;

using System.Xml.Linq;

using Microsoft.Web.WebView2.Core;

//using Microsoft.Toolkit.Forms.UI.Controls;

using Microsoft.Web.WebView2.Wpf;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Windows.UI.Xaml.Controls;

namespace RssReader {

    public partial class Form1 : Form {


        List<ItemData> items;
        List<ItemData> categories;

        public Form1() {
            InitializeComponent();
            InitializeCategory();

            webView21.EnsureCoreWebView2Async(null);

            //  AddCbBox();

            cbUrl.SelectedIndex = -1;

            MessageBox.Show("①カテゴリ選択またはURLを入力して取得ボタンを押す\n" +
                "②お気に入り名称とURLを入力して登録ボタンを押す", "使い方", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void InitializeCategory() {
            categories = new List<ItemData> {

                new ItemData { Title = "主要", Link = "https://news.yahoo.co.jp/rss/topics/top-picks.xml" },
                new ItemData { Title = "国内", Link = "https://news.yahoo.co.jp/rss/topics/domestic.xml" },
                new ItemData { Title = "国際", Link = "https://news.yahoo.co.jp/rss/topics/world.xml" },
                new ItemData { Title = "経済", Link = "https://news.yahoo.co.jp/rss/topics/business.xml" },
                new ItemData { Title = "エンタメ", Link = "https://news.yahoo.co.jp/rss/topics/entertainment.xml" },
                new ItemData { Title = "スポーツ", Link = "https://news.yahoo.co.jp/rss/topics/sports.xml" },
                new ItemData { Title = "IT", Link = "https://news.yahoo.co.jp/rss/topics/it.xml" },
                new ItemData { Title = "科学", Link = "https://news.yahoo.co.jp/rss/topics/science.xml" },
                new ItemData { Title = "地域", Link = "https://news.yahoo.co.jp/rss/topics/local.xml" },
            };
            foreach (ItemData item in categories) {
                cbUrl.Items.Add(item.Title);
            }

        }




        private void AddCbBox() {
            //  cbUrl.DataSource = new Categor


        }

        private void Form_Resize(object sender, EventArgs e) {

            webView21.Size = this.ClientSize - new System.Drawing.Size(webView21.Location);

        }

        //取得
        private async void btGet_Click(object sender, EventArgs e) {
            lbRssTitle.Items.Clear();

            try {
                using (var wc = new WebClient()) {
                    var url = wc.OpenRead(getLink(cbUrl.Text));
                    var xdoc = XDocument.Load(url);

                    items = xdoc.Root.Descendants("item").Select(x => new ItemData {
                        Title = x.Element("title").Value,
                        Link = x.Element("link").Value,
                    }).ToList();
                    foreach (var item in items) {
                        lbRssTitle.Items.Add(item.Title);
                    }
                }
            }
            catch (Exception) {
                MessageBox.Show("入力形式がおかしくなってます。", "エラー",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {

            if (webView21 != null && webView21.CoreWebView2 != null) {
                webView21.CoreWebView2.Navigate(items[lbRssTitle.SelectedIndex].Link);
            }

        }

        //お気に入り
        private void btRecord_Click(object sender, EventArgs e) {
            try {
                if (tbAuthor.Text == "" || cbUrl.Text == "") {
                    MessageBox.Show("正しいURL又はお気に入り名称が入力されていません。", "エラー",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var distinct_category = categories.FirstOrDefault(x => x.Title == tbAuthor.Text);
                if (distinct_category != null) {
                    MessageBox.Show("既に同じ名前でお気に入り登録されてます。同じ名前でお気に入り登録はできません。", "エラー",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var item = new ItemData {
                    Title = tbAuthor.Text,
                    Link = getLink(cbUrl.Text),
                };
                categories.Add(item);
                cbUrl.Items.Add(item.Title);
                clear();
            }
            catch (Exception) {
                MessageBox.Show("エラーが発生しました。", "エラー",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clear() {
            cbUrl.Text = null;
            tbAuthor.Clear();
            lbRssTitle.Items.Clear();
            webView21.CoreWebView2.Navigate("about:blank");
        }

        private string getLink(string element) {
            var topic = categories.FirstOrDefault(x => x.Title == element);
            if (topic == null) {
                return element;
            }
            return topic.Link;
        }



        private void tbAuthor_TextChanged(object sender, EventArgs e) {

        }
    }


    //データ格納用のクラス

    public class ItemData {

        public string Title { get; set; }

        public string Link { get; set; }

    }
    public class Category {
        public string Title { get; set; }
        public string Url { get; set; }
        public Category(string title, string url) {
            Title = title;
            Url = url;
        }
    }


}

