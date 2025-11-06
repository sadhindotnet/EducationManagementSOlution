using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models;
using EducationManagement_DLL.Utility;
using Microsoft.AspNetCore.Mvc;

namespace EducationManagementSOlution.Controllers
{
    public class TeacherController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public TeacherController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<Teacher>> Get()
        {
            try
            {
                return await _unitOfWork.TeacherRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<Teacher>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<Teacher> Get(int id)
        {
            try
            {
                return await _unitOfWork.TeacherRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new Teacher();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(Teacher entity)
        {
            try
            {
                await _unitOfWork.TeacherRepo.Add(entity);
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
        public async Task<ModelMessage> Put(Teacher entity)
        {
            try
            {
                _unitOfWork.TeacherRepo.Update(entity);
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
                await _unitOfWork.MissionVissionRepo.DeletebyID(id);
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
