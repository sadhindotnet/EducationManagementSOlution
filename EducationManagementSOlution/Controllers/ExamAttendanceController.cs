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
   public class ExamAttendanceController : ControllerBase
   {
      private readonly IUnitOfWork _unitOfWork;
      private ModelMessage message;
      public ExamAttendanceController(IUnitOfWork unitOfWork)
      {
         _unitOfWork = unitOfWork;
         message = new ModelMessage();
      }
      [HttpGet]
      public async Task<IEnumerable<ExamAttendance>> Get()
      {
         try
         {
            return await _unitOfWork.ExamAttendanceRepo.GetAll();
         }
         catch (Exception ex)
         {
            return Enumerable.Empty<ExamAttendance>();
         }
      }
      [HttpGet("{id:int}")]
      public async Task<ExamAttendance> Get(int id)
      {
         try
         {
            return await _unitOfWork.ExamAttendanceRepo.GetById(id);
         }
         catch (Exception ex)
         {
            return new ExamAttendance();
         }
      }
      [HttpPost]
      public async Task<ModelMessage> Post(ExamAttendance entity)
      {
         try
         {
            await _unitOfWork.ExamAttendanceRepo.Add(entity);
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
      public async Task<ModelMessage> Put(ExamAttendance entity)
      {
         try
         {
            _unitOfWork.ExamAttendanceRepo.Update(entity);
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
            await _unitOfWork.ExamAttendanceRepo.DeletebyID(id);
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
