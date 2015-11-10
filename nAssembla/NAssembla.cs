using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nAssembla.Proxy;

namespace nAssembla
{
    /// <summary>
    /// Static class which provides convenient access to all of the Proxy classes. 
    /// </summary>
    public static class NAssembla
    {
        #region Fields

        private static SpaceProxy _spaceProxy;
        private static UserProxy _userProxy;
        private static UserRoleProxy _userRoleProxy;
        private static TicketComponentProxy _ticketComponentProxy;
        private static CustomFieldProxy _customFieldProxy;
        private static SpaceToolProxy _spaceToolProxy;
        private static MilestoneProxy _milestoneProxy;
        private static TicketProxy _ticketProxy;
        private static CustomReportsProxy _customReportProxy;
        private static ActivityProxy _activityProxy;
        private static DocumentProxy _documentProxy;
        private static CustomStatusProxy _customStatusProxy;

        #endregion

        public static SpaceProxy SpaceProxy
        {
            get
            {
                if (_spaceProxy == null)
                {
                    _spaceProxy = new SpaceProxy();
                    // _spaceProxy.Error += Proxy_Error;
                }
                return _spaceProxy;
            }
        }

        public static UserProxy UserProxy
        {
            get
            {
                if (_userProxy == null)
                {
                    _userProxy = new UserProxy();
                    // _spaceProxy.Error += Proxy_Error;
                }
                return _userProxy;
            }
        }

        public static UserRoleProxy UserRoleProxy
        {
            get
            {
                if (_userRoleProxy == null)
                {
                    _userRoleProxy = new UserRoleProxy();
                    // _spaceProxy.Error += Proxy_Error;
                }
                return _userRoleProxy;
            }
        }

        public static SpaceToolProxy SpaceToolProxy
        {
            get
            {
                if (_spaceToolProxy == null)
                {
                    _spaceToolProxy = new SpaceToolProxy();
                    //_spaceToolProxy.Error += Proxy_Error;
                }
                return _spaceToolProxy;
            }
        }

        public static TicketComponentProxy TicketComponentProxy
        {
            get
            {
                if (_ticketComponentProxy == null)
                {
                    _ticketComponentProxy = new TicketComponentProxy();
                    //_spaceToolProxy.Error += Proxy_Error;
                }
                return _ticketComponentProxy;
            }
        }

        public static TicketProxy TicketProxy
        {
            get
            {
                if (_ticketProxy == null)
                {
                    _ticketProxy = new TicketProxy();
                    //_ticketProxy.Error += Proxy_Error;
                }
                return _ticketProxy;
            }
        }

        public static CustomFieldProxy CustomFieldProxy
        {
            get
            {
                if (_customFieldProxy == null)
                {
                    _customFieldProxy = new CustomFieldProxy();
                    //_ticketProxy.Error += Proxy_Error;
                }
                return _customFieldProxy;
            }
        }

        public static MilestoneProxy MilestoneProxy
        {
            get
            {
                if (_milestoneProxy == null)
                {
                    _milestoneProxy = new MilestoneProxy();
                    //_ticketProxy.Error += Proxy_Error;
                }
                return _milestoneProxy;
            }
        }
        
        public static ActivityProxy ActivityProxy
        {
            get
            {

                if (_activityProxy == null)
                {
                    _activityProxy = new ActivityProxy();
                    //_streamProxy.Error += Proxy_Error;
                }

                return _activityProxy;
            }
        }        

        public static DocumentProxy DocumentProxy
        {
            get
            {
                if (_documentProxy == null)
                {
                    _documentProxy = new DocumentProxy();
                    //_documentProxy.Error += Proxy_Error;
                }
                return _documentProxy;
            }
        }

        public static CustomReportsProxy CustomReportProxy
        {
            get
            {
                if (_customReportProxy == null)
                {
                    _customReportProxy = new CustomReportsProxy();
                    //_customReportProxy.Error += Proxy_Error;
                }
                return _customReportProxy;
            }
        }

        public static CustomStatusProxy CustomStatusProxy
        {
            get
            {
                if (_customStatusProxy == null)
                {
                    _customStatusProxy = new CustomStatusProxy();
                    //_customStatusProxy.Error += Proxy_Error;
                }
                return _customStatusProxy;
            }
        }

        private static void Proxy_Error(object sender, nAssemblaExceptionEventArgs e)
        {
            var eh = Error;
            if (eh != null)
                eh(sender, e); //Bubble up the original sender
        }

        public static event EventHandler<nAssemblaExceptionEventArgs> Error;

        public static Action CallbackContext { get; set; }

        public static void SetSpaceDataCache(nAssembla.Cache.SpaceDataCache cache)
        {
            if (cache.Components != null)
                TicketComponentProxy.DataCache = cache.Components.ToList();
            else
                TicketComponentProxy.DataCache = null;

            if (cache.CustomFields != null)
                CustomFieldProxy.DataCache = cache.CustomFields.ToList();
            else
                CustomFieldProxy.DataCache = null;

            if (cache.CustomStatuses != null)
                CustomStatusProxy.DataCache = cache.CustomStatuses.ToList();
            else
                CustomStatusProxy.DataCache = null;

            if (cache.CustomReports != null)
                CustomReportProxy.DataCache = cache.CustomReports.ToList();
            else
                CustomReportProxy.DataCache = null;

            if (cache.Milestones != null)
                MilestoneProxy.DataCache = cache.Milestones.ToList();
            else
                MilestoneProxy.DataCache = null;

            if (cache.Tools != null)
                SpaceToolProxy.DataCache = cache.Tools.ToList();
            else
                SpaceToolProxy.DataCache = null;

            if (cache.Users != null)
                UserProxy.DataCache = cache.Users.ToList();
            else
                UserProxy.DataCache = null;

            if (cache.UserRoles != null)
                UserRoleProxy.DataCache = cache.UserRoles.ToList();
            else
                UserRoleProxy.DataCache = null;
        }

        public static async Task<nAssembla.Cache.SpaceDataCache> GetSpaceDataCache(string spaceId)
        {
            var dataCache = new nAssembla.Cache.SpaceDataCache();
            var space = SpaceProxy.GetAsync(spaceId, true);
            var components = TicketComponentProxy.GetListAsync(true);
            var fields = CustomFieldProxy.GetListAsync(true);
            var custReports = CustomReportProxy.GetListAsync(true);
            var statuses = CustomStatusProxy.GetListAsync(true);
            var milestones = MilestoneProxy.GetListAsync(true);
            var tools = SpaceToolProxy.GetListAsync(true);
            var users = UserProxy.GetListAsync(true);
            var userRoles = UserRoleProxy.GetListAsync(true);
#if NET4_5
            await Task.WhenAll(space, components, fields, statuses, milestones, tools, users, custReports, userRoles);
#else
            await TaskEx.WhenAll(space, components, fields, statuses, milestones, tools, users, custReports, userRoles);
#endif
            dataCache.Space = space.Result;
            dataCache.Components = components.Result;
            dataCache.CustomFields = fields.Result;
            dataCache.CustomStatuses = statuses.Result;
            dataCache.Milestones = milestones.Result;
            dataCache.Tools = tools.Result;
            dataCache.Users = users.Result;
            dataCache.CustomReports = custReports.Result;
            dataCache.UserRoles = userRoles.Result;

            return dataCache;
        }

        public static IEnumerable<T> PrependBlank<T>(this IEnumerable<T> list)
            where T : DTO.DTOReadOnlyBase, new()
        {

            if (list != null)
            {
                var ret = list.ToList();
                ret.Insert(0, new T());
                return ret;
            }
            return list;
        }

        public static ActivityProxy DateFrom(this ActivityProxy proxy, DateTime dateFrom)
        {
            proxy.DateFrom = dateFrom;
            return proxy;
        }

        public static ActivityProxy DateTo(this ActivityProxy proxy, DateTime dateTo)
        {
            proxy.DateTo = dateTo;
            return proxy;
        }

        public static ActivityProxy Space(this ActivityProxy proxy, string spaceId)
        {
            proxy.SpaceId = spaceId;
            return proxy;
        }

    }
}
