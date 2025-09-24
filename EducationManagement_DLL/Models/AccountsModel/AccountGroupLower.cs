using EducationManagement_DLL.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoyalAPI.Models.AccountModels
{
    public class AccountGroupLower:BaseDTO
    {
        //[Key]
        //public int LowergroupID { get; set; }
        [ForeignKey("AccountGroupMid")]
        public int MidGroupID { get; set; }
        public string? LowerGroupCode { get; set; }
        [Required]
        public string LowerGroupName { get; set; } = string.Empty;
        public int AccountTypeID { get; set; }
        [ForeignKey("Institute")]
        public int InsId { get; set; }
        [ForeignKey("InstituteBranch")]
        public int InsBranchId { get; set; }
        [ValidateNever]
        public Institute Institute { get; set; }
        [ValidateNever]
        public InsBranch InstituteBranch { get; set; }
        [ValidateNever]
        public AccountGroupMid AccountGroupMid { get; set; } = new AccountGroupMid();
    }
}
