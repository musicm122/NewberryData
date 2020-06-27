using System.Data;
using System.Data.SQLite;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;
using NewberryData.Data;
using NewberryData.Services.Interfaces;

namespace NewberryData.Services.Report
{    
    public class BudgetReportService : IBudgetReport
    {
        private const string DefaultConnectionName = "DefaultConnection";

        private IDbConnection connection;

        public BudgetReportService(IConfiguration configuration)
        {
            connection = new SQLiteConnection(configuration[DefaultConnectionName]);
            connection.Open();
        }

        public async Task<ReportResponse> GetLineItemsAsync(ReportRequest request)
        {
            var query =
                @"SELECT 
                    Id, LineIdentifier, Name, Category, CategoryNumber, Amount, TimeFrame, Enabled 
                FROM LineItem;";
            var responseData =
                await connection.QueryAsync<LineItem>(query);

            var response = new ReportResponse
            {
                Data = responseData
            };

            return response;
        }

    }
}