using System.Threading.Tasks;

namespace NewberryData.Services.Interfaces
{
    public interface IBudgetReport
    {
        Task<ReportResponse> GetLineItemsAsync(ReportRequest request);        
    }
}