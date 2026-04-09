using AlertsProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;



namespace AlertsProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly AliesAlertsDBContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, AliesAlertsDBContext context)
        {
            _context = context;
            _logger = logger;
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult SearchName()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpPost]

        public IActionResult Search(double? errorCode)
        {
            if (errorCode == null)
            {
                ViewBag.Message = "Please enter an error code.";
                return View("Search");
            }

            var _error = _context.AlertsTables
                .FirstOrDefault(e => e.رمزالخطأ.HasValue &&
                                     e.رمزالخطأ.Value == errorCode.Value);

            if (_error == null)
            {
                ViewBag.Message = "Error code not found.";
                return View("Search");
            }

            return View("ErrorDetails", _error);
        }
        [HttpPost]
        public IActionResult Searchusingname(string codename)
        {
            if (string.IsNullOrEmpty(codename))
            {
                ViewBag.Message = "Please enter an error name.";
                return View();
            }
            var _error = _context.AlertsTables.FirstOrDefault(e => e.اسمالخطأ == codename);
            if (_error != null)
            {
                return View("ErrorDetails1", _error);
            }
            else
            {
                ViewBag.Message = "Error name not found.";
                return View();
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new AlertsTable());
        }


        [HttpPost]
        public IActionResult Create(AlertsTable model)
        {
            if (ModelState.IsValid)
            {
                _context.AlertsTables.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Create");
            }

            return View(model);
        }

        public static List<Usersinfo> users = new List<Usersinfo>();
        public IActionResult Index()
        {
            return View(users);
        }
        [HttpPost]
        public IActionResult AddUser(Usersinfo user)
        {
            if (ModelState.IsValid)
            {
                _context.Usersinfo.Add(user);
                _context.SaveChanges();
            }

            // 👇 نرجع لنفس الصفحة مع البيانات
            var users = _context.Usersinfo.ToList();
            return View("Index", users);
        }

    }


    

}
