using Microsoft.AspNetCore.Identity;
using MScInvoice.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MScInvoice.Application.UsersAdmin
{
    public class GetUsers
    {
        private UserManager<MyUser> _userManager;

        public GetUsers(UserManager<MyUser> userManager)
        {
            _userManager = userManager;
        }

        public IEnumerable<UserViewModel> Do() =>
            _userManager.Users.ToList().Select(x => new UserViewModel
            {
               
                UserName = x.UserName
            });
        

        public class UserViewModel
        {
           
            public string UserName { get; set; }
        }
    }
}
