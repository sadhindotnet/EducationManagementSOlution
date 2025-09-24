using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoyalAPI.Models.AccountModels;

namespace EducationManagementSOlution.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class AccountGroupMidController : ControllerBase
   {
      private readonly IUnitOfWork _unitOfWork;
      private ModelMessage message;
      public AccountGroupMidController(IUnitOfWork unitOfWork)
      {
         _unitOfWork = unitOfWork;
         message = new ModelMessage();
      }
      [HttpGet]
      public async Task<IEnumerable<AccountGroupMid>> Get()
      {
         try
         {
            return await _unitOfWork.AccountGroupMidRepo.GetAll();
         }
         catch (Exception ex)
         {
            return Enumerable.Empty<AccountGroupMid>();
         }
      }
      [HttpGet("{id:int}")]
      public async Task<AccountGroupMid> Get(int id)
      {
         try
         {
            return await _unitOfWork.AccountGroupMidRepo.GetById(id);
         }
         catch (Exception ex)
         {
            return new AccountGroupMid();
         }
      }
      [HttpPost]
      public async Task<ModelMessage> Post(AccountGroupMid entity)
      {
         try
         {
            await _unitOfWork.AccountGroupMidRepo.Add(entity);
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
      public async Task<ModelMessage> Put(AccountGroupMid entity)
      {
         try
         {
            _unitOfWork.AccountGroupMidRepo.Update(entity);
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
            await _unitOfWork.AccountGroupMidRepo.DeletebyID(id);
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
