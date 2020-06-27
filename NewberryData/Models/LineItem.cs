using System;

namespace NewberryData.Data
{
    public class LineItem
    {
        public int Id { get; set; }
        public string LineIdentifier { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string CategoryNumber { get; set; }
        public decimal Amount { get; set; }
        public string Year { get; set; }
    }

    public class RevenueItem
    {
        public int Id {get;set;}
        public string ﻿FiscalYear {get;set;}
        public string ﻿RevenueCode {get;set;}
        public string Description {get;set;}
        public decimal Income {get;set;}
        public decimal Budget {get;set;}
        public decimal Projected {get;set;}
        public decimal Proposed {get;set;}
        public string ﻿ProjectedFiscalYear {get;set;}
    }

}