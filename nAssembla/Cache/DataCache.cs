using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using nAssembla.DTO;
using nAssembla.Cache;

namespace nAssembla.Cache
{
    [JsonObject(MemberSerialization.OptOut)]
    public class DataCache
    {
        private Dictionary<string, SpaceDataCache> _spaces = new Dictionary<string, SpaceDataCache>();

        /// <summary>
        /// A dictionary of cache data for spaces. The key is SpaceId
        /// </summary>
        public Dictionary<string, SpaceDataCache> Spaces
        {
            get { return this._spaces; }
            set { this._spaces = value; }
        }
    }
}
