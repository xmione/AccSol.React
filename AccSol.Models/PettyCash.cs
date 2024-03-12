namespace AccSol.Models
{
    public class PettyCash
    {
        public int ID { get; set; }
        public string? PCFNo { get; set; }
        public DateTime? Date { get; set; }
        public int? PayeeID { get; set; }
        public string? Particulars { get; set; }
        public int? ProjectCodeID { get; set; }
        public int? DepartmentID { get; set; }
        public int? ClientID { get; set; }
        public decimal? Amount { get; set; }
    }
}
