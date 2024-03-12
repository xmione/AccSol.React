namespace AccSol.ViewModels
{
    public interface IViewModel<TModel, TModelVM>
    {
        TModel ToModel(Dictionary<string, object> serviceList);
        Task<TModelVM> FromModel(TModel model, Dictionary<string, object> serviceList);
    }
}
