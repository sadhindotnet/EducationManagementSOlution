using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models;
using EducationManagement_DLL.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EducationManagementSOlution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstituteTypeController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public InstituteTypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<InstituteType>> Get()
        {
            try
            {
                return await _unitOfWork.InstituteTyperepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<InstituteType>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<InstituteType> Get(int id)
        {
            try
            {
                return await _unitOfWork.InstituteTyperepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new InstituteType();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(InstituteType entity)
        {
            try
            {
                await _unitOfWork.InstituteTyperepo.Add(entity);
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
        public async Task<ModelMessage> Put(InstituteType entity)
        {
            try
            {
                _unitOfWork.InstituteTyperepo.Update(entity);
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
                await _unitOfWork.InstituteTyperepo.DeletebyID(id);
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
