using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducationManagement_DLL.Models.WebsiteModels
{
    public class Message:BaseDTO
    {
         
        [Required]
        [DisplayName("Message Body")]
        [StringLength(3024)]
        public string MessageBody { get; set; }
        [ForeignKey("Directors")]
        public int DirectorId { get; set; }

        public string? DomainName { get; set; }
        public string? IP { get; set; }
        [ValidateNever]
        public Directors Directors { get; set; }
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
