using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace nAssembla.Web.Controllers
{
    public class MilestonesController : Controller
    {
        /// <summary>
        /// Indexes this instance.
        /// </summary>
        /// <returns></returns>
        public async Task<ActionResult> Index()
        {
	  try
	  {
	      var milestones = await NAssembla.MilestoneProxy.GetListAsync();
	      return View(milestones);
	  }
	  catch (Exception ex)
	  {   
	      throw;
	  }	  
        }

        /// <summary>
        /// Milestones the specified _key.
        /// </summary>
        /// <param name="_key">The _key.</param>
        /// <returns></returns>
        public async Task<ActionResult> Milestone(int _key)
        {
	  try
	  {
	      var milestones = await NAssembla.MilestoneProxy.GetAsync(_key);
	      return View();
	  }
	  catch (Exception ex)
	  {   
	      throw;
	  }
        }
    }
}
