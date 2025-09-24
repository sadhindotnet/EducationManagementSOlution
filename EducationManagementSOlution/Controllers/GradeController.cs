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
   public class GradeController : ControllerBase
   {
      private readonly IUnitOfWork _unitOfWork;
      private ModelMessage message;
      public GradeController(IUnitOfWork unitOfWork)
      {
         _unitOfWork = unitOfWork;
         message = new ModelMessage();
      }
      [HttpGet]
      public async Task<IEnumerable<Grade>> Get()
      {
         try
         {
            return await _unitOfWork.GradeRepo.GetAll();
         }
         catch (Exception ex)
         {
            return Enumerable.Empty<Grade>();
         }
      }
      [HttpGet("{id:int}")]
      public async Task<Grade> Get(int id)
      {
         try
         {
            return await _unitOfWork.GradeRepo.GetById(id);
         }
         catch (Exception ex)
         {
            return new Grade();
         }
      }
      [HttpPost]
      public async Task<ModelMessage> Post(Grade entity)
      {
         try
         {
            await _unitOfWork.GradeRepo.Add(entity);
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
      public async Task<ModelMessage> Put(Grade entity)
      {
         try
         {
            _unitOfWork.GradeRepo.Update(entity);
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
            await _unitOfWork.GradeRepo.DeletebyID(id);
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
