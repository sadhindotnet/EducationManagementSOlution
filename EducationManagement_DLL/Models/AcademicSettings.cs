using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using EducationManagement_DLL.Infrastructures.Repositories;
using EducationManagement_DLL.Models.Exam_Models;
using Microsoft.EntityFrameworkCore;

namespace EducationManagement_DLL.Models
{
    public class Attendance : BaseDTO
    {
        public int StudentId { get; set; }
        public DateTime Date { get; set; }
        public bool IsPresent { get; set; }
        [ValidateNever]
        public StudentBasicInfo Student { get; set; }
    }
    public class AdmitCard : BaseDTO
    {

        public int StudentId { get; set; }
        public int ExamId { get; set; }
        public string AdmitCardPath { get; set; }

        public DateTime IssuedDate { get; set; }
        [ValidateNever]
        public StudentBasicInfo Student { get; set; }
        [ValidateNever]
        public ExamTitle Exam { get; set; }
    }
    public class AcademicSession : BaseDTO
    {
      //  public int Id { get; set; }
        public string SessionName { get; set; }
        public string? Description { get; set; }
        [ForeignKey("Institute")]
        public int InsId { get; set; }
        [ForeignKey("InstituteBranch")]
        public int InsBranchId { get; set; }
        [ValidateNever]
        public Institute? Institute { get; set; }
        [ValidateNever]
        public InsBranch? InstituteBranch { get; set; }
        //[ForeignKey("Module")]
        //public int ModuleId { get; set; }
        //[ValidateNever]
        //public virtual Module Module { get; set; }
    }
    public class AcademicDepartment : BaseDTO
    {
      //  public int ID { get; set; }

        [Display(Name = "Department")]
        public int DepartmentName { get; set; }
        //[ForeignKey("Module")]
        //public int ModuleId { get; set; }
        //public virtual Module Module { get; set; }



    }
    public class ProgramGroup : BaseDTO
    {
       // public int Id { get; set; }
        public string GroupName { get; set; }
        public int Duration { get; set; }
        [ForeignKey("Institute")]
        public int InsId { get; set; }
        [ForeignKey("InstituteBranch")]
        public int InsBranchId { get; set; }
        [ValidateNever]
        public Institute Institute { get; set; }
        [ValidateNever]
        public InsBranch InstituteBranch { get; set; }
        [ValidateNever]
        public ICollection<Program1> Programs { get; set; }
    }
    public class Program1 : BaseDTO
    {
        //public int Id { get; set; }
        [ForeignKey("ProgramGroup")]
        public int ProgramGroupId { get; set; }

        public int StartLevel { get; set; }

        public int EndLevel { get; set; }
        public string CertificateName { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        [ForeignKey("Institute")]
        public int InsId { get; set; }
        [ForeignKey("InstituteBranch")]
        public int InsBranchId { get; set; }
        public Institute Institute { get; set; }
        public InsBranch InstituteBranch { get; set; }
        [ForeignKey("InstituteType")]
        public int InstituteTypeId { get; set; }
        [ValidateNever]
        public InstituteType InstituteType { get; set; }
        [ValidateNever]
        public ProgramGroup ProgramGroup { get; set; }


    }
    [Index(nameof(FullName),nameof(ShortName), IsUnique = true)]
    public class AcademyClass : BaseDTO
    {
        //public int Id { get; set; }
        [ForeignKey("Program")]
        public int PrgId { get; set; }
         
        
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public int DurationYear { get; set; } = 1;
        [ForeignKey("Institute")]
        public int InsId { get; set; }
        //public string? DomainName { get; set; }
        //public string? IP { get; set; }
        [ForeignKey("InstituteBranch")]
        public int InsBranchId { get; set; }
        [ValidateNever]
        public Institute Institute { get; set; }
        [ValidateNever]
        public InsBranch InstituteBranch { get; set; }
        [ValidateNever]
        public Program1 Program { get; set; }
    }
    public class SubjectInfo : BaseDTO
    {
       // public int Id { get; set; }
        public string? FullName { get; set; }
        public string? ShortName { get; set; }
        public string? Code { get; set; }
        public bool IsMandatory { get; set; }
        public bool IsOptional { get; set; }
        [ForeignKey("EducationalGroup")]
        public int EducationalGroupId { get; set; }

        public EducationalGroup EducationalGroup { get; set; }
        [ForeignKey("Institute")]
        public int InsId { get; set; }
        [ForeignKey("InstituteBranch")]
        public int InsBranchId { get; set; }
        [ValidateNever]
        public Institute Institute { get; set; }
        [ValidateNever]
        public InsBranch InstituteBranch { get; set; }
    }
    public class EducationalGroup : BaseDTO
    {
       // public int Id { get; set; }
        //General,Science,Commerce,Arts/Humanities
        public string GroupName { get; set; }
        [ForeignKey("Institute")]
        public int InsId { get; set; }
        [ForeignKey("InstituteBranch")]
        public int InsBranchId { get; set; }
        [ValidateNever]
        public Institute Institute { get; set; }
        [ValidateNever]
        public InsBranch InstituteBranch { get; set; }
    }
    // This class represents the relationship between a class and its subjects, School.
    public class ClassSubjectInst : BaseDTO
    {
      //  public int Id { get; set; }
        [ForeignKey("AcademyClass")]
        public int ClassId { get; set; }
        [ForeignKey("SubjectInfo")]
        public int SubId { get; set; }
        [ForeignKey("Institute")]
        public int InsId { get; set; }
        [ForeignKey("InstituteBranch")]
        public int InsBranchId { get; set; }
        [ValidateNever]
        public Institute Institute { get; set; }
        [ValidateNever]
        public InsBranch InstituteBranch { get; set; }
        public SubjectInfo SubjectInfo { get; set; }
        public AcademyClass AcademyClass { get; set; }
    }

    public class Shift : BaseDTO
    {
        //public int Id { get; set; }
        public string ShiftName { get; set; }
        [DataType(DataType.Time)]
        public TimeSpan StartTime { get; set; }
        [DataType(DataType.Time)]
        public TimeSpan EndTime { get; set; }
        public string? Description { get; set; }
        [ForeignKey("Institute")]
        public int InsId { get; set; }
        [ForeignKey("InstituteBranch")]
        public int InsBranchId { get; set; }
        [ValidateNever]
        public Institute Institute { get; set; }
        [ValidateNever]
        public InsBranch InstituteBranch { get; set; }
    }
    public class ClassSection : BaseDTO
    {
        //public int Id { get; set; }
        public string SectionName { get; set; }
        public string? Description { get; set; }

        [ForeignKey("AcademyClass")]
        public int AcademyClassId { get; set; }

        [ForeignKey("Institute")]
        public int InsId { get; set; }
        [ForeignKey("InstituteBranch")]
        public int InsBranchId { get; set; }
        [ValidateNever]
        public Institute Institute { get; set; }
        [ValidateNever]
        public InsBranch InstituteBranch { get; set; }
        [ValidateNever ]
        public AcademyClass AcademyClass { get; set; }

    }
    public class Religion : BaseDTO
    {
       // public int ID { get; set; }
        public string ReligionName { get; set; }
        public string Description { get; set; }
    }


    //Class, Subject, Teacher, Institute, InstituteBranch
    //AssignTacher to Class and Subject
    public class ClassSubjecTeacherIns:BaseDTO
    {
       // public int ID { get; set; }
        [ForeignKey("AcademyClass")]
        public int ClassId { get; set; }

        [ForeignKey("SubjectInfo")]
        public int SubjectId { get; set; }
        [ForeignKey("Teacher")]
        public int TeacherId { get; set; }

        [ValidateNever]
        public SubjectInfo? SubjectInfo { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        [ValidateNever]
        public Teacher? Teacher { get; set; }
        [ForeignKey("Institute")]
        public int InsId { get; set; }
        [ForeignKey("InstituteBranch")]
        public int InsBranchId { get; set; }
        [ValidateNever]
        public Institute? Institute { get; set; }
        [ValidateNever]
        public InsBranch? InstituteBranch { get; set; }
        [ValidateNever]
        public AcademyClass AcademyClass { get; set; }
    }

    public class ShiftwiseClass : BaseDTO
    {
      //  public int Id { get; set; }
        [ForeignKey("AcademyClass")]
        public int ClassId { get; set; }
        [ForeignKey("Shift")]
        public int ShiftId { get; set; }
        [ForeignKey("Institute")]
        public int InsId { get; set; }
        [ForeignKey("InstituteBranch")]
        public int InsBranchId { get; set; }
        [ValidateNever]
        public Institute? Institute { get; set; }
        [ValidateNever]
        public InsBranch? InstituteBranch { get; set; }
        [ValidateNever]
        public Shift? Shift { get; set; }
        [ValidateNever]
        public AcademyClass? AcademyClass { get; set; }
    }
}
