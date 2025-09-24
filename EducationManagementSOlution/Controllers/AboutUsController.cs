using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models.WebsiteModels;
using EducationManagement_DLL.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoyalAPI.Models.AccountModels;

namespace EducationManagementSOlution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutUsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public AboutUsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<AboutUs>> Get()
        {
            try
            {
                return await _unitOfWork.AboutUsRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<AboutUs>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<AboutUs> Get(int id)
        {
            try
            {
                return await _unitOfWork.AboutUsRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new AboutUs();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(AboutUs entity)
        {
            try
            {
                await _unitOfWork.AboutUsRepo.Add(entity);
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
        public async Task<ModelMessage> Put(AboutUs entity)
        {
            try
            {
                _unitOfWork.AboutUsRepo.Update(entity);
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
                await _unitOfWork.AboutUsRepo.DeletebyID(id);
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
