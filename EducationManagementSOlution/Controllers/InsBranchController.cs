using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models;
using EducationManagement_DLL.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EducationManagementSOlution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsBranchController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public InsBranchController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<InsBranch>> Get()
        {
            try
            {
                return await _unitOfWork.InsBranchRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<InsBranch>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<InsBranch> Get(int id)
        {
            try
            {
                return await _unitOfWork.InsBranchRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new InsBranch();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(InsBranch entity)
        {
            try
            {
                await _unitOfWork.InsBranchRepo.Add(entity);
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
        public async Task<ModelMessage> Put(InsBranch entity)
        {
            try
            {
                _unitOfWork.InsBranchRepo.Update(entity);
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
                await _unitOfWork.InsBranchRepo.DeletebyID(id);
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
