using AccSol.Common.Reports;

namespace AccSol.Services
{
    public interface ICommonService<TServiceModel>
    {
        Task<IEnumerable<TServiceModel>?> GetAll();
        Task<TServiceModel?> Get(int id);
        Task<TServiceModel?> Save(TServiceModel? model);
        Task Delete(int id);
        HttpClient GetHttpClient();
    }
}
