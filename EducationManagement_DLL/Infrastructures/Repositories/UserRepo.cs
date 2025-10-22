using EducationManagement_DLL.Context;
using EducationManagement_DLL.DTOs;
using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models.IdentityModels;
using EducationManagement_DLL.Models.WebsiteModels;
using EducationManagement_DLL.Security;
using EducationManagement_DLL.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace EducationManagement_DLL.Infrastructures.Repositories
{
 public interface IUserRepo
    {
      Task<ModelMessage> CreateUser(  RegisterDTO model);
        Task<IEnumerable<ApplicationUser>> GetUsers();
    }
    public  class UserRepo : IUserRepo
    {
        SchoolContext _context;
        private  UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private ModelMessage modelMessage;
        // private readonly ITokenService _tokenmanager;
        // private readonly IUnitOfWork unitOfWork;
        private readonly IServiceProvider _serviceProvider;

        private readonly SignInManager<ApplicationUser> _signInManager;
        public UserRepo(
            SchoolContext context,
                 IServiceProvider serviceProvider
            
        //UserManager<ApplicationUser> userManager,
        // RoleManager<IdentityRole> roleManager,
        //ITokenService tokenmanager,
        //IUnitOfWork work,

        //SignInManager<ApplicationUser> signInManager
            )   { 
            this._context = context;
            modelMessage = new ModelMessage();

            _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
            // this._userManager = userManager;
            // this._roleManager = roleManager;
            //  _tokenmanager = tokenmanager;
            //this.unitOfWork = work;

            //_signInManager = signInManager;

        }
       public async Task<IEnumerable<ApplicationUser>> GetUsers(){
            _userManager = _serviceProvider?.GetRequiredService<UserManager<ApplicationUser>>()
       ?? throw new InvalidOperationException("UserManager could not be resolved.");
            return _userManager.Users.AsEnumerable();
        }
        //Register user 
        public async Task<ModelMessage>  CreateUser([FromBody] RegisterDTO model)
        {
            using (var transaction = _context.Database.BeginTransaction())
            { 
                try
                {
                    _userManager = _serviceProvider?.GetRequiredService<UserManager<ApplicationUser>>()
    ?? throw new InvalidOperationException("UserManager could not be resolved.");

                    var isExist = await _userManager.FindByEmailAsync(model.Email);
                    if (isExist != null)
                    {
                       modelMessage.Message  =    "Email already exists, try a different one.";
                    }

                    var user = new ApplicationUser
                    {
                        UserName = model.Email,
                        Email = model.Email,
                        SecurityStamp = Guid.NewGuid().ToString(),
                        InstituteID = 5,
                        BranchID=3
                    };
                            var result = await _userManager.CreateAsync(user, model.Password);

                            if (result.Succeeded)
                            {
                                var roleResult = await _userManager.AddToRoleAsync(user, model.RolesName);

                                var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                                var encodedToken = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(token));
                                var pass = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(model.Password));
                                //var confirmationLink = Url.Action("ConfirmEmail", "Authenticate", new { userId = user.Id, token = encodedToken }, Request.Scheme);
                                //var confirmationLink = $"{model.Url}?userId={user.Id}&token={encodedToken}&roll={pass})";
                                //var emailData = new MailData
                                //{
                                //    EmailToId = model.Email,
                                //    EmailToName = model.Name,
                                //    EmailSubject = "Email Confirmation",
                                //    EmailBody = $"Please confirm your email by clicking this link: {confirmationLink}"
                                //};
                                //_mailService.SendMail(emailData);

                                transaction.Commit();
                        modelMessage.IsSuccess = true;
                        modelMessage.Message = "User created successfully!";
                        
                            }
                            else
                            {
                        if(result.Errors.Count()>0)
                        {
                            foreach (var er in result.Errors)
                            {
                               
                                modelMessage.Message = $"User creation failed for {er.Description}! ";
                            }
                        }
                                transaction.Rollback();
                        //return HandleUserErrors(result);
                      
                    }
                        
                   
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    modelMessage.Message = ex.InnerException?.Message ?? ex.Message;
                }
                return modelMessage;
            }
     
       
        }

        public async Task<string> Login( LoginDTO login)
        {
            string message = "";
            if (login == null)
            {
                message = "Invalid login request" );
            }
            try
            {
                // Decode the password hash if it exists
                if (!string.IsNullOrEmpty(login.Hash))
                {
                    login.Password = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(login.Hash));
                }

                // Check if the user exists
                var existUser = await _userManager.FindByNameAsync(login.UserName);
                if (existUser is null)
                {
                    message = "Invalid user name";
                }

                // Get user roles
                var roles = await _userManager.GetRolesAsync(existUser);
                var role = roles.FirstOrDefault();
                if (role == null)
                {
                    message = "User does not have a role assigned";
                }

                // Validate the password
                var isValidPassword = await _userManager.CheckPasswordAsync(existUser, login.Password);
                if (!isValidPassword)
                {
                    message = "Invalid  password";
                }

                // Generate claims for the token
            }
            catch(Exception ex)
            {
                message =ex.InnerException?.Message??ex.Message;
            }
        }

    }
}
