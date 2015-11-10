using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nAssembla.Proxy.Enums;

namespace nAssembla.Proxy
{
    public static class CacheProxy
    {
        private static IEnumerable<DTO.TicketComponent> _ticketComponents;

        public static async Task<nAssembla.Cache.DataCache> LoadCachableData(DTO.Space space, CachableDataTypes types)
        {
            var dataCache = new nAssembla.Cache.DataCache();
            var spaceCache = new nAssembla.Cache.SpaceDataCache();
            dataCache.Spaces[space.Id] = spaceCache;

            if ((types & CachableDataTypes.Components) == CachableDataTypes.Components)
            {
                spaceCache.Components = await new TicketComponentProxy().GetListAsync();
                RaiseDataLoaded(CachableDataTypes.Components, spaceCache.Components.Count());
            }

            if ((types & CachableDataTypes.Milestones) == CachableDataTypes.Milestones)
            {
                spaceCache.Milestones = await new MilestoneProxy().GetListAsync();
                RaiseDataLoaded(CachableDataTypes.Milestones, spaceCache.Milestones.Count());
            }

            return dataCache;
        }

        public static void SetDataCache(nAssembla.Cache.DataCache cache)
        {
        }

        private static void RaiseDataLoaded(CachableDataTypes item, int records)
        {
            var eh = OnDataLoaded;
            if(eh != null)
                eh(null, new DataLoadedEventArgs(item.ToString(), records));
        }

        public static EventHandler<DataLoadedEventArgs> OnDataLoaded;
    }
}
