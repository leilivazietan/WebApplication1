using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data;
using WebApplication1.Contracts;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserInfoReader _userInfoReader;

        public UsersController(IUserInfoReader userInfoReader)
        {
            _userInfoReader = userInfoReader;
        }
        [HttpGet]
        public IEnumerable<User> Get()
        {
           var users = _userInfoReader.ReadFromExecl();
           return users;
        }
    }
}
