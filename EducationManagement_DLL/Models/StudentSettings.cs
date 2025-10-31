using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EducationManagement_DLL.Models
{
 

    public class StudentBasicInfo : BaseDTO
    {
       // 200481
     // 200062
      //  public int ID { get; set; }
        //Auto generated

        public string? StudentID { get; set; }
        //public int StdID { get; set; }

        [DisplayName("Student Name")]
        public string StudentName { get; set; }
        public string StudentFatherName { get; set; }

        public string? studentFathersProfession { get; set; }

        public string? StudentFathersNID { get; set; }
        public string StudentFathersContract { get; set; }

        public string? StudentMotherName { get; set; }

        public string? StudentMothersProfession { get; set; }

        public string? StudentMothersNID { get; set; }

        public string? StudentMothersContract { get; set; }
        public string StudentEmail { get; set; }
        public string StudentContract { get; set; }

        public string? StudentEmargencyContract { get; set; }
        public DateTime StudentDOB { get; set; }

        public string? StudentBirthRegNo { get; set; }

        public string? StudentNID { get; set; }

        public string? StudentMarritalStatus { get; set; } = "Unmarried";
        public string StudentPresentAddress { get; set; }

        public string StudentPermanentAdress { get; set; }
        [ValidateNever]
        public string? StudentNationality { get; set; }
        [ForeignKey("Religion")]
        public int? ReligionId { get; set; }
        [ValidateNever]
        public string? StudentBloodGroup { get; set; }
        public Gender StudentGender { get; set; }

        public string? StudentLocalGurdian { get; set; }


        public string? StudentLocalGurdianAddress { get; set; }

        public string? StudentLocalGurdianContact { get; set; }

        public string? StudentPicturePath { get; set; }
        [NotMapped]
        [ValidateNever]
        public IFormFile StudentPicture { get; set; }
        //Inactive=0,
        //    Active=1
        public int StudentStatus { get; set; } = 1;
        public string GenerateStdID(int sid, string year, string insName)
        {
            //string std = $"{insName}-{year.Substring(2, 2)}{sid}";
            string std = $"{insName}-{year.Substring(2, 2)}{sid.ToString().PadLeft(4, '0')}";

            return std;
        }

        
        [ValidateNever]
        public Religion Religion { get; set; }
        [ForeignKey("Institute")]
        public int? InstituteID { get; set; } = 1;
        [ForeignKey("InstituteBranch")]
        public int? BranchId { get; set; } = 1;
        //[ForeignKey("Module")]
        //public int? ModuleId { get; set; }
        //[ValidateNever]
        //public virtual Module Module { get; set; }
        [NotMapped]
        public string? InstituteName { get; set; }
        [ValidateNever]
        public virtual Institute Institute { get; set; }
        [ValidateNever]
        public virtual InsBranch InstituteBranch { get; set; }
    }

    public class StdtAcademicInfo : BaseDTO
    {
      //  public int ID { get; set; }
        //public string? Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime AdmissionDate { get; set; }
        [ForeignKey("InstituteBranch")]
        public int BranchID { get; set; } = 1;
        //public string Session { get; set; }
        [ForeignKey("SchoolSessions")]
        public int SessionId { get; set; }
        [ForeignKey("SchoolWiseClasses")]
        public int ClassID { get; set; }
        [ForeignKey("SchoolShifts")]
        public int ShiftID { get; set; }
        [ForeignKey("SchoolSections")]
        public int SectionID { get; set; }
        [ForeignKey("StudentBasicInfos")]
        public int StdID { get; set; }
        public string StudentID { get; set; }
        public long RollNo { get; set; }
       // public int Status { get; set; } = 1;
        public float Result { get; set; }//grade
        public Medium Medium { get; set; }
        [ValidateNever]
        public StudentBasicInfo StudentBasicInfos { get; set; }
        
        [ValidateNever]
        public ClassSubjecTeacherIns ClassSubjecTeacherIns { get; set; }
        
        [ValidateNever]
        public ClassSection ClassSection { get; set; }
        //public Shift Shift { get; set; }
        [ValidateNever]
        public Shift Shifts { get; set; }
        [ValidateNever]
        public AcademicSession? AcademicSession { get; set; }
        //[ForeignKey("Module")]
        //public int ModuleId { get; set; }
        //[ValidateNever]
        //public virtual Module Module { get; set; }
        [ForeignKey("Institute")]
        public int? InstituteID { get; set; } = 1;
        [ValidateNever]
        public InsBranch InstituteBranch { get; set; }
        [ValidateNever]
        public virtual Institute Institute { get; set; }
      

    }
 

  



}
