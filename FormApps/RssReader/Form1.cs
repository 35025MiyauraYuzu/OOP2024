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

namespace RssReader {

    public partial class Form1 : Form {


        List<ItemData> items;
        List<Category> categories;

        public Form1() {
            InitializeComponent();
            InitializeCategory();

            webView21.EnsureCoreWebView2Async(null);

          //  AddCbBox();

            cbUrl.SelectedIndex = -1;

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




        private void AddCbBox() {
          //  cbUrl.DataSource = new Categor
           

        }

        private void Form_Resize(object sender, EventArgs e) {

           // webView21.Size = this.ClientSize - new System.Drawing.Size(webView21.Location);

        }

        private async void btGet_Click(object sender, EventArgs e) {

            string selecturl;
            if (cbUrl.SelectedItem is Category h) {
                selecturl = h.Url;
            } else {
                selecturl = cbUrl.Text;
            }
            if (!string.IsNullOrWhiteSpace(selecturl)) {
                using (var wc = new WebClient()) {
                    wc.Encoding = Encoding.UTF8;
                    var rssData = await wc.DownloadStringTaskAsync(selecturl);

                    var xdoc = XDocument.Parse(rssData);
                    items = xdoc.Root.Descendants("item")
                                            .Select(item => new ItemData {
                                                Title = item.Element("title").Value,
                                                Link = item.Element("link").Value,
                                            }).ToList();
                    lbRssTitle.Invoke(new Action(() => {
                        lbRssTitle.Items.Clear();
                        foreach (var item in items) {
                            lbRssTitle.Items.Add(item.Title);

                            //検索

                            //     string cbBox = cbUrl.Text;

                            //       if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable()) {

                            //           if (cbUrl.Text.Contains("yahoo.co.jp/rss/")) {



                        }
                    }));

                }
            }
        }


        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {

            if (webView21 != null && webView21.CoreWebView2 != null) {

                webView21.CoreWebView2.Navigate(items[lbRssTitle.SelectedIndex].Link);

            }

        }

       
        private void btRecord_Click(object sender, EventArgs e) {
            string categoryTitle = tbAuthor.Text;
            string url = cbUrl.Text;
            var favorite = new Category(categoryTitle, url);
            categories.Add(favorite);



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

