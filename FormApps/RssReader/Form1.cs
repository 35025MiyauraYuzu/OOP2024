using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
  
    public partial class Form1 : Form {

        
        List<ItemDate> xitems;

        public Form1() {
            InitializeComponent();
        }

        private void tbGet_Click(object sender, EventArgs e) {
            using (var wc = new WebClient()) {
                var url = wc.OpenRead(tbRssUrl.Text);
                var xdoc = XDocument.Load(url);

                xitems = xdoc.Root.Descendants("item").Select(x => new ItemDate {
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
            foreach (var xtitle in xitems.Select(x=>x.Title)) {
                lbRssTitle.Items.Add(xtitle);
            }

        }

        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {
            //

            webBrowser1.Navigate(xitems[lbRssTitle.SelectedIndex].Link);

        }
    }
    //データ格納用クラス
    public class ItemDate {
        public string Title { get; set; }
        public string Link { get; set; }
    }
}
