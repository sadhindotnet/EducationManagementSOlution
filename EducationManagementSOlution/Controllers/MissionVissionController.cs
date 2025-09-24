using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models.WebsiteModels;
using EducationManagement_DLL.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EducationManagementSOlution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MissionVissionController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public MissionVissionController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<MissionVission>> Get()
        {
            try
            {
                return await _unitOfWork.MissionVissionRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<MissionVission>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<MissionVission> Get(int id)
        {
            try
            {
                return await _unitOfWork.MissionVissionRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new MissionVission();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(MissionVission entity)
        {
            try
            {
                await _unitOfWork.MissionVissionRepo.Add(entity);
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
        public async Task<ModelMessage> Put(MissionVission entity)
        {
            try
            {
                _unitOfWork.MissionVissionRepo.Update(entity);
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
                await _unitOfWork.MissionVissionRepo.DeletebyID(id);
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
