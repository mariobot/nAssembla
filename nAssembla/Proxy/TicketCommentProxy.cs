using System.Collections.Generic;
using System;

namespace nAssembla.Proxy
{
    public class TicketCommentProxy : ProxyBase<DTO.TicketComment, int>
    {
        protected override string[] BaseUriParameters
        {
            get
            {
                return new string[] { SpacesUriPath, "tickets", TicketNumberPath, "ticket_comments" };
            }
        }

        protected override Uri GetRequestUri()
        {
            
            return base.GetRequestUri();
        }
    }
}