using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationManagement_DLL.Models
{
    
    #region enum
    public enum GenderType { Boys = 1, Girls, Both }
    public enum Ownership { Government = 1, Public, Private }
    public enum Gender
    {
        Male = 1, Female, ThirdGender
    }
    public enum Medium
    {
        BanglaVersion = 1, EnglishMedium, EnglishVersion
    }
    public enum PaymentMethodType
    {
        Cash = 1, Bank, MobileBanking, Cheque
    }
    #endregion

}
