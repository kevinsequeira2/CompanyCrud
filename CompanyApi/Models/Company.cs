using System.Collections.Generic;

namespace CompanyApi.Models
{
    public class Company
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string GovernmentId { get; set; }
        public List<Branch> Branches { get; set; }
    }
}