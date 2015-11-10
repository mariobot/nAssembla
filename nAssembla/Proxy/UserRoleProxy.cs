using System;
using System.Threading.Tasks;
using nAssembla.DTO;

namespace nAssembla.Proxy
{
    public class UserRoleProxy : ProxyBase<UserRole, int>
    {
        protected override string[] BaseUriParameters
        {
            get
            {
                return new string[] { SpacesUriPath, "user_roles" };
            }
        }

        internal override bool DataIsCachable
        {
            get { return true; }
        }
    }
}