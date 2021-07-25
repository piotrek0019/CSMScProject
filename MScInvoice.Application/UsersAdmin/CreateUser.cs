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
        private UserManager<IdentityUser> _userManager;

        public CreateUser(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public class Request
        {
            public string UserName { get; set; }
            public string Password { get; set; }
        }

        public async Task<bool> Do(Request request)
        {
            var User = new IdentityUser()
            {
                UserName = request.UserName
            };
            

            await _userManager.CreateAsync(User, request.Password);

            var userClaim = new Claim("Role", "User");

            await _userManager.AddClaimAsync(User, userClaim);

            return true;
        }
    }
}
