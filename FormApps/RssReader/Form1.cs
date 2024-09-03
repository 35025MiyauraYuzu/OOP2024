﻿using System;
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

namespace RssReader {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void tbGet_Click(object sender, EventArgs e) {
            using (var wc = new WebClient()) {
                var url = wc.OpenRead(tbRssUrl.Text);
                var xdoc = XDocument.Load(url);
                var xtitles = xdoc.Root.Descendants("item").Elements("title").Select(x => x.Value);
                //Select(x => new {
                //  Title = x.Elements("title").Select(y => y.Value),
                //  Link = x.Elements("link").Select(y => y.Value),
                // });


                //Elements("title").Select(x => x.Value);
                //.Select(Item=>item.Elements("title").Value);
                foreach (var xtitle in xtitles) {
                    lbRssTitle.Items.Add(xtitle);
                }
            }

        }
    }
}
