﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InventoryManager.Pages
{
    public class LogoutModel : PageModel
    {
        public IActionResult OnGet()
        {
            return this.SignOut("Cookies", "oidc");
        }
    }
}
