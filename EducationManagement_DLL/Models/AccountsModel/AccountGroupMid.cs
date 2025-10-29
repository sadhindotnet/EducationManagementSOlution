using EducationManagement_DLL.Models;
using EducationManagement_DLL.Models.AccountsModel;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoyalAPI.Models.AccountModels
{
    public class AccountGroupMid:BaseDTO
    {
        //[Key]
        //public int MidGroupID { get; set; }
        [ForeignKey("AccountGroupTop")]
        public int TopGroupID { get; set; }
        public string? MidGroupCode { get; set; }
        [Required]
        public string MidGroupName { get; set; }= string.Empty;
        public int AccountTypeID { get; set; } = 1;
        [ForeignKey("Institute")]
        public int InsId { get; set; }
        [ForeignKey("InstituteBranch")]
        public int InsBranchId { get; set; }
        [ValidateNever]
        public Institute Institute { get; set; }
        [ValidateNever]
        public InsBranch InstituteBranch { get; set; }
        [ValidateNever]
        public AccountGroupTop AccountGroupTop { get; set; } = new AccountGroupTop();
    }
}
