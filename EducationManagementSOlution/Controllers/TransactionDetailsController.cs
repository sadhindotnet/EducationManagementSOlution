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
   public class TransactionDetailsController : ControllerBase
   {
      private readonly IUnitOfWork _unitOfWork;
      private ModelMessage message;
      public TransactionDetailsController(IUnitOfWork unitOfWork)
      {
         _unitOfWork = unitOfWork;
         message = new ModelMessage();
      }
      [HttpGet]
      public async Task<IEnumerable<TransactionDetails>> Get()
      {
         try
         {
            return await _unitOfWork.TransactionDetailsRepo.GetAll();
         }
         catch (Exception ex)
         {
            return Enumerable.Empty<TransactionDetails>();
         }
      }
      [HttpGet("{id:int}")]
      public async Task<TransactionDetails> Get(int id)
      {
         try
         {
            return await _unitOfWork.TransactionDetailsRepo.GetById(id);
         }
         catch (Exception ex)
         {
            return new TransactionDetails();
         }
      }
      [HttpPost]
      public async Task<ModelMessage> Post(TransactionDetails entity)
      {
         try
         {
            await _unitOfWork.TransactionDetailsRepo.Add(entity);
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
      public async Task<ModelMessage> Put(TransactionDetails entity)
      {
         try
         {
            _unitOfWork.TransactionDetailsRepo.Update(entity);
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
            await _unitOfWork.TransactionDetailsRepo.DeletebyID(id);
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
