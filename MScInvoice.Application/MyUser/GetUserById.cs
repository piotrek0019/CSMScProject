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
    public class GetUserById
    {
        private IHttpContextAccessor _httpContextAccessor;
        private ApplicationDbContext _context;
        private UserManager<MScInvoice.Domain.Models.MyUser> _userManager;

        public GetUserById(IHttpContextAccessor httpContextAccessor, ApplicationDbContext context)
        {
            _httpContextAccessor = httpContextAccessor;
            _context = context;
        }
        public MyUserViewModel Do()
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var myUser = _context.MyUsers.Where(x => x.Id == userId).Select(x => new MyUserViewModel
            {
                UserName = x.UserName,
                Name = x.Name,
                Address1 = x.Address1,
                Address2 = x.Address2,
                City = x.City,
                PostCode = x.PostCode,
                Number1 = x.Number1
            })
            .FirstOrDefault();

            return myUser;
        }
            

       
    }
}
