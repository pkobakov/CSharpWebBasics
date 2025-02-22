﻿using Andreys.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andreys.ViewModels.Products
{
    public class AddProductModel
    {
 
        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public decimal Price { get; set; }

        public string Category { get; set; }

        public string Gender { get; set; }
    }
}
