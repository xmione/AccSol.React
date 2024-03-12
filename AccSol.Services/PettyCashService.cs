using AccSol.Models;
using AccSol.ViewModels;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace AccSol.Services
{
    public class PettyCashService : CommonService<PettyCash, PettyCashSummaryReportVM>
    {
        private readonly HttpClient _httpClient;
        public PettyCashService(HttpClient httpClient) : base(httpClient)
        {
            _httpClient = httpClient;
        }

        public override async Task<IEnumerable<PettyCash>?> GetAll()
        {
            IEnumerable<PettyCash>? list = null;

            try
            {
                _httpClient.DefaultRequestHeaders.Accept.Clear();
                _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                list = await _httpClient.GetFromJsonAsync<IEnumerable<PettyCash>>("PettyCashes/GetAll");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            return list;
        }

        public override async Task<PettyCash?> Get(int id)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var getTask = _httpClient.PostAsJsonAsync<int>("PettyCashes/Get", id);
            PettyCash? pettyCash = null;
            try
            {

                getTask.Wait();
                HttpResponseMessage response = getTask.Result;
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    pettyCash = await response.Content.ReadFromJsonAsync<PettyCash>();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return pettyCash;
        }

        public override async Task<PettyCash?> Save(PettyCash? model)
        {
            if (model == null)
            {
                throw new Exception("Invalid or empty model.");
            }
            PettyCash? postedModel = null;
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var getTask = _httpClient.PostAsJsonAsync("PettyCashes/Save", model);

            getTask.Wait();
            HttpResponseMessage response = getTask.Result;
            response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {

                try
                {
                    postedModel = await response.Content.ReadFromJsonAsync<PettyCash>();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return postedModel;
        }
        
        public override async Task Delete(int id)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var getTask = _httpClient.PostAsJsonAsync<int>("PettyCashes/Delete", id);

            try
            {

                await getTask;
                var response = getTask.Result;
                
                if (response == null)
                {
                    throw new Exception("There was an error in deleting the data.");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
    }
}
