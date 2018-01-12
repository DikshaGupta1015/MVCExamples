using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDay2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index(string id, string pass, string token)
        {
            return "Hello!!" + DateTime.Now.ToString()+" Id ="+id;
        }

        public string Index2(string id)
        {
            return "This is Index 2 Hello!!" + DateTime.Now.ToString();
        }
    }
}