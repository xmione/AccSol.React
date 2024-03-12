namespace AccSol.Common.Reports
{
    public class GroupedReportData<T>
    {
        public Dictionary<string, object> Totals { get; set; } = new Dictionary<string, object>();
        public List<T> Items { get; set; } = new List<T>();
    }
}
