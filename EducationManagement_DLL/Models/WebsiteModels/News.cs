using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducationManagement_DLL.Models.WebsiteModels
{
    public class News:BaseDTO
    {
         
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        [MaxLength(3000)]
        public string Description { get; set; }
        [DisplayName("Start Date")]
        public DateTime startDate { get; set; }
        [DisplayName("End Date")]
        public DateTime EndDate { get; set; }

        public string? DomainName { get; set; }
        public string? IP { get; set; }
        [ValidateNever]
        public string? Images { get; set; }
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
