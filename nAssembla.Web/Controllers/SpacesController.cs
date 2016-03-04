using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using nAssembla.DTO;
using System.Threading.Tasks;
using nAssembla.Web.Properties;

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
        public async Task<ActionResult> Index()
        {
	  try
	  {   
	      if (TempData["spacecache"] != null)
	      {
		var spaces = (nAssembla.Cache.SpaceDataCache)(TempData["spacecache"]);
		return View(spaces);
	      }
	      else
	      {
		var spaces = await NAssembla.SpaceProxy.GetListAsync();
		return View(spaces);
	      }
	  }
	  catch (Exception ex)
	  {   
	      throw;
	  }
        }

        /// <summary>
        /// Selecteds the space.
        /// </summary>
        /// <param name="_space">The _space.</param>
        /// <returns></returns>
        public async Task<ActionResult> SelectedSpace(DTO.Space _space)
        {
	  try
	  {
	      nAssembla.Configuration.SpaceName = _space.Name;

	      var serialized = Settings.Default.SerializedCache;
	      var dataCache = new nAssembla.Cache.DataCache();

	      if (!string.IsNullOrEmpty(serialized))
		dataCache = Newtonsoft.Json.JsonConvert.DeserializeObject<nAssembla.Cache.DataCache>(serialized);

	      var spacecache = default(nAssembla.Cache.SpaceDataCache);

	      if (!dataCache.Spaces.TryGetValue(_space.Id, out spacecache))
	      {
		spacecache = await NAssembla.GetSpaceDataCache(_space.Id);
		dataCache.Spaces.Add(_space.Id, spacecache);
		serialized = await Newtonsoft.Json.JsonConvert.SerializeObjectAsync(dataCache);
		TempData["spacecache"] = spacecache;
		TempData["dataCache"] = dataCache;
		TempData["serialized"] = serialized;		

		//Settings.Default.SerializedCache = serialized;
		//Settings.Default.Save();
	      }
	      else { NAssembla.SetSpaceDataCache(spacecache); }

	      return View("SpaceInfo");

	      //var stream = await NAssembla.ActivityProxy.Space(_space.Id).DateFrom(DateTime.Today.AddDays(-7)).GetListAsync();
	      //stream.ToList().ForEach(s =>
	      //{
	      //    var ctl = new TestHarness.Controls.StreamEvent();
	      //    ctl.DataSource = s.;
	      //    streamPanel.Controls.Add(ctl);
	      //});

	      ////reportsCombo.SelectedItem = null;
	      ////reportsCombo.Items.Clear();
	      ////reportsCombo.Enabled = false;

	      //var customReports = await NAssembla.CustomReportProxy.GetListAsync();

	      //reportsCombo.Items.AddRange(nAssembla.DTO.StandardReports.AllStandardReports.ToArray());
	      //if (customReports != null)
	      //    reportsCombo.Items.AddRange(customReports.ToArray());

	      //reportsCombo.Enabled = true;
	      //statusLabel.Text = "Ready";
	  }
	  catch (Exception ex)
	  {
	      throw;
	  }
        }


        public ActionResult SpaceInfo()
        {
	  if (TempData["spacecache"] != null){  
 	      nAssembla.Cache.SpaceDataCache _spaceDataCache = (nAssembla.Cache.SpaceDataCache)(TempData["spacecache"]);
	      return View(_spaceDataCache);
	  }
	  else { return RedirectToAction("Index", "Spaces"); }
        }

        /// <summary>
        /// Spaceses the specified _spaces.
        /// </summary>
        /// <param name="_spaces">The _spaces.</param>
        /// <returns></returns>
        public async Task<ActionResult> Spaces(IEnumerable<Space> _spaces)
        {
	  try
	  {
	      if (_spaces == null)
		_spaces = await NAssembla.SpaceProxy.GetListAsync();

	      return View(_spaces);
	  }
	  catch (Exception ex)
	  {   
	      throw;
	  }
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

        public async Task<ActionResult> Refresh()
        {
	  //var thisSpace = (DTO.Space)spacesCombo.SelectedItem;
	  //var serialized = Settings.Default.SerializedCache;
	  //var dataCache = new nAssembla.Cache.DataCache();
	  //if (!string.IsNullOrEmpty(serialized))
	  //    dataCache = Newtonsoft.Json.JsonConvert.DeserializeObject<nAssembla.Cache.DataCache>(serialized);

	  //var spacecache = default(nAssembla.Cache.SpaceDataCache);	  
	  //spacecache = await NAssembla.GetSpaceDataCache(thisSpace.Id);

	  //if (!dataCache.Spaces.ContainsKey(thisSpace.Id))
	  //    dataCache.Spaces.Add(thisSpace.Id, spacecache);
	  //else
	  //    dataCache.Spaces[thisSpace.Id] = spacecache;

	  //serialized = await Newtonsoft.Json.JsonConvert.SerializeObjectAsync(dataCache);

	  //Settings.Default.SerializedCache = serialized;
	  //Settings.Default.Save();

	  //statusLabel.Text = "Ready";

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
