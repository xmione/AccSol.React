
namespace AccSol.ViewModels
{
    public class ModelEventArg<TModel> : EventArgs
    {
        public TModel Model { get; set; }
    }

}
