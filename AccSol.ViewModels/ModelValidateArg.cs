namespace AccSol.ViewModels
{
    public class ModelValidateArg<TModel> : EventArgs
    {
        public bool IsValid { get; set; }
        public TModel Model { get; set; }
    }
}
