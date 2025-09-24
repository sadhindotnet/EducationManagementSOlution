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
    public class StdtAcademicInfoController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public StdtAcademicInfoController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<StdtAcademicInfo>> Get()
        {
            try
            {
                return await _unitOfWork.StdtAcademicInfoRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<StdtAcademicInfo>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<StdtAcademicInfo> Get(int id)
        {
            try
            {
                return await _unitOfWork.StdtAcademicInfoRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new StdtAcademicInfo();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(StdtAcademicInfo entity)
        {
            try
            {
                await _unitOfWork.StdtAcademicInfoRepo.Add(entity);
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
        public async Task<ModelMessage> Put(StdtAcademicInfo entity)
        {
            try
            {
                _unitOfWork.StdtAcademicInfoRepo.Update(entity);
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
                await _unitOfWork.StdtAcademicInfoRepo.DeletebyID(id);
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
