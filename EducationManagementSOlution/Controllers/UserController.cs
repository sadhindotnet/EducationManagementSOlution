using EducationManagement_DLL.Context;
using EducationManagement_DLL.DTOs;
using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models.IdentityModels;
using EducationManagement_DLL.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace EducationManagementSOlution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public UserController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<ApplicationUser>> Get()
        {
            try
            {
                //return await _unitOfWork.UserRepo.GetAll();
                return await _unitOfWork.UserRepo.GetUsers();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<ApplicationUser>();
            }
        }
        [HttpGet("UserswithRole")]
        public async Task<IEnumerable<RegisterDTO>> GetUserswithRole()
        {
            try
            {
                //return await _unitOfWork.UserRepo.GetAll();
                return await _unitOfWork.UserRepo.GetAllUsersWithRolesAsync();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<RegisterDTO>();
            }
        }
        [HttpGet("UsersInRole")]
        public async Task<IEnumerable<ApplicationUser>> GetUsersbyRole(string roleName)
        {
            try
            {
                //return await _unitOfWork.UserRepo.GetAll();
                return await _unitOfWork.UserRepo.GetUsersInRoleAsync(roleName);
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<ApplicationUser>();
            }
        }
        //[HttpGet("{id:int}")]
        //public async Task<Role> Get(int id)
        //{
        //    try
        //    {
        //        return await _unitOfWork.RoleRepo.GetById(id);
        //    }
        //    catch (Exception ex)
        //    {
        //        return new Role();
        //    }
        //}
        [HttpPost]
        public async Task<ModelMessage> Post(RegisterDTO entity)
        {
            try
            {
               message= await _unitOfWork.UserRepo.CreateUser(entity);
                //message = _unitOfWork.Save();

            }
            catch (Exception ex)
            {
                message.IsSuccess = false;
                message.Message = ex.Message;
            }
            return message;
        }
        //[HttpPut]
        //public async Task<ModelMessage> Put(Role entity)
        //{
        //    try
        //    {
        //        _unitOfWork.RoleRepo.Update(entity);
        //        message = _unitOfWork.Save();

        //    }
        //    catch (Exception ex)
        //    {
        //        message.IsSuccess = false;
        //        message.Message = ex.Message;
        //    }
        //    return message;
        //}
        //[HttpDelete]
        //public async Task<ModelMessage> Delete(int id)
        //{
        //    try
        //    {
        //        await _unitOfWork.RoleRepo.DeletebyID(id);
        //        message = _unitOfWork.Save();

        //    }
        //    catch (Exception ex)
        //    {
        //        message.IsSuccess = false;
        //        message.Message = ex.Message;
        //    }
        //    return message;
        //}


        [Route("Upload")]
        [HttpPost, DisableRequestSizeLimit]
        public async Task<IActionResult> UploadPic()
        {
            try
            {
                var file = Request.Form.Files[0];
                //  var id = Request.Form["RestaurentId"];
                var userName = Request.Form["username"];
                var picpath = Request.Form["PicturePath"];
                var folderName = Path.Combine("Resources", "MemberPic");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
                if (file.Length > 0)
                {
                    //logo
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var ext = Path.GetExtension(fileName).ToLower();
                    var fullPath = Path.Combine(pathToSave, userName + ext);
                    var dbPath = Path.Combine(folderName, userName + ext);
                    if (ext == ".jpg" || ext == ".png" || ext == ".jpeg")
                    {
                        var l = picpath.ToString().Trim().Length;
                        if (picpath.ToString().Trim().Length > 0)
                        {
                            var existingfile = Path.Combine(Directory.GetCurrentDirectory(), picpath);

                            string oext = Path.GetExtension(existingfile).ToLower();
                            if (oext != ext)
                            {
                                //if(System.IO.File.Exists(picpath) )
                                System.IO.File.Delete(picpath);

                            }
                        }
                        using (var stream = new FileStream(fullPath, FileMode.Create))
                        {
                            file.CopyTo(stream);
                        }
                        var memtoupdate =await this._unitOfWork.UserRepo.GetUser(userName);
                        memtoupdate.ProfilePicture = dbPath;
                        memtoupdate.UserName = userName;
                        //using(Transaction transaction =this.unitofWork.Db ) { }
                      await  this._unitOfWork.UserRepo.UpdateUser(memtoupdate);
                        var m = this._unitOfWork.Save();
                        if (m.IsSuccess)
                        {

                            return Ok(new { Data = memtoupdate, result = m });
                        }
                        else
                        {
                            return Problem(m.Message);
                        }
                    }
                    else
                    {
                        return BadRequest("Please provide valid Picture");
                    }
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.InnerException?.Message ?? ex.Message}");
            }
        }
    }
}
