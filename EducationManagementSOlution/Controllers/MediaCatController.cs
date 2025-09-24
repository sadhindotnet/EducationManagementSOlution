using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models.Exam_Models;
using EducationManagement_DLL.Models.WebsiteModels;
using EducationManagement_DLL.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EducationManagementSOlution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediaCatController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public MediaCatController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<MediaCat>> Get()
        {
            try
            {
                return await _unitOfWork.MediaCatRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<MediaCat>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<MediaCat> Get(int id)
        {
            try
            {
                return await _unitOfWork.MediaCatRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new MediaCat();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(MediaCat entity)
        {
            try
            {
                await _unitOfWork.MediaCatRepo.Add(entity);
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
        public async Task<ModelMessage> Put(MediaCat entity)
        {
            try
            {
                _unitOfWork.MediaCatRepo.Update(entity);
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
                await _unitOfWork.MediaCatRepo.DeletebyID(id);
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
