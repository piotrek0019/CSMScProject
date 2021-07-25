using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MScInvoice.Application.UsersAdmin
{
    public class GetUser
    {
        private UserManager<IdentityUser> _userManager;

        public GetUser(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public UserViewModel Do(string name) =>
            _userManager.Users.Where(x => x.UserName == name).Select(x => new UserViewModel
            {
                Id = x.Id,
                UserName = x.UserName
            })
            .FirstOrDefault();

        public class UserViewModel
        {
            public string Id { get; set; }
            public string UserName { get; set; }
           
        }
    }
}
