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
    public class AdmitCardController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public AdmitCardController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<AdmitCard>> Get()
        {
            try
            {
                return await _unitOfWork.AdmitCardRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<AdmitCard>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<AdmitCard> Get(int id)
        {
            try
            {
                return await _unitOfWork.AdmitCardRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new AdmitCard();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(AdmitCard entity)
        {
            try
            {
                await _unitOfWork.AdmitCardRepo.Add(entity);
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
        public async Task<ModelMessage> Put(AdmitCard entity)
        {
            try
            {
                _unitOfWork.AdmitCardRepo.Update(entity);
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
