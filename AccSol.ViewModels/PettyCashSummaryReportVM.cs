namespace AccSol.ViewModels
{
    public class PettyCashSummaryReportVM : IReportItem
    {
        public int Row { get; set; }
        public string? PCFNo { get; set; }
        public DateTime? Date { get; set; }
        public string? Payee { get; set; }
        public string? DepartmentName { get; set; }
        public string? Particulars { get; set; }
        public string? ClientName { get; set; }
        public string? ProjectCode { get; set; }
        public decimal? Amount { get; set; }
        public string? AccountName { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
    }
}
