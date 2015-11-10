using System;

namespace nAssembla.Proxy
{
    public class CustomStatusProxy : ProxyReadOnlyBase<DTO.CustomStatus>
    {
        protected override string[] BaseUriParameters
        {
            get
            {
                return new string[] { SpacesUriPath, "tickets", "statuses" };
            }
        }

        internal override bool DataIsCachable
        {
            get { return true; }
        }
    }
}