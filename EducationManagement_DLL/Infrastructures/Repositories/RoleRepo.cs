using EducationManagement_DLL.Context;
using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models.Exam_Models;
using EducationManagement_DLL.Models.IdentityModels;
using EducationManagement_DLL.Models.WebsiteModels;
using EducationManagement_DLL.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationManagement_DLL.Infrastructures.Repositories
{
    public interface IRole
    {
        Task<IEnumerable<Role>> GetRoles();
        Task<ModelMessage> Post(string rolename);
        Task<ModelMessage> Post();
    }
    public class RoleRepo : IRole
    {

        private readonly IServiceProvider _serviceProvider;

        private  RoleManager<Role> _roleManager;
        private ModelMessage modelMessage;

        //public RoleRepo(SchoolContext context, RoleManager<Role> roleManager) : base(context) {
        //    _roleManager = roleManager;
        //    modelMessage = new ModelMessage();
        //}
        public RoleRepo(IServiceProvider serviceProvider)
        {
           
            _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
            modelMessage = new ModelMessage();
        }
        public async Task<IEnumerable<Role>> GetRoles()
        {
             
            _roleManager = _serviceProvider?.GetRequiredService<RoleManager<Role>>()
   ?? throw new InvalidOperationException("RoleManager could not be resolved.");
            return _roleManager.Roles.ToList();
            //return Ok(model);
        }
       
        public async Task<ModelMessage> Post(string rolename)
        {
            IdentityResult roleResult = new IdentityResult();
            try
            {
                
                _roleManager = _serviceProvider?.GetRequiredService<RoleManager<Role>>()
    ?? throw new InvalidOperationException("RoleManager could not be resolved.");
                var roleExist = await _roleManager.RoleExistsAsync( rolename);
                if (!roleExist)
                {
                    
                    roleResult = await _roleManager.CreateAsync(new Role { Name=  rolename });
                }
                else
                {
                    modelMessage.IsSuccess = false;
                     
                }

                if (roleResult.Succeeded)
                {
                    modelMessage.IsSuccess = true;
                    modelMessage.Message = "Role created successfully";

                }
                else if (roleResult.Errors.Count() > 0)
                {
                    string msg = "";

                    foreach (var item in roleResult.Errors)
                    {
                        msg += item.Code + "-" + item.Description + ",";

                    }
                    msg = msg.Substring(0, msg.Length - 1);

                     modelMessage.Message = msg;
                    modelMessage.IsSuccess = false;
                }

                else
                {
                    modelMessage.Message = "Error occured";
                    modelMessage.IsSuccess = false;
                }
            }
            catch (Exception ex)
            {
                modelMessage.Message = ex.InnerException?.Message??ex.Message;
                modelMessage.IsSuccess = false;
            }
            return modelMessage;
        }
      
        public async Task<ModelMessage> Post()
        {
           
            string[] roleNames = { "Admin", "Super Admin", "Teacher", "Student", "Parent", "Vendor"  };
          
            IdentityResult roleResult = new IdentityResult();
            try
            {
                _roleManager = _serviceProvider?.GetRequiredService<RoleManager<Role>>()
        ?? throw new InvalidOperationException("RoleManager could not be resolved.");
                foreach (var roleName in roleNames)
                {
                    var roleExist = await _roleManager.RoleExistsAsync(roleName);
                    if (!roleExist)
                    {
                        //create the roles and seed them to the database: Question 1
                        roleResult = await _roleManager.CreateAsync(new Role { Name = roleName });
                    }
                }
                if (roleResult.Succeeded)
                {
                    modelMessage.Message = "Roles created successfully";
                }
                else if (roleResult.Errors.Count() > 0)
                {
                    modelMessage.IsSuccess = false;
                    foreach (var item in roleResult.Errors)
                    {
                        modelMessage.Message += item.Code + "-" + item.Description + ",";

                    }
                    modelMessage.Message = modelMessage.Message.Substring(0, modelMessage.Message.Length - 1);
                }

                else
                {
                    modelMessage.IsSuccess = false;
                    modelMessage.Message = "Error occured";
                }

            }
            catch (Exception ex)
            {
                modelMessage.IsSuccess = false;
                modelMessage.Message = ex.InnerException?.Message ?? ex.Message;
                
            }
            return modelMessage;    
        }


    }
}
