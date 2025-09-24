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
   public class ShareHolderInformationController : ControllerBase
   {
      private readonly IUnitOfWork _unitOfWork;
      private ModelMessage message;
      public ShareHolderInformationController(IUnitOfWork unitOfWork)
      {
         _unitOfWork = unitOfWork;
         message = new ModelMessage();
      }
      [HttpGet]
      public async Task<IEnumerable<ShareHolderInformation>> Get()
      {
         try
         {
            return await _unitOfWork.ShareHolderInformationRepo.GetAll();
         }
         catch (Exception ex)
         {
            return Enumerable.Empty<ShareHolderInformation>();
         }
      }
      [HttpGet("{id:int}")]
      public async Task<ShareHolderInformation> Get(int id)
      {
         try
         {
            return await _unitOfWork.ShareHolderInformationRepo.GetById(id);
         }
         catch (Exception ex)
         {
            return new ShareHolderInformation();
         }
      }
      [HttpPost]
      public async Task<ModelMessage> Post(ShareHolderInformation entity)
      {
         try
         {
            await _unitOfWork.ShareHolderInformationRepo.Add(entity);
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
      public async Task<ModelMessage> Put(ShareHolderInformation entity)
      {
         try
         {
            _unitOfWork.ShareHolderInformationRepo.Update(entity);
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
            await _unitOfWork.ShareHolderInformationRepo.DeletebyID(id);
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
