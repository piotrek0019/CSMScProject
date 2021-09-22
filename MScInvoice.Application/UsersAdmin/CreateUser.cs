using Microsoft.AspNetCore.Identity;
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
        private UserManager<MScInvoice.Domain.Models.MyUser> _userManager;

        public CreateUser(UserManager<MScInvoice.Domain.Models.MyUser> userManager)
        {
            _userManager = userManager;
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
            var User = new MScInvoice.Domain.Models.MyUser()
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
