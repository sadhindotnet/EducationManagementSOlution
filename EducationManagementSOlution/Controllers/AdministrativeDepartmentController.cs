using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models;
using EducationManagement_DLL.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EducationManagementSOlution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdministrativeDepartmentController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public AdministrativeDepartmentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<AdministrativeDepartment>> Get()
        {
            try
            {
                return await _unitOfWork.AdministrativeDepartmentRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<AdministrativeDepartment>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<AdministrativeDepartment> Get(int id)
        {
            try
            {
                return await _unitOfWork.AdministrativeDepartmentRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new AdministrativeDepartment();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(AdministrativeDepartment entity)
        {
            try
            {
                await _unitOfWork.AdministrativeDepartmentRepo.Add(entity);
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
        public async Task<ModelMessage> Put(AdministrativeDepartment entity)
        {
            try
            {
                _unitOfWork.AdministrativeDepartmentRepo.Update(entity);
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
                await _unitOfWork.AdministrativeDepartmentRepo.DeletebyID(id);
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
