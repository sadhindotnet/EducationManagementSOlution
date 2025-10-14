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
   public class ExamTitleController : ControllerBase
   {
      private readonly IUnitOfWork _unitOfWork;
      private ModelMessage message;
      public ExamTitleController(IUnitOfWork unitOfWork)
      {
         _unitOfWork = unitOfWork;
         message = new ModelMessage();
      }
      [HttpGet]
      public async Task<IEnumerable<ExamTitle>> Get()
      {
         try
         {
            return await _unitOfWork.ExamTitleRepo.GetAll();
         }
         catch (Exception ex)
         {
            return Enumerable.Empty<ExamTitle>();
         }
      }
      [HttpGet("{id:int}")]
      public async Task<ExamTitle> Get(int id)
      {
         try
         {
            return await _unitOfWork.ExamTitleRepo.GetById(id);
         }
         catch (Exception ex)
         {
            return new ExamTitle();
         }
      }
      [HttpPost]
      public async Task<ModelMessage> Post(ExamTitle entity)
      {
         try
         {
            await _unitOfWork.ExamTitleRepo.Add(entity);
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
      public async Task<ModelMessage> Put(ExamTitle entity)
      {
         try
         {
            _unitOfWork.ExamTitleRepo.Update(entity);
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
            await _unitOfWork.ExamTitleRepo.DeletebyID(id);
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
