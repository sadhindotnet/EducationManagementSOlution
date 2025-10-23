using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationManagement_DLL.Models.IdentityModels
{
 public   class LoginModel 
    
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        //public string? Password { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
        public DateTime? LoggedTime { get; set; }=DateTime.Now;
        public DateTime? LogoutTime { get; set; }

    }
}
