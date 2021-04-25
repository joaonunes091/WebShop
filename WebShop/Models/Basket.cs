﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Models
{
    public class Basket
    {
        public int BasketId { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Qty { get; set; }

        public decimal Total { get; set; }

    }
}
