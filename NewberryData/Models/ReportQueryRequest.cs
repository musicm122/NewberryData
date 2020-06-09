using System.Collections.Generic;
using NewberryData.Data;

public class ReportRequest
{
    public string Category { get; set; }
    public string Year { get; set; }
}

public class ReportResponse
{
    public IEnumerable<LineItem> Data { get; set; }
}