using System.ComponentModel.DataAnnotations;

namespace JobSearchBoardApi.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; 
        public int IndustryTypeId { get; set; }
        public IndastryType? IndastryType { get; set; }

        public ICollection<Employee>? Employees { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CreateDate { get; set; } 
    }
}
