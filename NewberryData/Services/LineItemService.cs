using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Threading.Tasks;
using Dapper;
using NewberryData.Data;

public class LineItemService
{
    protected readonly string connectionString = "Data Source=app.db";
    private IDbConnection connection;

    public LineItemService()
    {
        connection = new SQLiteConnection(connectionString);
        connection.Open();
    }

    public async Task<ReportResponse> GetLineItemsAsync(ReportRequest request)
    {
        var responseData = await connection.QueryAsync<LineItem>("select * from LineItem where category= @category");
        var response = new ReportResponse
        {
            Data = responseData
        };
        return response;
    }



}