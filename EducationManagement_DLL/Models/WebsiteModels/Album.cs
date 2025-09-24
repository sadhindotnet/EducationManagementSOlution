using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducationManagement_DLL.Models.WebsiteModels
{
    public class Album:BaseDTO
    {
 
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        [MaxLength(1024)]
        public string Description { get; set; }
        [ForeignKey("MedaiCat")]
        public int MediaID { get; set; }

        public string? DomainName { get; set; }
        public string? IP { get; set; }
        [ValidateNever]
        public MediaCat MedaiCat { get; set; }

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
