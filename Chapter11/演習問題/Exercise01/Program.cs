using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            var file = "sample.xml";
            Exercise1_1(file);
            Console.WriteLine();
            Exercise1_2(file);
            Console.WriteLine();
            Exercise1_3(file);
            Console.WriteLine();

            var newfile = "sports.xml";
            Exercise1_4(file, newfile);

        }



        private static void Exercise1_1(string file) {
            var xdoc = XDocument.Load(file);
            var xelements = xdoc.Root.Elements()
                .Select(e => new {
                    Name = (string)e.Element("name"),
                    Teammembers = (string)e.Element("teammembers")
                });
            foreach (var xballsport in xelements) {
                Console.WriteLine("{0} - {1}", xballsport.Name, xballsport.Teammembers);
            }
        }

        private static void Exercise1_2(string file) {
            var xdoc = XDocument.Load(file);
            var xelements = xdoc.Root.Elements()
                .Select(x => new {
                    Name = x.Element("name").Attribute("kanji").Value,
                    firstplayed = x.Element("firstplayed").Value,
                })
                .OrderBy(x => x.firstplayed);
            foreach (var sport in xelements) {
                Console.WriteLine("{0} ({1})", sport.Name, sport.firstplayed);
            }

        }

        private static void Exercise1_3(string file) {
            var xdoc = XDocument.Load(file);
            var xelements = xdoc.Root.Elements()
                .Select(x => new {
                    Name = x.Element("name").Value,
                    Team = x.Element("teammembers").Value
                }).OrderByDescending(x => x.Team).First();

            Console.WriteLine(xelements.Name);


        }
        private static void Exercise1_4(string file, string newfile) {
            List<XElement> list = new List<XElement>();
            var xdoc = XDocument.Load(file);
            int bu;

            while (true) {
                Console.Write("スポーツの名称を入力してください。:");
                string name = Console.ReadLine();
                Console.WriteLine();

                Console.Write("スポーツの漢字を入力してください。:");
                string Kanji = Console.ReadLine();
                Console.WriteLine();

                Console.Write("スポーツの人数を入力してください。:");
                string teammember = Console.ReadLine();
                Console.WriteLine();

                Console.Write("スポーツの起源を入力してください。:");
                string firstplayed = Console.ReadLine();
                Console.WriteLine();

                var element = new XElement(file,
                     new XElement("name", name, new XAttribute("kanji", Kanji)),
                     new XElement("teammembers", teammember),
                     new XElement("firstplayed", firstplayed)
                     );
                list.Add(element);
                Console.WriteLine("追加(1) / 保存(2)");
                bu = int.Parse(Console.ReadLine());
                if (bu == 2)
                    break;

                Console.WriteLine();
            }
            xdoc.Root.Add(list);
            xdoc.Save(newfile);
        }
    }

}

