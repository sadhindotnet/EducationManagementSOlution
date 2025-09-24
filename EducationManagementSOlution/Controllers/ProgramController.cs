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
    public class ProgramController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public ProgramController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<Program1>> Get()
        {
            try
            {
                return await _unitOfWork.ProgramRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<Program1>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<Program1> Get(int id)
        {
            try
            {
                return await _unitOfWork.ProgramRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new Program1();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(Program1 entity)
        {
            try
            {
                await _unitOfWork.ProgramRepo.Add(entity);
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
        public async Task<ModelMessage> Put(Program1 entity)
        {
            try
            {
                _unitOfWork.ProgramRepo.Update(entity);
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
                await _unitOfWork.ProgramRepo.DeletebyID(id);
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
