using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MScInvoice.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MScInvoice.UI.Controllers
{
    public class AccountController : Controller
    {
        private SignInManager<MyUser> _signInManager;
      

        public AccountController(SignInManager<MyUser> signInManager)
        {
            _signInManager = signInManager;
            
        }
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToPage("/Accounts/Login");
        }

       
    }
}
