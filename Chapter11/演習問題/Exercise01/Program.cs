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
                .Select(x=> new {
                    Name = x.Element("name").Value,
                    Team = x.Element("teammembers").Value
                }).OrderByDescending(x=>x.Team).First();

            Console.WriteLine(xelements.Name);
                
            
        }
        private static void Exercise1_4(string file, string newfile) {
            var element = new XElement(file,
                 new XElement("name", "サッカー", new XAttribute("kanji", "蹴球")),
                 new XElement("teammembers", "11"),
                 new XElement("firstplayed", "1863")
                 );
            var xdoc = XDocument.Load(file);
            xdoc.Root.Add(element);
            xdoc.Save(newfile);

        }

    }
}
