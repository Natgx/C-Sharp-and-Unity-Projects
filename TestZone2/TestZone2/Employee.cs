﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestZone2
{
    public class Employee<T>
    {
        public List<T> things { get; set; }
    }
}
