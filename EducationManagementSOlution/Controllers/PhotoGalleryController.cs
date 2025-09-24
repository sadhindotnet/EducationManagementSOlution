using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models.IdentityModels;
using EducationManagement_DLL.Models.WebsiteModels;
using EducationManagement_DLL.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EducationManagementSOlution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotoGalleryController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public PhotoGalleryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<PhotoGallery>> Get()
        {
            try
            {
                return await _unitOfWork.PhotoGalleryRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<PhotoGallery>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<PhotoGallery> Get(int id)
        {
            try
            {
                return await _unitOfWork.PhotoGalleryRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new PhotoGallery();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(PhotoGallery entity)
        {
            try
            {
                await _unitOfWork.PhotoGalleryRepo.Add(entity);
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
        public async Task<ModelMessage> Put(PhotoGallery entity)
        {
            try
            {
                _unitOfWork.PhotoGalleryRepo.Update(entity);
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
                await _unitOfWork.PhotoGalleryRepo.DeletebyID(id);
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
