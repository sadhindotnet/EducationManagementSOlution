using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using RoyalAPI.Models.AccountModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationManagement_DLL.Models
{
    public class StdInvoice : BaseDTO
    {

        //public int ID { get; set; }
        public string? InvoiceNo { get; set; }
        public DateTime InvoiceDate { get; set; } = DateTime.Now;
        public string? StudentID { get; set; }
        [ForeignKey("StudentBasicInfo")]
        public int StdID { get; set; }
        [ForeignKey("AcademyClass")]
        public int ClassId { get; set; }
        public AcademyClass AcademyClass { get; set; } = new AcademyClass();
        [ForeignKey("AccountChart")]
        public int AccountChartId { get; set; }//join with Classwisefee 

        public AccountChart AccountChart { get; set; } = new AccountChart();
        [ForeignKey("Institute")]
        public int? InstituteID { get; set; } = 1;
        [ForeignKey("InstituteBranch")]
        public int BranchID { get; set; } = 1;
        [ValidateNever]
        public InsBranch? InstituteBranch { get; set; }
        [ValidateNever]
        public virtual Institute? Institute { get; set; }

        public decimal Amount { get; set; }
        public DateTime PaymentDueDate { get; set; }
        // check late fee when generate Invoice
        // public decimal LateFee { get; set; } = 0; 
        // Late fee applied if payment is overdue
    
    }
    public class StdPayment : BaseDTO
    {
       // public int ID { get; set; }
        public string? StudentID { get; set; }
        public int StdID { get; set; }
        [ForeignKey("StdInvoice")]
        public int InvoiceId { get; set; } // Foreign key to StdInvoice
        public PaymentMethodType? MethodType { get; set; } = PaymentMethodType.Cash; // e.g., Tuition, Exam,absent etc.
        public decimal TotalAmount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string? PaymentStatus { get; set; } // e.g., Paid, Pending, Overdue
        public string? TransactionId { get; set; } // For tracking payment transactions
        public StdInvoice StdInvoice { get; set; } = new StdInvoice();
        [ForeignKey("Institute")]
        public int? InstituteID { get; set; } = 1;
        [ForeignKey("InstituteBranch")]
        public int BranchID { get; set; } = 1;
        [ValidateNever]
        public InsBranch? InstituteBranch { get; set; }
        [ValidateNever]
        public virtual Institute? Institute { get; set; }
    }
    //public class StdPaymentHistory : BaseDTO
    //{
    //    public int ID { get; set; }
    //    public int StdPaymentId { get; set; } // Foreign key to StdPayment
    //    public DateTime PaymentDate { get; set; }
    //    public decimal Amount { get; set; }
    //    public string? PaymentStatus { get; set; } // e.g., Paid, Pending, Overdue
    //    public string? Remarks { get; set; } // Additional notes or remarks about the payment
    //}
    //public class StdPaymentSummary : BaseDTO
    //{
    //    public int ID { get; set; }
    //    public int StdID { get; set; } // Foreign key to Student
    //    public decimal TotalPaid { get; set; }
    //    public decimal TotalDue { get; set; }
    //    public DateTime LastPaymentDate { get; set; }
    //    public string? PaymentStatus { get; set; } // e.g., All Paid, Some Due, etc.
    //}
    //public class StdPaymentReport : BaseDTO
    //{
    //    public int ID { get; set; }
    //    public int StdID { get; set; } // Foreign key to Student
    //    public string? ReportPeriod { get; set; } // e.g., Monthly, Quarterly, Yearly
    //    public decimal TotalPayments { get; set; }
    //    public decimal TotalDues { get; set; }
    //    public List<StdPayment> Payments { get; set; } // List of payments made during the report period
    //}
   
    public class StdPaymentSettings : BaseDTO
    {
      //  public int ID { get; set; }
        //public string PaymentMethod { get; set; } // e.g., Cash, Bank Transfer, Online Payment
        //public string Currency { get; set; } // e.g., USD, BDT
        public decimal LateFeePercentage { get; set; } // Percentage of late fee applied to overdue payments
        public decimal LateFeeAmount { get; set; }
        public int DueDuration { get; set; } // Late fee applicable after this many days/months of non-payment
        public string? Remarks { get; set; } // Additional notes or remarks about payment settings
        [ForeignKey("Institute")]
        public int? InstituteID { get; set; } = 1;
        [ForeignKey("InstituteBranch")]
        public int BranchID { get; set; } = 1;
        [ValidateNever]
        public InsBranch InstituteBranch { get; set; }
        [ValidateNever]
        public virtual Institute Institute { get; set; }

    }
   
    //public class StdPaymentConfiguration : BaseDTO
    //{
    //    public int ID { get; set; }
    //    public string ConfigurationName { get; set; } // e.g., Standard Payment Terms
    //    public string ConfigurationValue { get; set; } // e.g., "Due within 30 days"
    //    public string? Description { get; set; } // Additional description of the configuration
    //}
    public class  PaymentMethod : BaseDTO
    {
       // public int ID { get; set; }
        public PaymentMethodType? MethodType { get; set; } = PaymentMethodType.Cash;// e.g., Cash, Bank Transfer, Online Payment
        public string? Description { get; set; } // Additional description of the payment method
       
    }

        
        

}
