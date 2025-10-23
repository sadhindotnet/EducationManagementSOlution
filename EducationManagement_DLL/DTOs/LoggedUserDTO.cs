using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationManagement_DLL.DTOs
{
 public   class LoggedUserDTO
    {
        public string? Role { get; set; }
        public string? UserId { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }

        public int InstituteId { get; set; }
        public int InstituteBranchId { get; set; }
        public string InstituteName { get; set; }
        public string InstituteBranchName { get; set; }
        public string PictureUrl { get; set; }

    }
}
