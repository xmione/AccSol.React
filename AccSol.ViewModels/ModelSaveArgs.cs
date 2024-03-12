namespace AccSol.ViewModels
{
    public class ModelSaveArgs<TModel> : EventArgs
    {
        public bool IsValid { get; set; } = default!;
        public List<TModel> ModelList { get; set; } = default!;
        public TModel Model { get; set; } = default!;
    }
}
