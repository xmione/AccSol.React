using AccSol.Models;
using AccSol.ViewModels;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace AccSol.Services
{
    public class CoaService : CommonService<Coa, IReportItem>
    {
        private readonly HttpClient _httpClient;
        public CoaService(HttpClient httpClient) : base(httpClient)
        {
            _httpClient = httpClient;
        }

        public override async Task<IEnumerable<Coa>?> GetAll()
        {
            IEnumerable<Coa>? list = null;

            try
            {
                _httpClient.DefaultRequestHeaders.Accept.Clear();
                _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                list = await _httpClient.GetFromJsonAsync<IEnumerable<Coa>>("Coas/GetAll");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            return list;
        }

        public override async Task<Coa?> Get(int id)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var getTask = _httpClient.PostAsJsonAsync<int>("Coas/Get", id);
            Coa? coa = null;
            try
            {

                getTask.Wait();
                HttpResponseMessage response = getTask.Result;
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    coa = await response.Content.ReadFromJsonAsync<Coa>();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return coa;
        }

        public override async Task<Coa?> Save(Coa? model)
        {
            if (model == null)
            {
                throw new Exception("Invalid or empty model.");
            }
            Coa? postedModel = null;
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var getTask = _httpClient.PostAsJsonAsync("Coas/Save", model);

            getTask.Wait();
            HttpResponseMessage response = getTask.Result;
            response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {

                try
                {
                    postedModel = await response.Content.ReadFromJsonAsync<Coa>();
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

            var getTask = _httpClient.PostAsJsonAsync<int>("Coas/Delete", id);

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
