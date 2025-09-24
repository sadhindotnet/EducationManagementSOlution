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
   public class ExamRoutineController : ControllerBase
   {
      private readonly IUnitOfWork _unitOfWork;
      private ModelMessage message;
      public ExamRoutineController(IUnitOfWork unitOfWork)
      {
         _unitOfWork = unitOfWork;
         message = new ModelMessage();
      }
      [HttpGet]
      public async Task<IEnumerable<ExamRoutine>> Get()
      {
         try
         {
            return await _unitOfWork.ExamRoutineRepo.GetAll();
         }
         catch (Exception ex)
         {
            return Enumerable.Empty<ExamRoutine>();
         }
      }
      [HttpGet("{id:int}")]
      public async Task<ExamRoutine> Get(int id)
      {
         try
         {
            return await _unitOfWork.ExamRoutineRepo.GetById(id);
         }
         catch (Exception ex)
         {
            return new ExamRoutine();
         }
      }
      [HttpPost]
      public async Task<ModelMessage> Post(ExamRoutine entity)
      {
         try
         {
            await _unitOfWork.ExamRoutineRepo.Add(entity);
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
      public async Task<ModelMessage> Put(ExamRoutine entity)
      {
         try
         {
            _unitOfWork.ExamRoutineRepo.Update(entity);
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
            await _unitOfWork.ExamRoutineRepo.DeletebyID(id);
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
