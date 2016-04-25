using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebUI.Models;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {

        Model thisModel = new Model();
        // GET: Home
        public ViewResult Index()
        {
            return View(thisModel);
        }

        [HttpGet]
        public ViewResult ShowTest(string testName)
        {
            return View(thisModel.GetTest(testName));
        }
    }
}