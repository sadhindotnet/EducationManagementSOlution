using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models;
using EducationManagement_DLL.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoyalAPI.Models.AccountModels;

namespace EducationManagementSOlution.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class AccountChartController : ControllerBase
   {
      private readonly IUnitOfWork _unitOfWork;
      private ModelMessage message;
      public AccountChartController(IUnitOfWork unitOfWork)
      {
         _unitOfWork = unitOfWork;
         message = new ModelMessage();
      }
      [HttpGet]
      public async Task<IEnumerable<AccountChart>> Get()
      {
         try
         {
            return await _unitOfWork.AccountChartRepo.GetAll();
         }
         catch (Exception ex)
         {
            return Enumerable.Empty<AccountChart>();
         }
      }
      [HttpGet("{id:int}")]
      public async Task<AccountChart> Get(int id)
      {
         try
         {
            return await _unitOfWork.AccountChartRepo.GetById(id);
         }
         catch (Exception ex)
         {
            return new AccountChart();
         }
      }
      [HttpPost]
      public async Task<ModelMessage> Post(AccountChart entity)
      {
         try
         {
            await _unitOfWork.AccountChartRepo.Add(entity);
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
      public async Task<ModelMessage> Put(AccountChart entity)
      {
         try
         {
            _unitOfWork.AccountChartRepo.Update(entity);
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
            await _unitOfWork.AccountChartRepo.DeletebyID(id);
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
