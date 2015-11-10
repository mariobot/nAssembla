using System;

namespace nAssembla.Proxy
{
    public class TicketComponentProxy : ProxyBase<DTO.TicketComponent, int>
    {
        protected override string[] BaseUriParameters
        {
            get
            {
                return new string[] { SpacesUriPath, "ticket_components" };
            }
        }

        internal override bool DataIsCachable
        {
            get { return true; }
        }

    }
}