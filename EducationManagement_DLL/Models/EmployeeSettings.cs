using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EducationManagement_DLL.Models
{
   
    public class AdministrativeDepartment : BaseDTO
    {
       /// <summary>
       /// public int ID { get; set; }
       /// </summary>

        [Display(Name = "Department")]
        public int DepartmentName { get; set; }
        //[ForeignKey("Module")]
        //public int ModuleId { get; set; }
        //public virtual Module Module { get; set; }



    }
 
    public class Designation : BaseDTO
    {
      //  public int Id { get; set; }
        public string DesigName { get; set; }
        public string Description { get; set; }
        [ForeignKey("Institute")]
        public int InsId { get; set; }
        [ForeignKey("InstituteBranch")]
        public int InsBranchId { get; set; }
        [ValidateNever]
        public Institute Institute { get; set; }
        [ValidateNever]
        public InsBranch InstituteBranch { get; set; }
        //[ForeignKey("Module")]
        //public int ModuleId { get; set; }
        //public virtual Module Module { get; set; }
    }
    public  class Employee:BaseDTO
    {
        // //public int Id { get; set; } 
        public string FullName { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhotoUrl { get; set; }
        public string NIDNumber { get; set; }
      
        [DataType(DataType.DateTime)]
        public DateTime DOB { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime JoinigDate { get; set; }
        [ForeignKey("Religion")]
        public int ReligionId { get; set; }
        public string BloodGroup { get; set; }
        public string PRESENTADDRESS { get; set; }
        public string PERMANENTADDRESS { get; set; }
        public string BirthRegistrationNo { get; set; }
          public string Mobile { get; set; }
        public string Nationality { get; set; }
        public Gender Gender { get; set; }
        public Religion Religion { get; set; }
        [ForeignKey("Designation")]
        public int DesignationID { get; set; }

        public Designation Designation { get; set; }
        [NotMapped]
        public int GroupID { get; set; }
        //EmployeesGroup EmployeesGroup { get; set; }  
        [NotMapped]
        public string GroupName { get; set; }
        //[ForeignKey("Module")]
        //public int ModuleId { get; set; }
        //public virtual Module Module { get; set; }
        [ForeignKey("Institute")]
        public int InsId { get; set; }
        [ForeignKey("InstituteBranch")]
        public int InsBranchId { get; set; }
        [ValidateNever]
        public Institute? Institute { get; set; }
        [ValidateNever]
        public InsBranch? InstituteBranch { get; set; }

    }
    public class Teacher :BaseDTO
    {
        [ForeignKey("Employee")]
        public int EmpId { get; set; }
        
      public Employee Employee { get; set; }
        //[ForeignKey("Institute")]
        //public int InsId { get; set; }
        //[ForeignKey("InstituteBranch")]
        //public int InsBranchId { get; set; }
        //[ValidateNever]
        //public Institute? Institute { get; set; }
        //[ValidateNever]
        //public InsBranch? InstituteBranch { get; set; }
        //[ForeignKey("Module")]
        //public int ModuleId { get; set; }
        //public virtual Module Module { get; set; }
    }
    public class EmployeesGroup : BaseDTO
    {
      //  public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //[ForeignKey("Module")]
        //public int ModuleId { get; set; }
        //public virtual Module Module { get; set; }
    }
    public class EmployeeWithGroup : BaseDTO
    {
       // public int ID { get; set; }
        [ForeignKey("EmployeesGroup")]
        public int GroupID { get; set; }
        [ForeignKey("Employee")]
        public int EmpID { get; set; }

        public EmployeesGroup EmployeesGroup { get; set; }

        public Employee Employee { get; set; }
        //[ForeignKey("Module")]
        //public int ModuleId { get; set; }
        //public virtual Module Module { get; set; }
    }

    public class Directors  :BaseDTO
    {
        [ForeignKey("Employee")]
        public int EmployeeID { get; set; }
       // public int ID { get; set; }
        
        [ForeignKey("AdministrativeDepartment")]
        public int DepartmentID { get; set; }

        public DateTime StartPeriod { get; set; }
        public DateTime EndPeriod { get; set; }
     
        public virtual AdministrativeDepartment? AdministrativeDepartment { get; set; }
        //[ForeignKey("Module")]
        //public int ModuleId { get; set; }
        //public virtual Module Module { get; set; }
        //[ForeignKey("Institute")]
        //public int InsId { get; set; }
        //[ForeignKey("InstituteBranch")]
        //public int InsBranchId { get; set; }
        //[ValidateNever]
        //public Institute? Institute { get; set; }
        //[ValidateNever]
        //public InsBranch? InstituteBranch { get; set; }
    }
    public class Staff  :BaseDTO
    {
        [ForeignKey("Employee")]
        public int EmployeeID { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public string Responsibilities { get; set; }
        [ForeignKey("Institute")]
        public int InsId { get; set; }
        [ForeignKey("InstituteBranch")]
        public int InsBranchId { get; set; }
        [ValidateNever]
        public Institute? Institute { get; set; }
        [ValidateNever]
        public InsBranch? InstituteBranch { get; set; }
    }
    public class EmployeeQualification:BaseDTO
    {
        
    }
    public class EmployeeExperience:BaseDTO
    {

    }
    public class EmployeesEducation : BaseDTO
    {
      //  public int Id { get; set; }
        [ForeignKey("Employee")]
        public int EmployeeID { get; set; }
        [ForeignKey("NationalCertificate")]
        public int NationalCertificateID { get; set; }
        [DataType(DataType.Date)]
        public DateTime AchievedDate { get; set; }

        public virtual Employee? Employee { get; set; }
        public virtual NationalCertificate NationalCertificate { get; set; }
        //[ForeignKey("Module")]
        //public int ModuleId { get; set; }
        //public virtual Module Module { get; set; }
    }
    public class EmployeesJobHistroy : BaseDTO
    {
       // public int Id { get; set; }
        [ForeignKey("Employee")]
        public int EmployeeID { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartPeriod { get; set; }
        [DataType(DataType.Date)]
        public DateTime EndPeriod { get; set; }
        public int EmployeeGradeID { get; set; }
        public virtual Employee? Employee { get; set; }
        public virtual NationalCertificate NationalCertificate { get; set; }
        //[ForeignKey("Module")]
        //public int ModuleId { get; set; }
        //public virtual Module Module { get; set; }
    }
    public class NationalCertificate : BaseDTO
    {
       // public int Id { get; set; }
        public string CertificateName { get; set; }//NID.Smartcard
        public string CertificateShortName { get; set; }
       
    }
    //public class Department:BaseDTO
    //{
    //    public string DepartmentName { get; set; }
    //    public string? Description { get; set; }
    //    [ForeignKey("Institute")]
    //    public int InsId { get; set; }
    //    [ForeignKey("InstituteBranch")]
    //    public int InsBranchId { get; set; }
    //    [ValidateNever]
    //    public Institute? Institute { get; set; }
    //    [ValidateNever]
    //    public InsBranch? InstituteBranch { get; set; }

    //}
}
