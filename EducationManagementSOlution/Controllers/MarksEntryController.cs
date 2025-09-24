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
   public class MarksEntryController : ControllerBase
   {
      private readonly IUnitOfWork _unitOfWork;
      private ModelMessage message;
      public MarksEntryController(IUnitOfWork unitOfWork)
      {
         _unitOfWork = unitOfWork;
         message = new ModelMessage();
      }
      [HttpGet]
      public async Task<IEnumerable<MarksEntry>> Get()
      {
         try
         {
            return await _unitOfWork.MarksEntryRepo.GetAll();
         }
         catch (Exception ex)
         {
            return Enumerable.Empty<MarksEntry>();
         }
      }
      [HttpGet("{id:int}")]
      public async Task<MarksEntry> Get(int id)
      {
         try
         {
            return await _unitOfWork.MarksEntryRepo.GetById(id);
         }
         catch (Exception ex)
         {
            return new MarksEntry();
         }
      }
      [HttpPost]
      public async Task<ModelMessage> Post(MarksEntry entity)
      {
         try
         {
            await _unitOfWork.MarksEntryRepo.Add(entity);
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
      public async Task<ModelMessage> Put(MarksEntry entity)
      {
         try
         {
            _unitOfWork.MarksEntryRepo.Update(entity);
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
            await _unitOfWork.MarksEntryRepo.DeletebyID(id);
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
