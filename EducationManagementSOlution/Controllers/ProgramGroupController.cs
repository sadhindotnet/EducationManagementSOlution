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
    public class ProgramGroupController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public ProgramGroupController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<ProgramGroup>> Get()
        {
            try
            {
                return await _unitOfWork.ProgramGroupRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<ProgramGroup>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<ProgramGroup> Get(int id)
        {
            try
            {
                return await _unitOfWork.ProgramGroupRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new ProgramGroup();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(ProgramGroup entity)
        {
            try
            {
                await _unitOfWork.ProgramGroupRepo.Add(entity);
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
        public async Task<ModelMessage> Put(ProgramGroup entity)
        {
            try
            {
                _unitOfWork.ProgramGroupRepo.Update(entity);
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
