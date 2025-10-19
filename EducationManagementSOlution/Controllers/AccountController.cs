using EducationManagement_DLL.Context;
using EducationManagement_DLL.Infrastructures.Base;
using EducationManagementSOlution.DTO_s;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace EducationManagementSOlution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IUnitOfWork unitOfWork;
        //private readonly ITokenService _tokenmanager;
        
        //private BloodMedihelpContext _context;
       
        //private readonly IMailService _mailService;

        public AccountController(
                                UserManager<ApplicationUser> userManager,
                                      RoleManager<IdentityRole> roleManager,
                                       SignInManager<ApplicationUser> signInManager,
                                         IUnitOfWork work
                                      //ITokenService tokenmanager,
                                    
                                      //BloodMedihelpContext context,
                                     
                                      //IMailService mailService
                                      )
        {
            this._userManager = userManager;
            this._roleManager = roleManager;
            this.unitOfWork = work;
            _signInManager = signInManager;
            //_tokenmanager = tokenmanager;
           
            //_context = context;
          
            //_mailService = mailService;

        }//constructor
 
        

    }

}
