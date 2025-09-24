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
    public class StdInvoiceController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public StdInvoiceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<StdInvoice>> Get()
        {
            try
            {
                return await _unitOfWork.StdInvoiceRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<StdInvoice>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<StdInvoice> Get(int id)
        {
            try
            {
                return await _unitOfWork.StdInvoiceRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new StdInvoice();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(StdInvoice entity)
        {
            try
            {
                await _unitOfWork.StdInvoiceRepo.Add(entity);
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
        public async Task<ModelMessage> Put(StdInvoice entity)
        {
            try
            {
                _unitOfWork.StdInvoiceRepo.Update(entity);
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
                await _unitOfWork.StdInvoiceRepo.DeletebyID(id);
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
