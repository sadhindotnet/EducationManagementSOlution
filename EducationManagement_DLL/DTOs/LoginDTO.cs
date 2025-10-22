using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationManagement_DLL.DTOs
{
  public  class LoginDTO
    {
        public string? UserName { get; set; }
        //public string RolesName { get; set; }
        public string? Password { get; set; }
        public string? Hash { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
    }
}
