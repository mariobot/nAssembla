using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using nAssembla.DTO;

namespace nAssembla.Web.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Autenticate()
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
	  string AccessToken = _autInfo.AccessToken;
	  string RefreshToken = _autInfo.RefreshToken;

	  return View();
        }

        public ActionResult AccountConfiguration()
        {
	  return View();
        }
    }
}
