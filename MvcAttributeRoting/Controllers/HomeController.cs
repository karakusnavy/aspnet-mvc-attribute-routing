using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAttributeRoting.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public ActionResult Index()
        {
            return View();
        }
        [Route("personel/list/{id}/{name}")]
        public ActionResult PersonelList(int id,string name)
        {
            return Content("<center>Welcome To Personel List "+name+". Your Id: "+id+"</center>");
        }
        
        
    }
}