using EducationManagement_DLL.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoyalAPI.Models.AccountModels
{
    public class AccountChart:BaseDTO
    {
        //[Key]
        //public int AccountID { get; set; }
        [ForeignKey("AccountGroupLower")]
        public int LowergroupID { get; set; }
        public string? AccountCode { get; set; }
        [Required]
        public string AccountName { get; set; } = string.Empty;
        public int AccountTypeID { get; set; }
        public decimal? OpeningBalance { get; set; }
        //public DateTime? CreatedDate { get; set; }
        //public string? CreatedBy { get; set; }
        //  public int? SchoolID { get; set; }

        [ForeignKey("Institute")]
        public int InsId { get; set; }
        [ForeignKey("InstituteBranch")]
        public int InsBranchId { get; set; }
        [ValidateNever]
        public Institute Institute { get; set; }
        [ValidateNever]
        public InsBranch InstituteBranch { get; set; }
        [ValidateNever]
        public AccountGroupLower AccountGroupLower { get; set; } = new AccountGroupLower();
    }
    public class InstituteChartAcct:BaseDTO
    {
        [ForeignKey("AccountChart")]
        public int AccId { get; set; }
        
        public AccountChart AccountChart { get; set; } = new AccountChart();
        [ForeignKey("Institute")]
        public int? InstituteID { get; set; } = 1;
        [ForeignKey("InstituteBranch")]
        public int BranchID { get; set; } = 1;
        [ValidateNever]
        public InsBranch InstituteBranch { get; set; }
        [ValidateNever]
        public virtual Institute Institute { get; set; }

    }

}
