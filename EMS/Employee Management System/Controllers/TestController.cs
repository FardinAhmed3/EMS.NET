using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Employee_Management_System.Controllers
{
    public class TestController : Controller
    {
        // GET: Test2
        public string Index()
        {
            return "this is my <b> default  </b> action";
        }

        public string Welcome() {
            return "a";
        }
    }
}