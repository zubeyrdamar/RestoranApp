﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranUygulaması.Entities
{
    public class Kullanici
    {
        public Guid Id { get; set; }
        public string Ad { get; set; }
        public string Sifre { get; set; }
    }
}
