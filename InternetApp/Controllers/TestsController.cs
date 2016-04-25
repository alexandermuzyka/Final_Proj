using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using DotNetOpenAuth.AspNet;
using Microsoft.Web.WebPages.OAuth;
using WebMatrix.WebData;
using InternetApp.Filters;
using InternetApp.Models;
using InternetApp.Models.ModelLogick;


namespace InternetApp.Controllers
{
    public class TestsController : Controller
    {

        private Model testModel = new Model();

        //
        // GET: /Test/
        public ActionResult Index()
        {
            // Необходимо узнать, аутентифицирован ли пользователь
            if (WebSecurity.IsAuthenticated)
            {
                // формируем список тестов для зарегистрированных пользователей

                return View();
            }
            else
            {
                // формируем список тестов для анонимных пользователей

                return View();
            }
        }

    }
}
