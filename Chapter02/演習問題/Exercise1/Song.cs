﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    public class Song {

        public string Title { get; set; }
        public string ArtidtName { get; set; }
        public int Length { get; set; }


        public Song(string title,string artidName,int length) {
            Title = title;  
            ArtidtName = artidName;
            Length = length;
        }

    }
}
