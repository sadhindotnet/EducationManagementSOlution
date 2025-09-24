using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducationManagement_DLL.Models.AccountsModel
{
    public class AccountGroupTop: BaseDTO
    {
        //[Key]
        //public int TopGroupID { get; set; }
        public string? TopGroupCode { get; set; }
        [Required]
        public string TopGroupName { get; set; } = string.Empty;    
        public int AccountTypeID { get; set; }
        [ForeignKey("Institute")]
        public int InsId { get; set; }
        [ForeignKey("InstituteBranch")]
        public int InsBranchId { get; set; }
        [ValidateNever]
        public Institute Institute { get; set; }
        [ValidateNever]
        public InsBranch InstituteBranch { get; set; }
    }
}
