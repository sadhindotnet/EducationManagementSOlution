using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationManagementSOlution.Security
{
   public class AuthenticatedResponse
    {
        public string? Token { get; set; }
        public string? RefreshToken { get; set; }
        public string? Role { get; set; }
        public string? UserName { get; set; }
        public int? InstituteId { get; set; }
        public int? InstituteBranchId { get; set; }
        public string? InstituteName { get; set; }
        public string? InstituteShortName { get; set; }
        public string? InstituteBranchName { get; set; }
        public string? PictureUrl { get; set; }

    }
}
