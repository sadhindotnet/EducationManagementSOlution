using EducationManagement_DLL.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducationManagement_DLL.Context
{
    public class ApplicationUser:IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FullName => $"{FirstName} {LastName}";
        public string? ProfilePicture { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; } = string.Empty;
        //public int SchoolID { get; set; }
        public bool IsActive { get; set; } = true;
        [ForeignKey("Institute")]
        public int? InstituteID { get; set; } = 1;
        [ForeignKey("InstituteBranch")]
        public int BranchID { get; set; } = 1;
        [ValidateNever]
        public InsBranch? InstituteBranch { get; set; }
        [ValidateNever]
        public virtual Institute? Institute { get; set; }

    }
}