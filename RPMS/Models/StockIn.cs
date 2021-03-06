﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpms.Models
{
    public class StockIn
    {
        public Guid ProductID { get; set; }

        public int Quantity { get; set; }

        public Guid VendorID { get; set; }

        public Decimal MRP { get; set; }

        public Decimal CostPrice { get; set; }

        public DateTime Date { get; set; }

        public DateTime EntryDate { get; set; }

        public string Status { get; set; }

    }

}
