﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextNumberSizeChange.Framework {
    public interface ITextFileService {
        void Initialize(string fname);
        void Executem(string line);
        void Terminate();
    }
}
