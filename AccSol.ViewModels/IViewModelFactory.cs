namespace AccSol.ViewModels
{
    public interface IViewModelFactory
    {
        Task<TViewModel> CreateViewModel<TModel, TViewModel>(TModel model, Dictionary<string, object> serviceList) where TViewModel : class;
    }
}
