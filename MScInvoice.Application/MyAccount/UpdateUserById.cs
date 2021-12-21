using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using MScInvoice.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MScInvoice.Application.MyAccount
{
    public class UpdateUserById
    {
        private IHttpContextAccessor _httpContextAccessor;
        private ApplicationDbContext _context;
        private UserManager<MScInvoice.Domain.Models.MyUser> _userManager;
        private IPasswordHasher<MScInvoice.Domain.Models.MyUser> _passwordHash;

        public UpdateUserById(IHttpContextAccessor httpContextAccessor, 
            ApplicationDbContext context, 
            UserManager<MScInvoice.Domain.Models.MyUser> userManager, 
                IPasswordHasher<MScInvoice.Domain.Models.MyUser> passwordHash)
        {
            _httpContextAccessor = httpContextAccessor;
            _context = context;
            _userManager = userManager;
            _passwordHash = passwordHash;
        }

        public async Task<bool> Do(MyUserViewModel request)
        {
            var userId = _httpContextAccessor
                .HttpContext
                .User
                .FindFirst(ClaimTypes.NameIdentifier).Value;
            var myUser = _context.MyUsers.FirstOrDefault(x => x.Id == userId);

            myUser.UserName = request.UserName;
            myUser.Name = request.Name;
            myUser.Address1 = request.Address1;
            myUser.Address2 = request.Address2;
            myUser.City = request.City;
            myUser.PostCode = request.PostCode;
            myUser.Number1 = request.Number1;


            await _context.SaveChangesAsync();

            if(!String.IsNullOrEmpty(request.Password))
            { 
                var user = _userManager
                    .Users.FirstOrDefault(x => x.Id == userId);

                user.UserName = request.UserName;
                user.PasswordHash = _passwordHash
                    .HashPassword(user, request.Password);

               await _userManager.UpdateAsync(user);
            }

            return true;
        }
        
    }
}
