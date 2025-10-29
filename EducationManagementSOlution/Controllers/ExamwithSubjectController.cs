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
   public class ExamwithSubjectController : ControllerBase
   {
      private readonly IUnitOfWork _unitOfWork;
      private ModelMessage message;
      public ExamwithSubjectController(IUnitOfWork unitOfWork)
      {
         _unitOfWork = unitOfWork;
         message = new ModelMessage();
      }
      [HttpGet]
      public async Task<IEnumerable<ExamwithSubject>> Get()
      {
         try
         {
            return await _unitOfWork.ExamwithSubjectRepo.GetAll();
         }
         catch (Exception ex)
         {
            return Enumerable.Empty<ExamwithSubject>();
         }
      }
      [HttpGet("{id:int}")]
      public async Task<ExamwithSubject> Get(int id)
      {
         try
         {
            return await _unitOfWork.ExamwithSubjectRepo.GetById(id);
         }
         catch (Exception ex)
         {
            return new ExamwithSubject();
         }
      }
      [HttpPost]
      public async Task<ModelMessage> Post(ExamwithSubject entity)
      {
         try
         {
            await _unitOfWork.ExamwithSubjectRepo.Add(entity);
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
      public async Task<ModelMessage> Put(ExamwithSubject entity)
      {
         try
         {
            _unitOfWork.ExamwithSubjectRepo.Update(entity);
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
            await _unitOfWork.ExamwithSubjectRepo.DeletebyID(id);
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
