using System.Net.Http.Headers;
using System.Text.Json;
using System.Text;
using AccSol.Common.Reports;
using Microsoft.JSInterop;

namespace AccSol.Services
{
    public abstract class CommonService<TServiceModel, TReportModel> : ICommonService<TServiceModel>
    {
        private readonly HttpClient _httpClient;
        public CommonService(HttpClient httpClient) 
        {
            _httpClient = httpClient;
        }

        public virtual HttpClient GetHttpClient() 
        {
            return _httpClient;
        }

        public virtual async Task DownloadExcelReport(List<GroupedReportData<TReportModel>> items, string excelFilePath, string serviceUrl)
        {
            try
            {
                _httpClient.DefaultRequestHeaders.Accept.Clear();
                _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var jsonContent = new StringContent(JsonSerializer.Serialize(items), Encoding.UTF8, "application/json");
                
                await _httpClient.PostAsync(serviceUrl, jsonContent);

            }
            catch (Exception ex)
            {
                Console.WriteLine("CommonService.DownloadExcelReport: {0}\r\n{1}", ex.Message, ex.StackTrace);
            }
        }

        [JSInvokable]
        public async Task<TServiceModel> FetchDetails(int id)
        {
            TServiceModel model = (await Get(id)) ?? Activator.CreateInstance<TServiceModel>();
            return model;
        }                
        public abstract Task<IEnumerable<TServiceModel>?> GetAll();
        public abstract Task<TServiceModel?> Get(int id);
        public abstract Task<TServiceModel?> Save(TServiceModel? model);
        public abstract Task Delete(int id);
    }
}
