using System.ComponentModel.DataAnnotations;

namespace JobSearchBoardApi.Models
{
    public class Employee
    {
        public int Id { get; set; } 
        
        [StringLength(20)]
        public string FirstName { get; set; } = string.Empty;

        [StringLength(20)]
        public string LastName { get; set; } = string.Empty;

        public Company? Company { get; set; }

    }
}
