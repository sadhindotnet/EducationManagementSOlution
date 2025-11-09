using EducationManagement_DLL.DTOs;
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
    public class StudentBasicInfoController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public StudentBasicInfoController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
            
        }
        [HttpGet]
        public async Task<IEnumerable<StudentBasicInfo>> Get()
        {
            try
            {
                return await _unitOfWork.StudentBasicInfoRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<StudentBasicInfo>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<StudentBasicInfo> Get(int id)
        {
            try
            {
                return await _unitOfWork.StudentBasicInfoRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new StudentBasicInfo();
            }
        }
        [HttpGet("GetProfile")]
        public async Task<StudentBasicInfo> GetProfile(string userName)
        {
            try
            {
                return await _unitOfWork.StudentBasicInfoRepo.GetT(s=>s.StudentID.Equals(userName));
            }
            catch (Exception ex)
            {
               // return new StudentBasicInfo();
                throw new ApplicationException($"Error fetching profile: {ex.InnerException.Message?? ex.Message}", ex);

            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post ([FromBody] StudentBasicInfo entity)
        {
          using(var transaction= _unitOfWork.Context.Database.BeginTransaction())
            {
            try
            {
                    if(_unitOfWork.StudentBasicInfoRepo.isExist(entity.StudentName, entity.StudentFathersContract))
                    {
                        message.IsSuccess = false;
                        message.Message = "Student name exist";
                        return message;
                    }
                await _unitOfWork.StudentBasicInfoRepo.Add(entity);
                message = _unitOfWork.Save();
                if(message.IsSuccess)
                {
                    var update= await _unitOfWork.StudentBasicInfoRepo.GetById(entity.Id);
                    update.StudentID = entity.GenerateStdID(entity.Id, DateTime.Now.Year.ToString(), entity.InstituteName);
                    _unitOfWork.StudentBasicInfoRepo.Update(update);
                    message = _unitOfWork.Save();
                        var register = new RegisterDTO
                        {
                            Email = entity.StudentEmail,
                            UserName = entity.StudentID,
                            Password = entity.StudentName.Substring(0, 3) + "*566#",
                            RolesName = "Student",
                            Name = entity.StudentName,
                            InstituteBranchId = entity.BranchId.Value,
                            InstituteId = entity.InstituteID.Value,
                            PhoneNumber = entity.StudentContract ?? entity.StudentFathersContract
                        };

                 message= await   _unitOfWork.UserRepo.CreateUser(register);
                  transaction.Commit();
                        return message;
                    }
                 transaction.Rollback();
                    return message;
                }
            catch (Exception ex)
            {
                message.IsSuccess = false;
                message.Message = ex.Message;
                transaction.Rollback();
                    return message;
                }
            }
            return message;
        }
        [HttpPut]
        public async Task<ModelMessage> Put(StudentBasicInfo entity)
        {
            try
            {
                _unitOfWork.StudentBasicInfoRepo.Update(entity);
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
                await _unitOfWork.StudentBasicInfoRepo.DeletebyID(id);
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
