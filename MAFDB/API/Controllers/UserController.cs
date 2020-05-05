using System;
using BL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using MAFDB;

namespace API.Controllers
{
    [EnableCors("MyAllowSpecificOrigins")]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public IActionResult GetListOfUsers()
        {
            var users = _userService.ListOfUsers();
            if (users == null) return NotFound();
            return Ok(users);
        }
        [HttpGet("{id}")]
        public IActionResult GetUserById(long id)
        {
            var user = _userService.ReadUser(id);
            if (user == null) return NotFound();
            return Ok(user);
        }
        [HttpPost]
        public IActionResult Registering(string firstname, string lastname, string adress, string emailadress, bool preference, string password, char gender, DateTime dayOfBirth)
        {
            var user = _userService.CreateUser(firstname, lastname, adress, emailadress, preference, password, gender, dayOfBirth);
            return Ok(user);
        }
        [HttpPut]
        public IActionResult EditingUser(long userid, string FirstName, string Lastname, string Address, string EmailAddress, bool Preference, string Password, char Gender, DateTime dayOfBirth)
        {
            var UserTochange = _userService.ReadUser(userid);

            UserTochange = _userService.ChangeUser(userid, FirstName, Lastname, Address, EmailAddress, Preference, Password, Gender, dayOfBirth);

            return Ok(UserTochange);
        }
        [HttpGet("{email}")]
        public IActionResult LoginID(string email)
        {
            var Sessionhost = _userService.GetUserByEmail(email);
            var ID = Sessionhost.UserId;
            return Ok(ID);
        }
        [HttpGet("{email},{password}")]
        public IActionResult InLoggingding(string email, string password)
        {
            bool userToLoginBool = _userService.LoginBool(email, password);

            long userToLoginId = _userService.LoginId(email, password);

            if (userToLoginBool == true) return Ok(true);
            else return Ok(false);
        }
    }
}