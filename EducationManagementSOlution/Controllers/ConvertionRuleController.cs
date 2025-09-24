using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models.Exam_Models;
using EducationManagement_DLL.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoyalAPI.Models.AccountModels;

namespace EducationManagementSOlution.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class ConvertionRuleController : ControllerBase
   {
      private readonly IUnitOfWork _unitOfWork;
      private ModelMessage message;
      public ConvertionRuleController(IUnitOfWork unitOfWork)
      {
         _unitOfWork = unitOfWork;
         message = new ModelMessage();
      }
      [HttpGet]
      public async Task<IEnumerable<ConvertionRule>> Get()
      {
         try
         {
            return await _unitOfWork.ConvertionRuleRepo.GetAll();
         }
         catch (Exception ex)
         {
            return Enumerable.Empty<ConvertionRule>();
         }
      }
      [HttpGet("{id:int}")]
      public async Task<ConvertionRule> Get(int id)
      {
         try
         {
            return await _unitOfWork.ConvertionRuleRepo.GetById(id);
         }
         catch (Exception ex)
         {
            return new ConvertionRule();
         }
      }
      [HttpPost]
      public async Task<ModelMessage> Post(ConvertionRule entity)
      {
         try
         {
            await _unitOfWork.ConvertionRuleRepo.Add(entity);
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
      public async Task<ModelMessage> Put(ConvertionRule entity)
      {
         try
         {
            _unitOfWork.ConvertionRuleRepo.Update(entity);
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
            await _unitOfWork.ConvertionRuleRepo.DeletebyID(id);
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
