using EducationManagement_DLL.Context;
using EducationManagement_DLL.DTOs;
using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models.IdentityModels;
using EducationManagement_DLL.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EducationManagementSOlution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public UserController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<ApplicationUser>> Get()
        {
            try
            {
                //return await _unitOfWork.UserRepo.GetAll();
                return await _unitOfWork.UserRepo.GetUsers();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<ApplicationUser>();
            }
        }
        //[HttpGet("{id:int}")]
        //public async Task<Role> Get(int id)
        //{
        //    try
        //    {
        //        return await _unitOfWork.RoleRepo.GetById(id);
        //    }
        //    catch (Exception ex)
        //    {
        //        return new Role();
        //    }
        //}
        [HttpPost]
        public async Task<ModelMessage> Post(RegisterDTO entity)
        {
            try
            {
               message= await _unitOfWork.UserRepo.CreateUser(entity);
                //message = _unitOfWork.Save();

            }
            catch (Exception ex)
            {
                message.IsSuccess = false;
                message.Message = ex.Message;
            }
            return message;
        }
        //[HttpPut]
        //public async Task<ModelMessage> Put(Role entity)
        //{
        //    try
        //    {
        //        _unitOfWork.RoleRepo.Update(entity);
        //        message = _unitOfWork.Save();

        //    }
        //    catch (Exception ex)
        //    {
        //        message.IsSuccess = false;
        //        message.Message = ex.Message;
        //    }
        //    return message;
        //}
        //[HttpDelete]
        //public async Task<ModelMessage> Delete(int id)
        //{
        //    try
        //    {
        //        await _unitOfWork.RoleRepo.DeletebyID(id);
        //        message = _unitOfWork.Save();

        //    }
        //    catch (Exception ex)
        //    {
        //        message.IsSuccess = false;
        //        message.Message = ex.Message;
        //    }
        //    return message;
        //}
    }
}
