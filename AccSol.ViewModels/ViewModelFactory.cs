namespace AccSol.ViewModels
{
    public class ViewModelFactory : IViewModelFactory
    {
        public async Task<TViewModel> CreateViewModel<TModel, TViewModel>(TModel model, Dictionary<string, object> serviceList) where TViewModel : class
        {
            // Get the type of the ViewModel
            var viewModelType = typeof(TViewModel);

            // Find the constructor that takes a model as a parameter
            var constructorInfo = viewModelType.GetConstructor(new[] { typeof(TModel) });

            // If the constructor was found, invoke it to create a new ViewModel
            if (constructorInfo != null)
            {
                var viewModel = constructorInfo.Invoke(new object[] { model }) as TViewModel;

                // If the ViewModel implements IViewModel<TModel, TViewModel>, call the FromModel method
                if (viewModel is IViewModel<TModel, TViewModel> ivm)
                {
                    return await ivm.FromModel(model, serviceList);
                }

                // Otherwise, return the ViewModel as is
                return viewModel;
            }

            // If the constructor was not found, throw an exception or return null
            throw new InvalidOperationException($"No suitable constructor found for ViewModel of type {viewModelType.FullName}");
        }
    }

}
