using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace nAssembla.Proxy
{
    public class MilestoneProxy : ProxyBase<DTO.Milestone, int>
    {
        protected override string[] BaseUriParameters
        {
            get
            {
                return new string[] { SpacesUriPath, "milestones" };
            }
        }

        internal override bool DataIsCachable
        {
            get { return true; }
        }

        public async Task<IEnumerable<DTO.Milestone>> GetUpcomingMilestonesAsync()
        {
            AdditionalUriParameters = new string[] { "upcoming" };
            return await GetListAsync();
        }

        public async Task<IEnumerable<DTO.Milestone>> GetcompletedMilestonesAsync()
        {
            AdditionalUriParameters = new string[] { "completed" };
            return await GetListAsync();
        }
    
    }
}