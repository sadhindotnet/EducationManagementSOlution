using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoyalAPI.Models.AccountModels;

namespace EducationManagementSOlution.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class InstituteChartAcctController : ControllerBase
   {
      private readonly IUnitOfWork _unitOfWork;
      private ModelMessage message;
      public InstituteChartAcctController(IUnitOfWork unitOfWork)
      {
         _unitOfWork = unitOfWork;
         message = new ModelMessage();
      }
      [HttpGet]
      public async Task<IEnumerable<InstituteChartAcct>> Get()
      {
         try
         {
            return await _unitOfWork.InstituteChartAcctRepo.GetAll();
         }
         catch (Exception ex)
         {
            return Enumerable.Empty<InstituteChartAcct>();
         }
      }
      [HttpGet("{id:int}")]
      public async Task<InstituteChartAcct> Get(int id)
      {
         try
         {
            return await _unitOfWork.InstituteChartAcctRepo.GetById(id);
         }
         catch (Exception ex)
         {
            return new InstituteChartAcct();
         }
      }
      [HttpPost]
      public async Task<ModelMessage> Post(InstituteChartAcct entity)
      {
         try
         {
            await _unitOfWork.InstituteChartAcctRepo.Add(entity);
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
      public async Task<ModelMessage> Put(InstituteChartAcct entity)
      {
         try
         {
            _unitOfWork.InstituteChartAcctRepo.Update(entity);
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
            await _unitOfWork.InstituteChartAcctRepo.DeletebyID(id);
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
