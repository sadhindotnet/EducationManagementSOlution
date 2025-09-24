using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducationManagement_DLL.Models.WebsiteModels
{
    public class BookList:BaseDTO
    {
        
        [ForeignKey("AcademyClass")]
        public int ClassID { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public string BookFile { get; set; }

        [ValidateNever]
        public AcademyClass AcademyClass { get; set; }
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
