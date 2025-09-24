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
    public class ClassSubjecTeacherInsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public ClassSubjecTeacherInsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<ClassSubjecTeacherIns>> Get()
        {
            try
            {
                return await _unitOfWork.ClassSubjecTeacherInsRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<ClassSubjecTeacherIns>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<ClassSubjecTeacherIns> Get(int id)
        {
            try
            {
                return await _unitOfWork.ClassSubjecTeacherInsRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new ClassSubjecTeacherIns();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(ClassSubjecTeacherIns entity)
        {
            try
            {
                await _unitOfWork.ClassSubjecTeacherInsRepo.Add(entity);
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
        public async Task<ModelMessage> Put(ClassSubjecTeacherIns entity)
        {
            try
            {
                _unitOfWork.ClassSubjecTeacherInsRepo.Update(entity);
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
                await _unitOfWork.ClassSubjecTeacherInsRepo.DeletebyID(id);
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
