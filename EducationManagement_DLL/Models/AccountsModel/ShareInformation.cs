using System.ComponentModel.DataAnnotations;

namespace EducationManagement_DLL.Models.AccountsModel
{ 
    public class ShareHolderInformation:BaseDTO
    {
        //[Key]
        //public int ShareID { get; set; }
        public string ShareHolderName { get; set; } = string.Empty;

        public decimal? ShareValue { get; set; }
        public int NoOfShare { get; set; }
        public decimal? TotalAmount { get; set; }
        public string IsActive { get; set; } = string.Empty;    
        public string InActiveDate { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; } = string.Empty;
        public int SchoolID { get; set; }
    }
}
