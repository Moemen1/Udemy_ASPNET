using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Udemy_ASPNET.Data;
using Udemy_ASPNET.Models;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Udemy_ASPNET.Controllers
{
    public class MovieController : Controller
    {
     

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

    
    }
}
