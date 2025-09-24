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
   public class ResultController : ControllerBase
   {
      private readonly IUnitOfWork _unitOfWork;
      private ModelMessage message;
      public ResultController(IUnitOfWork unitOfWork)
      {
         _unitOfWork = unitOfWork;
         message = new ModelMessage();
      }
      [HttpGet]
      public async Task<IEnumerable<Result>> Get()
      {
         try
         {
            return await _unitOfWork.ResultRepo.GetAll();
         }
         catch (Exception ex)
         {
            return Enumerable.Empty<Result>();
         }
      }
      [HttpGet("{id:int}")]
      public async Task<Result> Get(int id)
      {
         try
         {
            return await _unitOfWork.ResultRepo.GetById(id);
         }
         catch (Exception ex)
         {
            return new Result();
         }
      }
      [HttpPost]
      public async Task<ModelMessage> Post(Result entity)
      {
         try
         {
            await _unitOfWork.ResultRepo.Add(entity);
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
      public async Task<ModelMessage> Put(Result entity)
      {
         try
         {
            _unitOfWork.ResultRepo.Update(entity);
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
            await _unitOfWork.ResultRepo.DeletebyID(id);
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
