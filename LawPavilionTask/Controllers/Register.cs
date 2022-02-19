using LawPavilionTask.Model;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace LawPavilionTask.Controllers
{
    [RoutePrefix("api/UserRegister")]
    public class Register : Controller
    {
        LawPavilionEntities DB = new LawPavilionEntities();
        [Route("Login")]
        [HttpPost]
        public IHttpActionResult Login(Login login)
        {
            var log = DB.Logins.Where(x => x.Email.Equals(login.email) && x.Password.Equals(login.password)).FirstOrDefault();

            if (log == null)
            {
                return (IHttpActionResult)Ok(new { status = 401, isSuccess = false, message = "Invalid User", });
            }
            else

                return (IHttpActionResult)Ok(new { status = 200, isSuccess = true, message = "User Login successfully", UserDetails = log });
        }
        [Route("InsertUserRegister")]
        [HttpPost]
        public object InsertUserRegister(UserRegister Reg)
        {
            try
            {

                UserRegister UR = new UserRegister();
                if (UR.Id == 0)
                {
                    UR.firstName = Reg.firstName;
                    UR.lastName = Reg.lastName;
                    UR.emailAddress = Reg.emailAddress;
                    UR.password = Reg.password;
                    UR.confirmPassword = Reg.confirmPassword;
                    UR.phoneNumber = Reg.phoneNumber;
                    UR.age = Reg.age;
                    UR.createdDate = DateTime.Now;
                    DB.UserRegister.Add(UR);
                    DB.SaveChanges();
                    return new Response
                    { Status = "Success", Message = "Record SuccessFully Saved." };
                }
            }
            catch (Exception)
            {

                throw;
            }
            return new Response
            { Status = "Error", Message = "Invalid Data." };
        }
    }
}
