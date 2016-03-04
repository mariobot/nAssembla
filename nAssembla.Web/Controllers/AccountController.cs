using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using nAssembla.DTO;
using nAssembla.Web.Properties;
using System.Threading.Tasks;

namespace nAssembla.Web.Controllers
{
    public class AccountController : Controller
    {
        /// <summary>
        /// Autenticates this instance.
        /// </summary>
        /// <returns></returns>
        public ActionResult Autenticate(){ return View(); }        

        [HttpPost]
        public async Task<ActionResult> Autenticate(Authentication _autInfo)
        {
	  try
	  {
	      nAssembla.Configuration.ApiKey = _autInfo.AccessToken;
	      nAssembla.Configuration.ApiSecret = _autInfo.RefreshToken;

	      var currentUser = await NAssembla.UserProxy.GetCurrentUserAsync(true);
	      var spaces = await NAssembla.SpaceProxy.GetListAsync();

	      if (spaces != null)
		return View("Account",currentUser);
	      else return View();
	  }
	  catch (Exception ex){
	      return View("Error");
	  }
        }

        /// <summary>
        /// Accounts the specified _user.
        /// </summary>
        /// <param name="_user">The _user.</param>
        /// <returns></returns>
        public async Task<ActionResult> Account(User _user)
        {
	  if (_user.Email == null)	  
	      _user = await NAssembla.UserProxy.GetCurrentUserAsync(true);	  

	  return View(_user);        
        }

        /// <summary>
        /// Logs the out.
        /// </summary>
        /// <returns></returns>
        public async Task<ActionResult> LogOut()
        { 
	  //var log = await NAssembla.UserProxy.GetCurrentUserAsync().
	  return View();
        }
    }
}
