using System;
using System.Linq;
using nAssembla.DTO;
using System.Collections.Generic;
using System.Net;
using System.IO;
using System.Threading.Tasks;

namespace nAssembla.Proxy
{
    public class SpaceProxy : ProxyBase<Space, string>
    {
        private bool _addSpaceId = false;
        protected override string[] BaseUriParameters
        {
            get
            {
                return new string[] { SpacesUriPath };
            }
        }

        public async Task<IEnumerable<Space>> GetSpacesByToolAsync(SpaceToolType tool)
        {
            AdditionalUriParameters = new string[] { "my_tool_spaces", tool.ToString("d") };
            var data = await GetListAsync();
            return data;
        }
    }
}