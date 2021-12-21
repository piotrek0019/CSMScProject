using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MScInvoice.Application.UsersAdmin
{
    public class UpdateUser
    {
        private UserManager<MScInvoice.Domain.Models.MyUser> _userManager;
        private IPasswordHasher<MScInvoice.Domain.Models.MyUser> _passwordHash;

        public UpdateUser(UserManager<MScInvoice.Domain.Models.MyUser> 
            userManager, IPasswordHasher<
                MScInvoice.Domain.Models.MyUser> passwordHash)
        {
            _userManager = userManager;
            _passwordHash = passwordHash;
        }

        public async Task<Response> Do(Request request)
        {
            var user = _userManager.Users
                .FirstOrDefault(x => x.Id == request.Id );

            user.UserName = request.UserName;
            user.PasswordHash = _passwordHash.HashPassword(user, 
                request.Password);

            await _userManager.UpdateAsync(user);

            return new Response
            {
                Id = user.Id,
                UserName = user.UserName,
            };
        }
        public class Request
        {
            public string Id { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
           
        }

        public class Response
        {
            public string Id { get; set; }
            public string UserName { get; set; }
            
           
        }
    }
}
