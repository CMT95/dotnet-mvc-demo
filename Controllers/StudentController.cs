using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace test.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello World!";
        }
    }
}