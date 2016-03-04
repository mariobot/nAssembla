using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using nAssembla.DTO;
using System.Threading.Tasks;

namespace nAssembla.Web.Controllers
{
    public class ActivityController : Controller
    {   
        public async Task<ActionResult> Index()
        {
	  //var activities = await NAssembla.ActivityProxy.
            return View();
        }
    }
}
