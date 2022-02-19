using LawPavilionTask.Model;
using LawPavilionTask.Model.DTO;
using LawPavilionTask.Persistance;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace LawPavilionTask.Controllers
{
    [RoutePrefix("api/UserRegister")]
    public class UserController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<User> repository;
        public UserController(IRepository<User> repository, IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            _unitOfWork = unitOfWork;
        }
        [Route("api/Login")]
        [HttpPost]
        public IActionResult Login(Login login)
        {
            try
            {
                if (login == null)
                {
                    return (IActionResult)Ok(new { status = 401, isSuccess = false, message = "Invalid User", });
                }
                else

                    return (IActionResult)Ok(new { status = 200, isSuccess = true, message = "User Login successfully", UserDetails = login });
            }
            catch (Exception)
            {

                throw;
            }
        }
        [Route("api/InsertUserRegister")]
        [HttpPost]
        public IActionResult InsertUserRegister(UserDto Reg)
        {
            if (Reg == null)
            {
                return BadRequest(new { status = 404, isSuccess = false, message = "User Details incorrect", });
            }
            try
            {

                Model.User user = new Model.User
                {
                    firstName = Reg.firstName,
                    lastName = Reg.lastName,
                    emailAddress = Reg.emailAddress,
                    password = Reg.password,
                    confirmPassword = Reg.confirmPassword,
                    phoneNumber = Reg.phoneNumber,
                    age = Reg.age,
                    createdDate = DateTime.Now
                };

                repository.Add(user);
                _unitOfWork.Complete();
                return Ok(new { status = 200, isSuccess = true, message = "User Successfully Created", data = user });
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
