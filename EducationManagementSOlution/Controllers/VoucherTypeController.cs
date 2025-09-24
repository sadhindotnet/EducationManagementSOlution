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
   public class VoucherTypeController : ControllerBase
   {
      private readonly IUnitOfWork _unitOfWork;
      private ModelMessage message;
      public VoucherTypeController(IUnitOfWork unitOfWork)
      {
         _unitOfWork = unitOfWork;
         message = new ModelMessage();
      }
      [HttpGet]
      public async Task<IEnumerable<VoucherType>> Get()
      {
         try
         {
            return await _unitOfWork.VoucherTypeRepo.GetAll();
         }
         catch (Exception ex)
         {
            return Enumerable.Empty<VoucherType>();
         }
      }
      [HttpGet("{id:int}")]
      public async Task<VoucherType> Get(int id)
      {
         try
         {
            return await _unitOfWork.VoucherTypeRepo.GetById(id);
         }
         catch (Exception ex)
         {
            return new VoucherType();
         }
      }
      [HttpPost]
      public async Task<ModelMessage> Post(VoucherType entity)
      {
         try
         {
            await _unitOfWork.VoucherTypeRepo.Add(entity);
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
      public async Task<ModelMessage> Put(VoucherType entity)
      {
         try
         {
            _unitOfWork.VoucherTypeRepo.Update(entity);
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
            await _unitOfWork.VoucherTypeRepo.DeletebyID(id);
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
