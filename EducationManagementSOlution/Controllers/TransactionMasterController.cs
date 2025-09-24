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
   public class TransactionMasterController : ControllerBase
   {
      private readonly IUnitOfWork _unitOfWork;
      private ModelMessage message;
      public TransactionMasterController(IUnitOfWork unitOfWork)
      {
         _unitOfWork = unitOfWork;
         message = new ModelMessage();
      }
      [HttpGet]
      public async Task<IEnumerable<TransactionMaster>> Get()
      {
         try
         {
            return await _unitOfWork.TransactionMasterRepo.GetAll();
         }
         catch (Exception ex)
         {
            return Enumerable.Empty<TransactionMaster>();
         }
      }
      [HttpGet("{id:int}")]
      public async Task<TransactionMaster> Get(int id)
      {
         try
         {
            return await _unitOfWork.TransactionMasterRepo.GetById(id);
         }
         catch (Exception ex)
         {
            return new TransactionMaster();
         }
      }
      [HttpPost]
      public async Task<ModelMessage> Post(TransactionMaster entity)
      {
         try
         {
            await _unitOfWork.TransactionMasterRepo.Add(entity);
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
      public async Task<ModelMessage> Put(TransactionMaster entity)
      {
         try
         {
            _unitOfWork.TransactionMasterRepo.Update(entity);
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
            await _unitOfWork.TransactionMasterRepo.DeletebyID(id);
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
