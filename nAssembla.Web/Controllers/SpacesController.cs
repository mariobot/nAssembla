using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using nAssembla.DTO;
using System.Threading.Tasks;

namespace nAssembla.Web.Controllers
{
    /// <summary>
    /// Controller for use the Spaces
    /// </summary>
    public class SpacesController : Controller
    {
        /// <summary>
        /// Indexes this instance.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Spaceses the specified _spaces.
        /// </summary>
        /// <param name="_spaces">The _spaces.</param>
        /// <returns></returns>
        public async Task<ActionResult> Spaces(IEnumerable<Space> _spaces)
        {
	  if (_spaces == null)	  
	      _spaces = await NAssembla.SpaceProxy.GetListAsync();	          	  

	  return View(_spaces);
        }

        /// <summary>
        /// Shows the specified _space.
        /// </summary>
        /// <param name="_space">The _space.</param>
        /// <returns></returns>
        public async Task<ActionResult> Show(Space _space)
        {  
	  return View();
        }

        /// <summary>
        /// Spaces the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        public async Task<ActionResult> Space(string key)
        {
	  var space = await NAssembla.SpaceProxy.GetAsync(key);

	  return View(space);
        }
    }
}
