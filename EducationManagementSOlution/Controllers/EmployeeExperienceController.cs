using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models;
using EducationManagement_DLL.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EducationManagementSOlution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeExperienceController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public EmployeeExperienceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<EmployeeExperience>> Get()
        {
            try
            {
                return await _unitOfWork.EmployeeExperienceRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<EmployeeExperience>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<EmployeeExperience> Get(int id)
        {
            try
            {
                return await _unitOfWork.EmployeeExperienceRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new EmployeeExperience();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(EmployeeExperience entity)
        {
            try
            {
                await _unitOfWork.EmployeeExperienceRepo.Add(entity);
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
        public async Task<ModelMessage> Put(EmployeeExperience entity)
        {
            try
            {
                _unitOfWork.EmployeeExperienceRepo.Update(entity);
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
                await _unitOfWork.EmployeeExperienceRepo.DeletebyID(id);
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
