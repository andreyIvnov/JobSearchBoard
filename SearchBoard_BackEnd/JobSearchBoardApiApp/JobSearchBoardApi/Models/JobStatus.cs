using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearchBoardApi.Models
{
    public class JobStatus
    {
        public int Id { get; set; }
        public string StatusOption { get; set; } = string.Empty;
    }
}
