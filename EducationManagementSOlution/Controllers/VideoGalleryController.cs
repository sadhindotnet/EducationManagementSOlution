using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models.WebsiteModels;
using EducationManagement_DLL.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EducationManagementSOlution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGalleryController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public VideoGalleryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<VideoGallery>> Get()
        {
            try
            {
                return await _unitOfWork.VideoGalleryRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<VideoGallery>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<VideoGallery> Get(int id)
        {
            try
            {
                return await _unitOfWork.VideoGalleryRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new VideoGallery();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(VideoGallery entity)
        {
            try
            {
                await _unitOfWork.VideoGalleryRepo.Add(entity);
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
        public async Task<ModelMessage> Put(VideoGallery entity)
        {
            try
            {
                _unitOfWork.VideoGalleryRepo.Update(entity);
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
                await _unitOfWork.VideoGalleryRepo.DeletebyID(id);
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
