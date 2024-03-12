using System.Security.Cryptography.X509Certificates;

namespace AccSol.Models
{
    public class Payee
    {
        public int ID { get; set; }
        public int? PayeeCategoryID { get; set; }
        public int? EmployeeID { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
    }
}
