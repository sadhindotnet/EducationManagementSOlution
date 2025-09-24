using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models;
using EducationManagement_DLL.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EducationManagementSOlution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StdPaymentController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public StdPaymentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<StdPayment>> Get()
        {
            try
            {
                return await _unitOfWork.StdPaymentRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<StdPayment>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<StdPayment> Get(int id)
        {
            try
            {
                return await _unitOfWork.StdPaymentRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new StdPayment();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(StdPayment entity)
        {
            try
            {
                await _unitOfWork.StdPaymentRepo.Add(entity);
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
        public async Task<ModelMessage> Put(StdPayment entity)
        {
            try
            {
                _unitOfWork.StdPaymentRepo.Update(entity);
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
                await _unitOfWork.StdPaymentRepo.DeletebyID(id);
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
