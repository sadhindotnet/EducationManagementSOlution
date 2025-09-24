using System.ComponentModel.DataAnnotations;

namespace EducationManagement_DLL.Models.AccountsModel
{
    public class VoucherType:BaseDTO
    {
        //[Key]
        //public int VoucherTypeID { get; set; }
        [Required]
        public string VoucharName { get; set; } = string.Empty;
        [Required]
        public string PrefixCode { get; set; }= string.Empty;
    }
}
