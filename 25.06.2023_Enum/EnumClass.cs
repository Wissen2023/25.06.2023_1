﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._06._2023_Enum
{
    public class EnumClass
    {
        public enum Gunler { Pazartesi, Salı, Çarşamba, Perşembe, Cuma, Cumartesi, Pazar};

        public string[] days = Gunler.GetNames(typeof(Gunler));
    }
}
