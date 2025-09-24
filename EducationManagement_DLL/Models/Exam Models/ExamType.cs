using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationManagement_DLL.Models.Exam_Models
{
    public class ExamType:BaseDTO
    {
        public string TypeName { get; set; } = string.Empty;//MCQ,Written/CQ,Oral, Practical, Assignment, Project, Presentation
        public string? Description { get; set; } = string.Empty;
        public int Perchantage { get; set; }//CQ70%+ MCQ30%
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
