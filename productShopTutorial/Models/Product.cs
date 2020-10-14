﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productShopTutorial.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Slug => Name.Replace(' ', '-');
    }
}
