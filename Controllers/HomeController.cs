using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModel_Fun.Models;

namespace ViewModel_Fun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            string message = "lorem ipsum message...";
            
            return View("Index", message);
        }

        [HttpGet]
        [Route("/Numbers")]
        public IActionResult Numbers()
        {
            int[] numbers = new int[]
            {1,2,3,10,43,5};
            return View("Numbers", numbers);
        }

        [HttpGet]
        [Route("/SingleUser")]
        public IActionResult SingleUser()
        {
            User user_1 = new User()
            {
                FirstName = "Billy",
                LastName = "Crystal"
            };

            return View("SingleUser", user_1);
        }

        [HttpGet]
        [Route("/Users")]
        public IActionResult Users()
        {
            User user_1 = new User()
            {
                FirstName = "Billy",
                LastName = "Crystal"
            };

            User user_2 = new User()
            {
                FirstName = "Nicole",
                LastName = "Kidman"
            };

            User user_3 = new User()
            {
                FirstName = "Tom",
                LastName = "Cruise"
            };

            User user_4 = new User()
            {
                FirstName = "Penelope",
                LastName = "Cruise"
            };

            List<User> usersList = new List<User>()
            {
                user_1, user_2, user_3, user_4
            }; 
            return View("Users", usersList);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
