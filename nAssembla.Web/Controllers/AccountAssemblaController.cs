using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using nAssembla.DTO;

namespace nAssembla.Web.Controllers
{
    public class AccountAssemblaController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AssemblaAccount()
        {
	  return View();
        }

        [HttpPost]
        public ActionResult Autenticate(Authentication _autInfo)
        {
	  string key = _autInfo.AccessToken;
	  string d = _autInfo.
	  return View();
        }

        public ActionResult AccountConfiguration()
        {
	  return View();
        }
    }
}
