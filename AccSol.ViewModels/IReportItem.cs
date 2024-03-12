namespace AccSol.ViewModels
{
    public interface IReportItem
    {
        // Define the properties that you want to display in your table
        int Row { get; set; }
        string? PCFNo { get; set; }
        DateTime? Date { get; set; }
        string? Particulars { get; set; }
        string? ClientName { get; set; }
        string? ProjectCode { get; set; }
        string? DepartmentName { get; set; }
        string? AccountName { get; set; }
        decimal? Amount { get; set; }
        decimal? Debit { get; set; }
        decimal? Credit { get; set; }
    }
}
