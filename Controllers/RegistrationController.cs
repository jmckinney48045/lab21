using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LAB21.Models
{
    public class RegistrationController : Controller
    {
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Registration registration)
        {
            //save to database, or present back to user

            return View(registration);
        }
    }
}