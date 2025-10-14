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
    public class AttendanceController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public AttendanceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<Attendance>> Get()
        {
            try
            {
                return await _unitOfWork.AttendanceRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<Attendance>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<Attendance> Get(int id)
        {
            try
            {
                return await _unitOfWork.AttendanceRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new Attendance();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(Attendance entity)
        {
            try
            {
                await _unitOfWork.AttendanceRepo.Add(entity);
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
        public async Task<ModelMessage> Put(Attendance entity)
        {
            try
            {
                _unitOfWork.AttendanceRepo.Update(entity);
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
                await _unitOfWork.AttendanceRepo.DeletebyID(id);
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
