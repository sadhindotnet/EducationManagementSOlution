using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models;
using EducationManagement_DLL.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EducationManagementSOlution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectInfoController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public SubjectInfoController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<SubjectInfo>> Get()
        {
            try
            {
                return await _unitOfWork.SubjectInfoRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<SubjectInfo>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<SubjectInfo> Get(int id)
        {
            try
            {
                return await _unitOfWork.SubjectInfoRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new SubjectInfo();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(SubjectInfo entity)
        {
            try
            {
                await _unitOfWork.SubjectInfoRepo.Add(entity);
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
        public async Task<ModelMessage> Put(SubjectInfo entity)
        {
            try
            {
                _unitOfWork.SubjectInfoRepo.Update(entity);
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
                await _unitOfWork.ProgramGroupRepo.DeletebyID(id);
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
