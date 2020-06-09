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

}