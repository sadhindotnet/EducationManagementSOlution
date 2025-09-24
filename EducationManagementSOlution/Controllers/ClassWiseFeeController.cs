using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models.AccountsModel;
using EducationManagement_DLL.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoyalAPI.Models.AccountModels;

namespace EducationManagementSOlution.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class ClassWiseFeeController : ControllerBase
   {
      private readonly IUnitOfWork _unitOfWork;
      private ModelMessage message;
      public ClassWiseFeeController(IUnitOfWork unitOfWork)
      {
         _unitOfWork = unitOfWork;
         message = new ModelMessage();
      }
      [HttpGet]
      public async Task<IEnumerable<ClassWiseFee>> Get()
      {
         try
         {
            return await _unitOfWork.ClassWiseFeeRepo.GetAll();
         }
         catch (Exception ex)
         {
            return Enumerable.Empty<ClassWiseFee>();
         }
      }
      [HttpGet("{id:int}")]
      public async Task<ClassWiseFee> Get(int id)
      {
         try
         {
            return await _unitOfWork.ClassWiseFeeRepo.GetById(id);
         }
         catch (Exception ex)
         {
            return new ClassWiseFee();
         }
      }
      [HttpPost]
      public async Task<ModelMessage> Post(ClassWiseFee entity)
      {
         try
         {
            await _unitOfWork.ClassWiseFeeRepo.Add(entity);
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
      public async Task<ModelMessage> Put(ClassWiseFee entity)
      {
         try
         {
            _unitOfWork.ClassWiseFeeRepo.Update(entity);
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
            await _unitOfWork.ClassWiseFeeRepo.DeletebyID(id);
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
