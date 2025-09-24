using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models.WebsiteModels;
using EducationManagement_DLL.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EducationManagementSOlution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public SocialMediaController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<SocialMedia>> Get()
        {
            try
            {
                return await _unitOfWork.SocialMediaRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<SocialMedia>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<SocialMedia> Get(int id)
        {
            try
            {
                return await _unitOfWork.SocialMediaRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new SocialMedia();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(SocialMedia entity)
        {
            try
            {
                await _unitOfWork.SocialMediaRepo.Add(entity);
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
        public async Task<ModelMessage> Put(SocialMedia entity)
        {
            try
            {
                _unitOfWork.SocialMediaRepo.Update(entity);
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
                await _unitOfWork.SocialMediaRepo.DeletebyID(id);
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
