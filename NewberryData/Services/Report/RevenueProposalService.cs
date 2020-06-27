using System.Data;
using System.Data.SQLite;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;
using NewberryData.Data;
using NewberryData.Services.Interfaces;

namespace NewberryData.Services.Report
{
    public class RevenueProposalService : IRevenueReport
    {
        private const string DefaultConnectionName = "DefaultConnection";

        private IDbConnection connection;

        public RevenueProposalService(IConfiguration configuration)
        {
            connection = new SQLiteConnection(configuration[DefaultConnectionName]);
            connection.Open();
        }

        public async Task<RevenueReportResponse> GetAllIncomeItemAsync()
        {
            var query =
                @"SELECT Id,
                    FiscalYear,
                    RevenueCode,
                    Description,
                    Income,
                    Budget,
                    Projected,
                    Proposed,
                    ProjectedFiscalYear
                FROM RevenueProposal;";
            var responseData =
                await connection.QueryAsync<RevenueProposal>(query);

            RevenueReportResponse response = new RevenueReportResponse
            {
                Data = responseData
            };

            return response;
        }
       
    }
}