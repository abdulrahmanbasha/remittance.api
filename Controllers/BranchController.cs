using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace remittance.api.Controllers
{
    public class BranchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
