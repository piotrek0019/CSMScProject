using Microsoft.AspNetCore.Identity;
using MScInvoice.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MScInvoice.Application.UsersAdmin
{
    public class DeleteUser
    {

        private UserManager<MyUser> _userManager;

        public DeleteUser(UserManager<MyUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<bool> Do(string name)
        {
            var user = _userManager.Users.Where(x => x.UserName == name)
            .FirstOrDefault();

            await _userManager.DeleteAsync(user);

            return true;
        }

    }
}
