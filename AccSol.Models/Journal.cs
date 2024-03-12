namespace AccSol.Models
{
    public class Journal 
    {
        public int ID { get; set; }
        public int? PettyCashID { get; set; }
        public int? CoaID { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
    }
}
