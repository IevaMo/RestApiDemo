﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiDemo.WebApi.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Price { get; set; }
        public Address Address { get; set; }
    }
}
