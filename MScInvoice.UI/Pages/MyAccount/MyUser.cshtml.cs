using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MScInvoice.Application.MyUser;
using MScInvoice.Database;

namespace MScInvoice.UI.Pages.MyAccount
{
    public class MyUserModel : PageModel
    {
        private IHttpContextAccessor _httpContextAccessor;
        private ApplicationDbContext _context;
        private UserManager<IdentityUser> _userManager;

        public MyUserModel(IHttpContextAccessor httpContextAccessor, ApplicationDbContext context)
        {
            _httpContextAccessor = httpContextAccessor;
            _context = context;
            
        }

        [BindProperty]
        public MyUserViewModel MyUser { get; set; }

        public IActionResult OnGet()
        {
            MyUser = new GetUserById(_httpContextAccessor, _context).Do();

            return Page();
        }

        public IActionResult OnPost()
        {
            var updatedUser = new UpdateUserById(_httpContextAccessor, _context).Do(MyUser);

            if (updatedUser)
                return Redirect("/Invoices/Invoices");

            else
                //TODO: add a warning
                return Page();
        }

    }
}
