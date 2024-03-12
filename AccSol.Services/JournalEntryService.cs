using AccSol.Models;
using AccSol.ViewModels;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace AccSol.Services
{
    public class JournalEntryService : CommonService<Journal, IReportItem>
    {
        private readonly HttpClient _httpClient;
        public JournalEntryService(HttpClient httpClient) :base(httpClient)
        {
            _httpClient = httpClient;
        }

        public override async Task<IEnumerable<Journal>?> GetAll()
        {
            IEnumerable<Journal>? list = null;

            try
            {
                _httpClient.DefaultRequestHeaders.Accept.Clear();
                _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                list = await _httpClient.GetFromJsonAsync<IEnumerable<Journal>>("JournalEntries/GetAll");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            return list;
        }

        public override async Task<Journal?> Get(int id)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var getTask = _httpClient.PostAsJsonAsync<int>("JournalEntries/Get", id);
            Journal? journalEntry = null;
            try
            {

                getTask.Wait();
                HttpResponseMessage response = getTask.Result;
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    journalEntry = await response.Content.ReadFromJsonAsync<Journal>();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return journalEntry;
        }

        public override async Task<Journal?> Save(Journal? model)
        {
            if (model == null)
            {
                throw new Exception("Invalid or empty model.");
            }
            Journal? postedModel = null;
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var getTask = _httpClient.PostAsJsonAsync("JournalEntries/Save", model);

            getTask.Wait();
            HttpResponseMessage response = getTask.Result;
            response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {

                try
                {
                    postedModel = await response.Content.ReadFromJsonAsync<Journal>();
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

            var getTask = _httpClient.PostAsJsonAsync<int>("JournalEntries/Delete", id);

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
