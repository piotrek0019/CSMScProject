using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MScInvoice.Application.MyAccount;
using MScInvoice.Database;

namespace MScInvoice.UI.Pages.MyAccount
{
    public class MyUserModel : PageModel
    {
        private IHttpContextAccessor _httpContextAccessor;
        private ApplicationDbContext _context;
        private UserManager<MScInvoice.Domain.Models.MyUser> _userManager;
        private IPasswordHasher<MScInvoice.Domain.Models.MyUser> _passwordHash;

        public MyUserModel(IHttpContextAccessor httpContextAccessor, ApplicationDbContext context, UserManager<MScInvoice.Domain.Models.MyUser> userManager, IPasswordHasher<MScInvoice.Domain.Models.MyUser> passwordHash)
        {
            _httpContextAccessor = httpContextAccessor;
            _context = context;
            _userManager = userManager;
            _passwordHash = passwordHash;
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
            var updatedUser = new UpdateUserById(_httpContextAccessor, _context, _userManager, _passwordHash).Do(MyUser);

            if(!ModelState.IsValid)
            {
                return Page();
            }
            if (updatedUser.Result)
                return Redirect("/Invoices/Invoices");

            else
                //TODO: add a warning
                return Page();
        }

    }
}
