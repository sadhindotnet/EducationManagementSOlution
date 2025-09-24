using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationManagement_DLL.Models.Exam_Models
{
   public  class ExamTitle:BaseDTO
    {
        [StringLength(30)]
        [Required]
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;

    }
}
