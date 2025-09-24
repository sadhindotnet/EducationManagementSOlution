using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models.WebsiteModels;
using EducationManagement_DLL.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EducationManagementSOlution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public RoomController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<Room>> Get()
        {
            try
            {
                return await _unitOfWork.RoomRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<Room>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<Room> Get(int id)
        {
            try
            {
                return await _unitOfWork.RoomRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new Room();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(Room entity)
        {
            try
            {
                await _unitOfWork.RoomRepo.Add(entity);
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
        public async Task<ModelMessage> Put(Room entity)
        {
            try
            {
                _unitOfWork.RoomRepo.Update(entity);
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
                await _unitOfWork.RoomRepo.DeletebyID(id);
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
