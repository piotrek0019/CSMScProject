using Microsoft.AspNetCore.Identity;
using MScInvoice.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MScInvoice.Application.UsersAdmin
{
    public class CreateUser
    {

        private UserManager<MyUser> _userManager;
        private IPasswordHasher<MyUser> _passwordHash;

        public CreateUser(UserManager<MyUser> userManager, IPasswordHasher<MyUser> passwordHash)
        {
            _userManager = userManager;
            _passwordHash = passwordHash;
        }

        public class Request
        {
            public string UserName { get; set; }
            public string Password { get; set; }
        }
        public class Response
        {
            public string Id { get; set; }
            public string UserName { get; set; }
        }

        public async Task<Response> Do(Request request)
        {

            

            var User = new MyUser()
            {
                UserName = request.UserName
            };


            await _userManager.CreateAsync(User, request.Password);
            

            var userClaim = new Claim("Role", "User");

            await _userManager.AddClaimAsync(User, userClaim);

            return new Response
            {
                Id = User.Id,
                UserName = User.UserName
            };
        }
    }
}
