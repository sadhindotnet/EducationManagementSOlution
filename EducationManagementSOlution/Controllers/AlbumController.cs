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
    public class AlbumController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public AlbumController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<Album>> Get()
        {
            try
            {
                return await _unitOfWork.AlbumRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<Album>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<Album> Get(int id)
        {
            try
            {
                return await _unitOfWork.AlbumRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new Album();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(Album entity)
        {
            try
            {
                await _unitOfWork.AlbumRepo.Add(entity);
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
        public async Task<ModelMessage> Put(Album entity)
        {
            try
            {
                _unitOfWork.AlbumRepo.Update(entity);
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
                await _unitOfWork.AlbumRepo.DeletebyID(id);
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
