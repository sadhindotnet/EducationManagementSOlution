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
   public class LoginModelController : ControllerBase
   {
      private readonly IUnitOfWork _unitOfWork;
      private ModelMessage message;
      public LoginModelController(IUnitOfWork unitOfWork)
      {
         _unitOfWork = unitOfWork;
         message = new ModelMessage();
      }
      [HttpGet]
      public async Task<IEnumerable<LoginModel>> Get()
      {
         try
         {
            return await _unitOfWork.LoginModelRepo.GetAll();
         }
         catch (Exception ex)
         {
            return Enumerable.Empty<LoginModel>();
         }
      }
      [HttpGet("{id:int}")]
      public async Task<LoginModel> Get(int id)
      {
         try
         {
            return await _unitOfWork.LoginModelRepo.GetById(id);
         }
         catch (Exception ex)
         {
            return new LoginModel();
         }
      }
      [HttpPost]
      public async Task<ModelMessage> Post(LoginModel entity)
      {
         try
         {
            await _unitOfWork.LoginModelRepo.Add(entity);
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
      public async Task<ModelMessage> Put(LoginModel entity)
      {
         try
         {
            _unitOfWork.LoginModelRepo.Update(entity);
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
            await _unitOfWork.LoginModelRepo.DeletebyID(id);
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
