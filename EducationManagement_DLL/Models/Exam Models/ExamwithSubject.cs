using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationManagement_DLL.Models.Exam_Models
{
  public  class ExamwithSubject:BaseDTO
    {
        [ForeignKey("ExamTitle")]
         public int ExamTitleId { get; set; }
        [ForeignKey("SubjectInfo")]
        public int SubjectId { get; set; }
        [ForeignKey("ExamType")]
         public int ExamTypeId { get; set; }
        public int FullMarks { get; set; }
        public int PassingMarks { get; set; }
        public int DurationInMinutes { get; set; }
        [ValidateNever]
        public ExamTitle ExamTitle { get; set; }
        [ValidateNever]
        public ExamType ExamType { get; set; }
        [ValidateNever]
        public SubjectInfo SubjectInfo { get; set; }
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
