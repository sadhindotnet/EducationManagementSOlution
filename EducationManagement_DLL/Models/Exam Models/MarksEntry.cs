using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationManagement_DLL.Models.Exam_Models
{
   public class MarksEntry:BaseDTO
    {
        [ForeignKey("StudentBasicInfo")]
        public int StudentID { get; set; }
        public int SessionID { get; set; }
        [ForeignKey("AcademyClass")]
        public int ClassID { get; set; }
        public int SectionID { get; set; }
        [ForeignKey("ExamTitle")]
        public int ExamID { get; set; }
        [ForeignKey("SubjectInfo")]
        public int SubjectID { get; set; }
        [ForeignKey("ExamType")]
        public int ExamTypeID { get; set; }
        public decimal? ObtainMark { get; set; }
        public AcademyClass AcademyClass { get; set; }
        public StudentBasicInfo StudentBasicInfo { get; set; }
        public ExamTitle ExamTitle { get; set; }
        public SubjectInfo SubjectInfo { get; set; }
        public ExamType ExamType { get; set; }
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
