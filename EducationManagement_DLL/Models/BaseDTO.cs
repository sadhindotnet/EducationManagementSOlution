using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationManagement_DLL.Models
{
 public   class BaseDTO
    {
        [Key]
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Now.Date;
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedBy
        {
            get; set;
        }

        public string? DomainName { get; set; }
        public string? IP { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
