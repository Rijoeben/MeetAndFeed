using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using API.DTOS;
using BL;
using DAL;
using MAFDB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace API.Controllers
{
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
            var users =  _userService.ListOfUsers();
            if (users == null) return NotFound();
            return Ok(users);
        }
        [HttpGet("{id}")]
        public IActionResult GetUserById(long id)
        {
            var user =_userService.ReadUser(id);
            if (user == null) return NotFound();
            return Ok(user);
        }
        [HttpPost]
        public IActionResult Registering(string firstname, string lastname , string adress, string emailadress, bool preference, string password, char gender, DateTime dayOfBirth)
        {
            var user = _userService.CreateUser(firstname, lastname, adress, emailadress, preference, password, gender, dayOfBirth);
            return Ok(user);
        }
        [HttpPut]
        public IActionResult EditingUser(long userid)
        {
            var Usertochange = _userService.ReadUser(userid);
            
        }

    }
}