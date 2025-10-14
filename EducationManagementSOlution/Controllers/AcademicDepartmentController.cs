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
    public class AcademicDepartmentController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public AcademicDepartmentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<AcademicDepartment>> Get()
        {
            try
            {
                return await _unitOfWork.AcademicDepartmentRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<AcademicDepartment>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<AcademicDepartment> Get(int id)
        {
            try
            {
                return await _unitOfWork.AcademicDepartmentRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new AcademicDepartment();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(AcademicDepartment entity)
        {
            try
            {
                await _unitOfWork.AcademicDepartmentRepo.Add(entity);
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
        public async Task<ModelMessage> Put(AcademicDepartment entity)
        {
            try
            {
                _unitOfWork.AcademicDepartmentRepo.Update(entity);
                message = _unitOfWork.Save();

            }
            catch (Exception ex)
            {
                message.IsSuccess = false;
                message.Message = ex.Message;
            }
            return message;
        }
        [HttpDelete("{id}")]
        public async Task<ModelMessage> Delete(int id)
        {
            try
            {
                await _unitOfWork.AcademicDepartmentRepo.DeletebyID(id);
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
