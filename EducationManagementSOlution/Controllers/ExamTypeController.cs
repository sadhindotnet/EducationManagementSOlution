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
   public class ExamTypeController : ControllerBase
   {
      private readonly IUnitOfWork _unitOfWork;
      private ModelMessage message;
      public ExamTypeController(IUnitOfWork unitOfWork)
      {
         _unitOfWork = unitOfWork;
         message = new ModelMessage();
      }
      [HttpGet]
      public async Task<IEnumerable<ExamType>> Get()
      {
         try
         {
            return await _unitOfWork.ExamTypeRepo.GetAll();
         }
         catch (Exception ex)
         {
            return Enumerable.Empty<ExamType>();
         }
      }
      [HttpGet("{id:int}")]
      public async Task<ExamType> Get(int id)
      {
         try
         {
            return await _unitOfWork.ExamTypeRepo.GetById(id);
         }
         catch (Exception ex)
         {
            return new ExamType();
         }
      }
      [HttpPost]
      public async Task<ModelMessage> Post(ExamType entity)
      {
         try
         {
            await _unitOfWork.ExamTypeRepo.Add(entity);
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
      public async Task<ModelMessage> Put(ExamType entity)
      {
         try
         {
            _unitOfWork.ExamTypeRepo.Update(entity);
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
            await _unitOfWork.ExamTypeRepo.DeletebyID(id);
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
