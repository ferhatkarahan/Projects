﻿using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo2
{
    public class Products
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public int UnitPrice { get; set; }
        public int StockAmount { get; set; }
    }
}
