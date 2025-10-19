using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationManagement_DLL.DTOs
{
   public class RegisterDTO
    {
        public string? UserID { get; set; }
        public string? Name { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? RolesName { get; set; }
        public string? Password { get; set; }
        public string? Url { get; set; } = "";
    }
}
