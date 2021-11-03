using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MScInvoice.Application.Customers;
using MScInvoice.Application.Items;
using MScInvoice.Application.UsersAdmin;
using MScInvoice.Database;
using MScInvoice.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MScInvoice.UI.Controllers
{
    [Route("[controller]")]
    [Authorize(Policy = "Admin")]
    public class UsersController : Controller
    {
        private CreateUser _createUser;
        private UserManager<MyUser> _userManager;
        private IPasswordHasher<MyUser> _passwordHash;

        public UsersController(CreateUser createUser, UserManager<MyUser> userManager, IPasswordHasher<MyUser> passwordHash)
        {
            _createUser = createUser;
            _userManager = userManager;
            _passwordHash = passwordHash;
        }

        public async Task<IActionResult> CreateUser([FromBody] CreateUser.Request request) => Ok((await _createUser.Do(request)));
        /*{
            await _createUser.Do(request);

            return Ok();
        }*/

        [HttpGet("")]
        public IActionResult GetUsers() => Ok(new GetUsers(_userManager).Do());

        [HttpPut("")]
        public async Task<IActionResult> UpdateUser([FromBody] UpdateUser.Request request) => Ok((await new UpdateUser(_userManager, _passwordHash).Do(request)));
        [HttpGet("{name}")]
        public IActionResult GetUser(string name) => Ok(new GetUser(_userManager).Do(name));

        [HttpDelete("{name}")]
        public async Task<IActionResult> DeleteUser(string name) => Ok((await new DeleteUser(_userManager).Do(name)));

    }
}
