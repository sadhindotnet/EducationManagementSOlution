using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationManagement_DLL.Models.Exam_Models
{
   public class Grade:BaseDTO
    {
        public Grade()
        {
            AcademyClass = new AcademyClass();
        }
        public string Name { get; set; } = "";
        [ForeignKey("AcademyClass")]
        public int ClassID { get; set; }
        public string ClassInterval { get; set; } = string.Empty;//
        public string LetterGrade { get; set; } = string.Empty;//=A+ [A+,A,A-,B+,B,B-,C+,C,C-,D+,D,D-,F]
        public decimal? GradePoint { get; set; }//5
        public decimal? StartInterval { get; set; }//80
        public decimal? EndInterval { get; set; }//100
        public int SortOrder { get; set; }//1
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
