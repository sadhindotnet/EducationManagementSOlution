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
    public class AchievementsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public AchievementsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<Achievements>> Get()
        {
            try
            {
                return await _unitOfWork.AchievementsRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<Achievements>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<Achievements> Get(int id)
        {
            try
            {
                return await _unitOfWork.AchievementsRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new Achievements();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(Achievements entity)
        {
            try
            {
                await _unitOfWork.AchievementsRepo.Add(entity);
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
        public async Task<ModelMessage> Put(Achievements entity)
        {
            try
            {
                _unitOfWork.AchievementsRepo.Update(entity);
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
                await _unitOfWork.AchievementsRepo.DeletebyID(id);
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
