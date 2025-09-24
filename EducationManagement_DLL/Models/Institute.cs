using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
 
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationManagement_DLL.Models
{

    public class InstituteType : BaseDTO
    {
        //public int Id { get; set; }
        [Required]
        [StringLength(40)]
        [Display(Name = "Educational Institution")]
        public string TypeName { get; set; }//public,private,autonomous,or
                                            //School,college,university,Coaching
        public string TypeDescription { get; set; }
        [ValidateNever]
        public ICollection<Institute> Institutes { get; set; }
    }
    [Index(nameof(InstituteName), nameof(ShortName), IsUnique = true)]
    public class Institute : BaseDTO
    {
        
        //[Key]
        //public int Id { get; set; }
        [Required]
        [StringLength(120)]
        public string InstituteName { get; set; }
        [Required]
        [StringLength(8)]
        public string ShortName { get; set; }
        [Required]
        [StringLength(120)]
        public string ContactNumber { get; set; }
        public string AdminEmail { get; set; }

        public string AdminEmailPassword { get; set; }
        public string Address { get; set; }
        public string? LogoPath { get; set; }
        //[NotMapped]
        //public IFormFile LogoImage { get; set; }
        public string? BannerPath { get; set; }
        //[NotMapped]
        //public IFormFile BannerImage { get; set; }
         



        [ForeignKey("InstituteType")]
        public int InstituteTypeId { get; set; }

        public Ownership Ownership { get; set; }

        [ValidateNever]
        public InstituteType InstituteType { get; set; }
        //public ICollection<TopMenu> TopMenus { get; set; }
    }

    public class InsBranch : BaseDTO
    {
        //public int Id { get; set; }
        public string BranchName { get; set; }
        public string BranchShortName { get; set; }
        public string ConatcNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public bool IsMainbranch { get; set; }//only one branch can be main branch of an institute
        [ForeignKey("Institute")]
        public int InsId { get; set; }
        public GenderType GenderType { get; set; }


        [ValidateNever]
        public Institute Institute { get; set; }
    }
}
