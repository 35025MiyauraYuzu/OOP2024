using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {

    public partial class Form1 : Form {


        List<ItemDate> items;
        List<Category> categories;

        public Form1() {
            InitializeComponent();
            InitializeCategory();

        }
        private void InitializeCategory() {
            categories = new List<Category> {

               new Category($"主要","https://news.yahoo.co.jp/rss/topics/top-picks.xml"),
               new Category($"国内","https://news.yahoo.co.jp/rss/topics/domestic.xml"),
               new Category($"経済","https://news.yahoo.co.jp/rss/topics/business.xml"),
               new Category($"エンタメ","https://news.yahoo.co.jp/rss/topics/business.xml"),
               new Category($"IT","https://news.yahoo.co.jp/rss/topics/it.xml"),
               new Category($"科学","https://news.yahoo.co.jp/rss/topics/science.xml"),
            };
            cbUrl.Items.AddRange(categories.ToArray());



            cbUrl.DataSource = categories;
            cbUrl.DisplayMember = "Title";
            cbUrl.ValueMember = "Url";

        }


        private void tbGet_Click(object sender, EventArgs e) {
            string selecturl;
            if (cbUrl.SelectedItem is Category s) {

            }


            using (var wc = new WebClient()) {
                var url = wc.OpenRead(cbUrl.Text);
                var xdoc = XDocument.Load(url);

                items = xdoc.Root.Descendants("item").Select(x => new ItemDate() {
                    Title = x.Element("title").Value,
                    Link = x.Element("link").Value,

                }).ToList();

                //Select(x => new {
                //  Title = x.Elements("title").Select(y => y.Value),
                //  Link = x.Elements("link").Select(y => y.Value),
                // });


                //Elements("title").Select(x => x.Value);
                //.Select(Item=>item.Elements("title").Value);
            }
            foreach (var xtitle in items.Select(x => x.Title)) {
                lbRssTitle.Items.Add(xtitle);
            }

        }

        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {


            if (webView21 != null && webView21.CoreWebView2 != null) {
                webView21.CoreWebView2.Navigate(items[lbRssTitle.SelectedIndex].Link);
            }
            // Uri uri = new Uri(xitems[lbRssTitle.SelectedIndex].Link);

            //webView2のsourceプロパティにuriをセット
            // webView21.Source = uri;



            //   webView21.Source =new Uri(xitems[lbRssTitle.SelectedIndex].Link);

        }

        private void webView21_Click(object sender, EventArgs e) {

        }

        private void tbRssUrl_TextChanged(object sender, EventArgs e) {

        }

        private void btRecord_Click(object sender, EventArgs e) {
            string cate = tbAuthor.Text;
            string url = items[lbRssTitle.SelectedIndex].Link;
            var newcate = new Category(cate, url);
            categories.Add(newcate);
            cbUrl.Refresh();

        }

        private void setCbUrl(string Name, Uri uri) {
            if (!cbUrl.Items.Contains(Name) && !cbUrl.Items.Contains(uri))
                cbUrl.Items.Add(Name);
        }
        private void Form1_Load(object sender, EventArgs e) {

        }

        private void tbAuthor_Click(object sender, EventArgs e) {

        }
    }

    public class Category {
        public string Title { get; set; }
        public string Url { get; set; }
        public Category(string title, string url) {
            Title = title;
            Url = url;
        }
    }



    //データ格納用クラス
    public class ItemDate {
        public string Title { get; set; }
        public string Link { get; set; }

    }
}
