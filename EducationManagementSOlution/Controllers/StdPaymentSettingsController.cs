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
    public class StdPaymentSettingsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public StdPaymentSettingsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<StdPaymentSettings>> Get()
        {
            try
            {
                return await _unitOfWork.StdPaymentRepoRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<StdPaymentSettings>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<StdPaymentSettings> Get(int id)
        {
            try
            {
                return await _unitOfWork.StdPaymentRepoRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new StdPaymentSettings();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(StdPaymentSettings entity)
        {
            try
            {
                await _unitOfWork.StdPaymentRepoRepo.Add(entity);
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
        public async Task<ModelMessage> Put(StdPaymentSettings entity)
        {
            try
            {
                _unitOfWork.StdPaymentRepoRepo.Update(entity);
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
                await _unitOfWork.StdPaymentRepoRepo.DeletebyID(id);
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
