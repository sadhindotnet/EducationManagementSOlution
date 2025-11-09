using EducationManagement_DLL.Context;
using EducationManagement_DLL.DTOs;
using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models.IdentityModels;
using EducationManagementSOlution.Security;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Text;

namespace EducationManagementSOlution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUnitOfWork unitOfWork;
        private readonly ITokenService _tokenmanager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        // private SchoolContext _context;

        //private readonly IMailService _mailService;

        public AccountController(
                                UserManager<ApplicationUser> userManager,
                                     
                                         IUnitOfWork work, SignInManager<ApplicationUser> signInManager,
                                      ITokenService tokenmanager
                                      // SchoolContext _context
                                      //IMailService mailService
                                      )
        {
            this._userManager = userManager;
            _signInManager = signInManager;
            this.unitOfWork = work;
           
            _tokenmanager = tokenmanager;
          //  this._context = _context;
            //_mailService = mailService;

        }//constructor


        [HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("Login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginDTO loginVM)
        {
            if (loginVM == null)
            {
                return BadRequest(new { message = "Invalid login request" });


            }

            using (var transaction = this.unitOfWork.Context.Database.BeginTransaction())
            {
                try
            {
              

             
                var result =await this.unitOfWork.UserRepo.Login(loginVM) as LoggedUserDTO;
                if (result != null) { 
                // Generate claims for the token
                var claims = new List<Claim>
                        {   
                            new Claim(ClaimTypes.Name, loginVM.UserName ?? ""),
                            new Claim(ClaimTypes.Role, result.Role?? ""),
                              new Claim(ClaimTypes.Email, result.Email ?? "")
                            //new Claim("InsId", result.InstituteId.ToString()),
                            //new Claim("InsName", result.InstituteName ?? ""),
                            //new Claim("BrId", result.InstituteBranchId.ToString()),
                            //  new Claim("BrName", result.InstituteBranchName ?? "")
                           
                        };

                // Generate JWT access token and refresh token
                string accessToken = _tokenmanager.GenerateAccessToken(claims);
                var refreshToken = _tokenmanager.GenerateRefreshToken();

                // Handle token and refresh token storage
                var loggedUser = (await unitOfWork.LoginModelRepo.GetAll(L => L.UserName == loginVM.UserName, "")).FirstOrDefault();
                //var loggedUser = users.FirstOrDefault();

                if (loggedUser != null)
                {
                    loggedUser.RefreshToken = refreshToken;
                    loggedUser.RefreshTokenExpiryTime = DateTime.Now.AddMinutes(10);
                            
                    unitOfWork.LoginModelRepo.Update(loggedUser);
                }
                else
                {
                    var inuser = new LoginModel
                    {
                        RefreshToken = refreshToken,
                        RefreshTokenExpiryTime = DateTime.Now.AddMinutes(10),
                        UserName = loginVM.UserName,
                        LoggedTime = DateTime.Now

                    };
                    unitOfWork.LoginModelRepo.Add(inuser);
                }

                unitOfWork.Save();

              
                // Return the authenticated response with tokens
                if (!string.IsNullOrEmpty(accessToken))
                {
                    return Ok(new AuthenticatedResponse
                    {
                        Token = accessToken,
                        RefreshToken = refreshToken,
                        Role = result.Role,
                        UserName = result.UserName,
                        InstituteBranchName = result.InstituteBranchName,
                        InstituteBranchId = result.InstituteBranchId,
                        InstituteId = result.InstituteId,
                        InstituteName = result.InstituteName,
                    });
                }
                }
                transaction.Commit();
              
            }
            catch (Exception ex)
            {
                transaction.Rollback();
            return Unauthorized(new { msg = ex.Message });
            }
            }
            return Unauthorized(new { msg = "Invalid user name or password" });
        }
        [HttpPost("Logout")]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Ok(new { message = "User logged out successfully." });
        }

    }

}
