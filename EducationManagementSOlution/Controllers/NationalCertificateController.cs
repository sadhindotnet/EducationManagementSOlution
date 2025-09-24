using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models;
using EducationManagement_DLL.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EducationManagementSOlution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NationalCertificateController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public NationalCertificateController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<NationalCertificate>> Get()
        {
            try
            {
                return await _unitOfWork.NationalCertificateRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<NationalCertificate>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<NationalCertificate> Get(int id)
        {
            try
            {
                return await _unitOfWork.NationalCertificateRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new NationalCertificate();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(NationalCertificate entity)
        {
            try
            {
                await _unitOfWork.NationalCertificateRepo.Add(entity);
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
        public async Task<ModelMessage> Put(NationalCertificate entity)
        {
            try
            {
                _unitOfWork.NationalCertificateRepo.Update(entity);
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
                await _unitOfWork.NationalCertificateRepo.DeletebyID(id);
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
