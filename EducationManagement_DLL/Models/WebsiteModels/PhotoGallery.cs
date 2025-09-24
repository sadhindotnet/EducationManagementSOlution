using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducationManagement_DLL.Models.WebsiteModels
{
    public class PhotoGallery:BaseDTO
    {
     
        [ForeignKey("Album")]
        public int AlbumId { get; set; }
        [StringLength(100)] 
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public string? DomainName { get; set; }
        public string? IP { get; set; }
        public Album Album { get; set; }
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
                