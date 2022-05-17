using System.ComponentModel.DataAnnotations;

namespace JobSearchBoardApi.Models
{
    public class Job
    {
        public int Id { get; set; }

        [StringLength(30)]
        public string Name { get; set; } = string.Empty;

        [StringLength(200)]
        public string Description { get; set; } = string.Empty;

        [Required]
        public int NumOfNeedEmployees { get; set; }

        public JobStatus? JobStatus { get; set; }

    }
}
