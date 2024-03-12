using AccSol.Models;
using AccSol.ViewModels;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace AccSol.Services
{
    public class ProjectCategoryService : CommonService<ProjectCategory, IReportItem> 
    {
        private readonly HttpClient _httpClient;
        public ProjectCategoryService(HttpClient httpClient) :base(httpClient)
        {
            _httpClient = httpClient;
        }

        public override async Task<IEnumerable<ProjectCategory>?> GetAll()
        {
            IEnumerable<ProjectCategory>? list = null;

            try
            {
                _httpClient.DefaultRequestHeaders.Accept.Clear();
                _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                list = await _httpClient.GetFromJsonAsync<IEnumerable<ProjectCategory>>("ProjectCategories/GetAll");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            return list;
        }

        public override async Task<ProjectCategory?> Get(int id)
        {
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var getTask = _httpClient.PostAsJsonAsync<int>("ProjectCategories/Get", id);
            ProjectCategory? projectCategory = null;
            try
            {

                getTask.Wait();
                HttpResponseMessage response = getTask.Result;
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    projectCategory = await response.Content.ReadFromJsonAsync<ProjectCategory>();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return projectCategory;
        }

        public override async Task<ProjectCategory?> Save(ProjectCategory? model)
        {
            if (model == null)
            {
                throw new Exception("Invalid or empty model.");
            }
            ProjectCategory? postedModel = null;
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var getTask = _httpClient.PostAsJsonAsync("ProjectCategories/Save", model);

            getTask.Wait();
            HttpResponseMessage response = getTask.Result;
            response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {

                try
                {
                    postedModel = await response.Content.ReadFromJsonAsync<ProjectCategory>();
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

            var getTask = _httpClient.PostAsJsonAsync<int>("ProjectCategories/Delete", id);

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
