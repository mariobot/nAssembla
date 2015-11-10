using System;
using System.Threading.Tasks;
using nAssembla.DTO;

namespace nAssembla.Proxy
{
    public class UserProxy : ProxyBase<User, string>
    {
        private Mode _mode = Mode.GetList;

        private enum Mode
        {
            GetCurrent,
            GetById,
            GetList
        }

        protected override string[] BaseUriParameters
        {
            get
            {                
                switch (_mode)
                {
                    case Mode.GetCurrent:
                        return new string[] { "user" };
                    case Mode.GetById:
                        return new string[] { "users" };
                }
                return new string[] { SpacesUriPath, "users" };
            }
        }

        internal override bool DataIsCachable
        {
            get { return true; }
        }

        protected override async Task<System.Collections.Generic.IEnumerable<User>> GetListAsyncInternal()
        {
            _mode = Mode.GetList;
            return await base.GetListAsyncInternal();
        }

        public override async Task<User> GetAsync(string key, bool forceRefresh = false)
        {
            _mode = Mode.GetById;
            return await base.GetAsync(key, forceRefresh);
        }

        public async Task<User> GetCurrentUserAsync(bool forceRefresh = false)
        {
            _mode = Mode.GetCurrent;
            return await base.GetAsync(null, forceRefresh);
        }
        
    }
}