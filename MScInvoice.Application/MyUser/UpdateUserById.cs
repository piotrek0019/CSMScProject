using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using MScInvoice.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MScInvoice.Application.MyUser
{
    public class UpdateUserById
    {
        private IHttpContextAccessor _httpContextAccessor;
        private ApplicationDbContext _context;
        private UserManager<MScInvoice.Domain.Models.MyUser> _userManager;

        public UpdateUserById(IHttpContextAccessor httpContextAccessor, ApplicationDbContext context)
        {
            _httpContextAccessor = httpContextAccessor;
            _context = context;
        }

        public bool Do(MyUserViewModel request)
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var myUser = _context.MyUsers.FirstOrDefault(x => x.Id == userId);

            myUser.UserName = request.UserName;
            myUser.Name = request.Name;
            myUser.Address1 = request.Address1;
            myUser.Address2 = request.Address2;
            myUser.City = request.City;
            myUser.PostCode = request.PostCode;
            myUser.Number1 = request.Number1;
            

            _context.SaveChanges();

            return true;
        }
        
    }
}
