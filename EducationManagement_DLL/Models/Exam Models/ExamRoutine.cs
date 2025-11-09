using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducationManagement_DLL.Models.Exam_Models
{
  public  class ExamRoutine:BaseDTO
    {
        public int ExamId { get; set; }
        public int SessionID { get; set; }
        public int SubjectId { get; set; }
        public int AcademyClassId { get; set; }
       
        public DateTime ExamDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        [Required]
        [DisplayName("Day Of Week")]
        [StringLength(12)]
        public string DayOfWeek { get; set; }
        [ValidateNever]
        public ExamTitle Exam { get; set; }
        [ValidateNever]
        public SubjectInfo Subject { get; set; }
        
        [ValidateNever]
        public AcademyClass AcademyClass { get; set; }
       
        [ForeignKey("Institute")]
        public int InsId { get; set; }
        [ForeignKey("InstituteBranch")]
        public int InsBranchId { get; set; }
        [ValidateNever]
        public Institute? Institute { get; set; }
        [ValidateNever]
        public InsBranch? InstituteBranch { get; set; }
    }
}
