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
    public class AcademicSessionController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public AcademicSessionController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<AcademicSession>> Get()
        {
            try
            {
                return await _unitOfWork.AcademicSessionRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<AcademicSession>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<AcademicSession> Get(int id)
        {
            try
            {
                return await _unitOfWork.AcademicSessionRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new AcademicSession();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(AcademicSession entity)
        {
            try
            {
                await _unitOfWork.AcademicSessionRepo.Add(entity);
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
        public async Task<ModelMessage> Put(AcademicSession entity)
        {
            try
            {
                _unitOfWork.AcademicSessionRepo.Update(entity);
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
                await _unitOfWork.AcademicSessionRepo.DeletebyID(id);
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
