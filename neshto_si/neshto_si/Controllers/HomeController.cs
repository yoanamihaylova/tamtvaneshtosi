using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using neshto_si.Controllers.Models;
using neshto_si.DataBase;
using neshto_si.DataBase.Models;
using neshto_si.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace neshto_si.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private DataBaseController dc;
        private const int PageSize = 5;
        //  private readonly ILogger<HomeController> _logger;
        public static User loggedUser = null;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            this.dc = new DataBaseController(new Madura3());
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Loggin(User user)
        {
            if (dc.getAllUsers().Any(u => u.password == user.password && u.username == user.username))
            {
                loggedUser = user;
                return RedirectToAction(nameof (Index));
            }
            return View();
        } 
        public IActionResult Register(UserVM user)
        {

            if (ModelState.IsValid == true)
            {
                user.id = default;
                user.role = false;
                User nov = new User(user);
                dc.createUser(nov);
                loggedUser = nov;
                return RedirectToAction(nameof(Index));
            }
           // return RedirectToAction(nameof (Loggin));
            return View();
        }
        public IActionResult Trains(TrainVM train)
        {

            train.trains = dc.getAllTrains();
            return View(train);
        }    
        public IActionResult CreateTrain(TrainVM train)
        {
            
            if(ModelState.IsValid == true)
            {
Train nov = new Train(train);
                dc.createTrain(nov);
                return RedirectToAction(nameof(Trains));
            }
            return View();
           
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
