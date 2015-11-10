using System;
using nAssembla.DTO;
using System.Collections.Generic;
using System.Net;
using System.IO;
using System.Threading.Tasks;

namespace nAssembla.Proxy
{
    public class SpaceToolProxy : ProxyBase<SpaceTool, string>
    {        
        protected override string[] BaseUriParameters
        {
            get
            {
                return new string[] { SpacesUriPath, "space_tools" };
            }
        }

        internal override bool DataIsCachable
        {
            get { return true; }
        }

        public async Task<IEnumerable<DTO.SpaceTool>> GetRepositorySpaceToolsAsync()
        {
            AdditionalUriParameters = new string[] { "repo" };
            var data = await GetListAsync();
            return data;
        }
    }
}