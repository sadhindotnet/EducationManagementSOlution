using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using RoyalAPI.Models.AccountModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationManagement_DLL.Models.AccountsModel
{
   public class ClassWiseFee : BaseDTO
    {
       // public int ID { get; set; }
        [ForeignKey("AcademyClass")]
        public int ClassID { get; set; } // Foreign key to Class
        public decimal Amount { get; set; }
        public AcademyClass AcademyClass { get; set; } = new AcademyClass();
        [ForeignKey("AccountChart")]
        public int AccountChartId { get; set; }//Tution fee, Admission fee, Exam fee etc.

        public AccountChart AccountChart { get; set; } = new AccountChart();
        [ForeignKey("Institute")]
        public int? InstituteID { get; set; } = 1;
        [ForeignKey("InstituteBranch")]
        public int BranchID { get; set; } = 1;
        [ValidateNever]
        public InsBranch? InstituteBranch { get; set; }
        [ValidateNever]
        public virtual Institute? Institute { get; set; }

    }
}
