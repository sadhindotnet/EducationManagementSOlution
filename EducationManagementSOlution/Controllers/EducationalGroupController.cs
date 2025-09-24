using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models;
using EducationManagement_DLL.Models.WebsiteModels;
using EducationManagement_DLL.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EducationManagementSOlution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationalGroupController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public EducationalGroupController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<EducationalGroup>> Get()
        {
            try
            {
                return await _unitOfWork.EducationalGroupRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<EducationalGroup>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<EducationalGroup> Get(int id)
        {
            try
            {
                return await _unitOfWork.EducationalGroupRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new EducationalGroup();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(EducationalGroup entity)
        {
            try
            {
                await _unitOfWork.EducationalGroupRepo.Add(entity);
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
        public async Task<ModelMessage> Put(EducationalGroup entity)
        {
            try
            {
                _unitOfWork.EducationalGroupRepo.Update(entity);
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
