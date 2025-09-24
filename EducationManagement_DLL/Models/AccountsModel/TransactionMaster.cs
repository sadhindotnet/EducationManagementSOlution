using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducationManagement_DLL.Models.AccountsModel
{
    public class TransactionMaster:BaseDTO
    {
        //[Key]
        //public int TransactionMasterID { get; set; }
        public int UniqueID { get; set; }
        public DateTime VoucherDate { get; set; }
        public string? VoucherNo { get; set; }
        [ForeignKey("VoucherType")]
        public int VoucherTypeID { get; set; }

        public int? AccountID { get; set; }
        //public decimal? TotalAmount { get; set; }
        public decimal? TotalDebitAmount { get; set; }
        public decimal? TotalCreditAmount { get; set; }

        public int? CurrencyID { get; set; }

        public string? RefNo { get; set; }
        public string? ChequeNo { get; set; }
        public string? Remarks { get; set; }
        public string? ReceivedBy { get; set; }
        [ForeignKey("Institute")]
        public int InsId { get; set; }
        [ForeignKey("InstituteBranch")]
        public int InsBranchId { get; set; }
        [ValidateNever]
        public Institute Institute { get; set; }
        [ValidateNever]
        public InsBranch InstituteBranch { get; set; }
        [ValidateNever]
        public VoucherType? VoucherType { get; set; }

    }
}
