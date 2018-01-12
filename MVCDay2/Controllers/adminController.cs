using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDay2.Controllers
{
    public class adminController : Controller
    {
        public string Index()
        {
            return "Hello Admin, this is index class";
        }
    }
}