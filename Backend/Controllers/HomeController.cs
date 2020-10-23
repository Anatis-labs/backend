using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        public string Index()
        {
            return "This is definetly not a cat pages secret backend";
        }
    }
}