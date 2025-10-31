using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoyalAPI.Models.AccountModels;

namespace EducationManagementSOlution.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class AccountGroupLowerController : ControllerBase
   {
      private readonly IUnitOfWork _unitOfWork;
      private ModelMessage message;
      public AccountGroupLowerController(IUnitOfWork unitOfWork)
      {
         _unitOfWork = unitOfWork;
         message = new ModelMessage();
      }
      [HttpGet]
      public async Task<IEnumerable<AccountGroupLower>> Get()
      {
         try
         {
            return await _unitOfWork.AccountGroupLowerRepo.GetAll();
         }
         catch (Exception ex)
         {
            return Enumerable.Empty<AccountGroupLower>();
         }
      }
      [HttpGet("{id:int}")]
      public async Task<AccountGroupLower> Get(int id)
      {
         try
         {
            return await _unitOfWork.AccountGroupLowerRepo.GetById(id);
         }
         catch (Exception ex)
         {
            return new AccountGroupLower();
         }
      }
      [HttpPost]
      public async Task<ModelMessage> Post(AccountGroupLower entity)
      {
         try
         {
            await _unitOfWork.AccountGroupLowerRepo.Add(entity);
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
      public async Task<ModelMessage> Put(AccountGroupLower entity)
      {
         try
         {
            _unitOfWork.AccountGroupLowerRepo.Update(entity);
            message = _unitOfWork.Save();

         }
         catch (Exception ex)
         {
            message.IsSuccess = false;
            message.Message = ex.Message;
         }
         return message;
      }
      [HttpDelete("{id}")]
      public async Task<ModelMessage> Delete(int id)
      {
         try
         {
            await _unitOfWork.AccountGroupLowerRepo.DeletebyID(id);
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
