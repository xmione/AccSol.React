using AccSol.Models;
using AccSol.ViewModels;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace AccSol.Services
{
    public class PayeeService : CommonService<Payee, IReportItem>
    {
        private readonly HttpClient _httpClient;
        public PayeeService(HttpClient httpClient) : base(httpClient)
        {
            _httpClient = httpClient;
        }

        public override async Task<IEnumerable<Payee>?> GetAll()
        {
            IEnumerable<Payee>? list = null;

            try
            {
                _httpClient.DefaultRequestHeaders.Accept.Clear();
                _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                list = await _httpClient.GetFromJsonAsync<IEnumerable<Payee>>("Payees/GetAll");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            return list;
        }

        public override async Task<Payee?> Get(int id)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var getTask = _httpClient.PostAsJsonAsync<int>("Payees/Get", id);
            Payee? payee = null;
            try
            {

                getTask.Wait();
                HttpResponseMessage response = getTask.Result;
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    payee = await response.Content.ReadFromJsonAsync<Payee>();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return payee;
        }

        public override async Task<Payee?> Save(Payee? model)
        {
            if (model == null)
            {
                throw new Exception("Invalid or empty model.");
            }
            Payee? postedModel = null;
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var getTask = _httpClient.PostAsJsonAsync("Payees/Save", model);

            getTask.Wait();
            HttpResponseMessage response = getTask.Result;
            response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {

                try
                {
                    postedModel = await response.Content.ReadFromJsonAsync<Payee>();
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

            var getTask = _httpClient.PostAsJsonAsync<int>("Payees/Delete", id);

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
