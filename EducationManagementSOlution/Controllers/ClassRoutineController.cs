using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models.Exam_Models;
using EducationManagement_DLL.Models.WebsiteModels;
using EducationManagement_DLL.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EducationManagementSOlution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassRoutineController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public ClassRoutineController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<ClassRoutine>> Get()
        {
            try
            {
                return await _unitOfWork.ClassRoutineRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<ClassRoutine>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<ClassRoutine> Get(int id)
        {
            try
            {
                return await _unitOfWork.ClassRoutineRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new ClassRoutine();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(ClassRoutine entity)
        {
            try
            {
                await _unitOfWork.ClassRoutineRepo.Add(entity);
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
        public async Task<ModelMessage> Put(ClassRoutine entity)
        {
            try
            {
                _unitOfWork.ClassRoutineRepo.Update(entity);
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
                await _unitOfWork.ClassRoutineRepo.DeletebyID(id);
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
