using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models;
using EducationManagement_DLL.Models.Exam_Models;
using EducationManagement_DLL.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EducationManagementSOlution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentMethodController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public PaymentMethodController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<PaymentMethod>> Get()
        {
            try
            {
                return await _unitOfWork.PaymentMethodRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<PaymentMethod>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<PaymentMethod> Get(int id)
        {
            try
            {
                return await _unitOfWork.PaymentMethodRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new PaymentMethod();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(PaymentMethod entity)
        {
            try
            {
                await _unitOfWork.PaymentMethodRepo.Add(entity);
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
        public async Task<ModelMessage> Put(PaymentMethod entity)
        {
            try
            {
                _unitOfWork.PaymentMethodRepo.Update(entity);
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
                await _unitOfWork.PaymentMethodRepo.DeletebyID(id);
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
