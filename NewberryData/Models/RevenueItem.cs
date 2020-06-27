namespace NewberryData.Data
{
    public class RevenueProposal
    {
        public int Id { get; set; }
        public string FiscalYear { get; set; }
        public string RevenueCode { get; set; }
        public string Description { get; set; }
        public decimal Income { get; set; }
        public decimal Budget { get; set; }
        public decimal Projected { get; set; }
        public decimal Proposed { get; set; }
        public string ProjectedFiscalYear { get; set; }
    }

}