namespace AccSol.Models
{
    public class ProjectCode
    {
        public int ID { get; set; }
        public int? ProjectCategoryID { get; set; }
        public int?  ProjectYear { get; set; }
        public int? ClientID { get; set; }
        public string? ProjectNumber { get; set; }
        public string? Code { get; set; }

        public string? Description { get; set; }
    }
}
