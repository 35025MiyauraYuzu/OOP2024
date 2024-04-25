using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    internal class Program {
        static void Main(string[] args) {

            var songs = new Song[] {

                new Song("相反バラエティ","VALIS",240),
                new Song("食虫植物","理芽",283),
                new Song("逃避行","Dios",245),
                new Song("地上の星","中島みゆき",330),

                 };
            PrintSong(songs);

        }
        private static void PrintSong(Song[] songs) {

            foreach (var song in songs) {
                Console.WriteLine(@"{0},{1},{2:mm\:ss}", song.Title, song.ArtidtName, TimeSpan.FromSeconds(song.Length));

            }
        }
    }
}

