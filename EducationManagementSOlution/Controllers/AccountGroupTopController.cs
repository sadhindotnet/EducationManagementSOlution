using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models.AccountsModel;
using EducationManagement_DLL.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoyalAPI.Models.AccountModels;

namespace EducationManagementSOlution.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class AccountGroupTopController : ControllerBase
   {
      private readonly IUnitOfWork _unitOfWork;
      private ModelMessage message;
      public AccountGroupTopController (IUnitOfWork unitOfWork)
      {
         _unitOfWork = unitOfWork;
         message = new ModelMessage();
      }
      [HttpGet]
      public async Task<IEnumerable<AccountGroupTop>> Get()
      {
         try
         {
            return await _unitOfWork.AccountGroupTopRepo.GetAll();
         }
         catch (Exception ex)
         {
            return Enumerable.Empty<AccountGroupTop>();
         }
      }
      [HttpGet("{id:int}")]
      public async Task<AccountGroupTop> Get(int id)
      {
         try
         {
            return await _unitOfWork.AccountGroupTopRepo.GetById(id);
         }
         catch (Exception ex)
         {
            return new AccountGroupTop();
         }
      }
      [HttpPost]
      public async Task<ModelMessage> Post(AccountGroupTop entity)
      {
         try
         {
            await _unitOfWork.AccountGroupTopRepo.Add(entity);
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
      public async Task<ModelMessage> Put(AccountGroupTop entity)
      {
         try
         {
            _unitOfWork.AccountGroupTopRepo.Update(entity);
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
            await _unitOfWork.AccountGroupTopRepo.DeletebyID(id);
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
