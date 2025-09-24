using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models.IdentityModels;
using EducationManagement_DLL.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoyalAPI.Models.AccountModels;

namespace EducationManagementSOlution.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class RoleController : ControllerBase
   {
      private readonly IUnitOfWork _unitOfWork;
      private ModelMessage message;
      public RoleController(IUnitOfWork unitOfWork)
      {
         _unitOfWork = unitOfWork;
         message = new ModelMessage();
      }
      [HttpGet]
      public async Task<IEnumerable<Role>> Get()
      {
         try
         {
            return await _unitOfWork.RoleRepo.GetAll();
         }
         catch (Exception ex)
         {
            return Enumerable.Empty<Role>();
         }
      }
      [HttpGet("{id:int}")]
      public async Task<Role> Get(int id)
      {
         try
         {
            return await _unitOfWork.RoleRepo.GetById(id);
         }
         catch (Exception ex)
         {
            return new Role();
         }
      }
      [HttpPost]
      public async Task<ModelMessage> Post(Role entity)
      {
         try
         {
            await _unitOfWork.RoleRepo.Add(entity);
            message = _unitOfWork.Save();

         }
         catch (Exception ex)
         {
            message.IsSuccess = false;
            message.Message = ex.Message;
         }
         return message;
      }
      [HttpPut]
      public async Task<ModelMessage> Put(Role entity)
      {
         try
         {
            _unitOfWork.RoleRepo.Update(entity);
            message = _unitOfWork.Save();

         }
         catch (Exception ex)
         {
            message.IsSuccess = false;
            message.Message = ex.Message;
         }
         return message;
      }
      [HttpDelete]
      public async Task<ModelMessage> Delete(int id)
      {
         try
         {
            await _unitOfWork.RoleRepo.DeletebyID(id);
            message = _unitOfWork.Save();

         }
         catch (Exception ex)
         {
            message.IsSuccess = false;
            message.Message = ex.Message;
         }
         return message;
      }
   }
}
