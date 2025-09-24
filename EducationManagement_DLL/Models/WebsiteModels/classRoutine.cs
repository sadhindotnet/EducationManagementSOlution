using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducationManagement_DLL.Models.WebsiteModels
{
    public class ClassRoutine:BaseDTO
    {
       
        [Required]
        [ForeignKey("AcademyClass")]
        public int ClassId { get; set; }
        [Required]
        [DisplayName("Day Of Week")]
        [StringLength(12)]
        public string DayOfWeek { get; set; }
        [DisplayName("Start Time")]
        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }
        [DisplayName("End Time")]
        [DataType(DataType.Time)]
        public DateTime EndTime { get; set; }
        [ForeignKey("Room")]
        public int RoomId { get; set; }
        [ForeignKey("Subject")]
        public int SubjectId { get; set; }
        public string? DomainName { get; set; }
        public string? IP { get; set; }
        [ValidateNever]
        public AcademyClass AcademyClass { get; set; }
        [ValidateNever]
        public Room Room { get; set; }
        [ValidateNever]
        public SubjectInfo Subject { get; set; }
        [ForeignKey("Institute")]
        public int InsId { get; set; }
        [ForeignKey("InstituteBranch")]
        public int InsBranchId { get; set; }
        [ValidateNever]
        public Institute? Institute { get; set; }
        [ValidateNever]
        public InsBranch? InstituteBranch { get; set; }
    }
}
