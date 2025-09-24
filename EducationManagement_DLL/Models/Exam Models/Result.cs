using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationManagement_DLL.Models.Exam_Models
{
    //This table will automatically store the final result of a student after calculating all the marks obtained in different exam types for a particular subject during entry mark.
    /// <summary>
    /// this  will display after Marksentry
    /// if payment due  result will not be shown
    /// result will visible if authority publish the result, after ResultPublisheDate
    /// </summary>
    public class Result:BaseDTO
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
        public decimal? ConvertedMarks { get; set; }
        [ForeignKey("Grade")]
        public int GradeId { get; set; }
        public bool isPublished { get; set; } = false;
        public DateTime ResultPublisheDate { get; set; } = DateTime.Now;
        [ValidateNever]
        public  Grade Grade { get; set; }
        [ValidateNever]
        public AcademyClass AcademyClass { get; set; }
        [ValidateNever]
        public StudentBasicInfo StudentBasicInfo { get; set; }
        [ValidateNever]
        public ExamTitle ExamTitle { get; set; }
        [ValidateNever]
        public SubjectInfo SubjectInfo { get; set; }
        [ValidateNever]
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
