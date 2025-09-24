using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models.IdentityModels;
using EducationManagement_DLL.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoyalAPI.Models.AccountModels;

namespace EducationManagementSOlution.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class TokenApiModelController : ControllerBase
   {
      private readonly IUnitOfWork _unitOfWork;
      private ModelMessage message;
      public TokenApiModelController(IUnitOfWork unitOfWork)
      {
         _unitOfWork = unitOfWork;
         message = new ModelMessage();
      }
      [HttpGet]
      public async Task<IEnumerable<TokenApiModel>> Get()
      {
         try
         {
            return await _unitOfWork.TokenApiModelRepo.GetAll();
         }
         catch (Exception ex)
         {
            return Enumerable.Empty<TokenApiModel>();
         }
      }
      [HttpGet("{id:int}")]
      public async Task<TokenApiModel> Get(int id)
      {
         try
         {
            return await _unitOfWork.TokenApiModelRepo.GetById(id);
         }
         catch (Exception ex)
         {
            return new TokenApiModel();
         }
      }
      [HttpPost]
      public async Task<ModelMessage> Post(TokenApiModel entity)
      {
         try
         {
            await _unitOfWork.TokenApiModelRepo.Add(entity);
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
      public async Task<ModelMessage> Put(TokenApiModel entity)
      {
         try
         {
            _unitOfWork.TokenApiModelRepo.Update(entity);
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
            await _unitOfWork.TokenApiModelRepo.DeletebyID(id);
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
