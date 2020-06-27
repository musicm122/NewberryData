using System.Threading.Tasks;

namespace NewberryData.Services.Interfaces
{
    public interface IRevenueReport
    {
        Task<RevenueReportResponse> GetAllIncomeItemAsync();        
    }
}