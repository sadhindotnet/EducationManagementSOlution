using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducationManagement_DLL.Models.WebsiteModels
{
    public class AboutUs:BaseDTO
    {
        
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        [MaxLength(1024)]
        public string Description { get; set; }
        public string Photo { get; set; }
        public string? DomainName { get; set; }
        public string? IP { get; set; }
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
