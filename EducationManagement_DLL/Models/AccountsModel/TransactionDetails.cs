using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducationManagement_DLL.Models.AccountsModel
{
    public class TransactionDetails:BaseDTO
    {
        // public int TransactionDetailsID { get; set; }
        [ForeignKey("TransactionMaster")]
        public int TransactionMasterID { get; set; }
        public DateTime VoucherDate { get; set; }
        public string? VoucherNo { get; set; }
        public int VoucherTypeID { get; set; }
        public int AccountID { get; set; }
        //public decimal? Amount { get; set; }
        public decimal? DebitAmount { get; set; }
        public decimal? CreditAmount { get; set; }

        public int? RefAccountID { get; set; }
        [ForeignKey("Institute")]
        public int InsId { get; set; }
        [ForeignKey("InstituteBranch")]
        public int InsBranchId { get; set; }
        [ValidateNever]
        public Institute Institute { get; set; }
        [ValidateNever]
        public InsBranch InstituteBranch { get; set; }
        [ValidateNever]
        public TransactionMaster? TransactionMaster { get; set; }

    }
}
