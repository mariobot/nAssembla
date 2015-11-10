using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace nAssembla.Proxy
{
    public class TicketProxy : AttachmentAwareProxyBase<DTO.Ticket, int>
    {
        protected override string[] BaseUriParameters
        {
            get
            {
                return new string[] { SpacesUriPath, "tickets" };
            }
        }

        public async Task<IEnumerable<DTO.Ticket>> GetListByMilestoneIdAsync(int milestoneId)
        {
            AdditionalUriParameters = new string[] { "milestone", milestoneId.ToString() };
            return await GetListAsync();           
        }
        
        public async Task<IEnumerable<DTO.Ticket>> GetListByReportIdAsync(int reportId, int pageIndex  = 0, int pageSize = 1000)
        {
            AdditionalUriParameters = null;
            AdditionalUriQueryParameters.Clear();
            AdditionalUriQueryParameters.Add("report", (reportId > 10 ? "u" : "") + reportId.ToString());
            if (pageIndex > 0)
                AdditionalUriQueryParameters.Add("page", pageIndex.ToString());
            if (pageSize != 1000)
                AdditionalUriQueryParameters.Add("report", (pageSize > 10 ? "u" : "") + pageSize.ToString());


            var data = await GetListAsync();
            return data;
        }

        public async Task<IEnumerable<DTO.TicketComment>> GetCommentsForTicket(DTO.Ticket ticket)
        {
            AdditionalUriParameters = new string[] { ticket.Number.ToString(), "ticket_comments" };
            var comments = await GetAsync<IEnumerable<DTO.TicketComment>>();
            ticket.Comments = comments.ToList();
            return comments;
        }

        public async Task<DTO.TicketComment> AddCommentToTicketAsync(DTO.Ticket ticket, string comment)
        {
            AdditionalUriParameters = new string[] { ticket.Number.ToString(), "ticket_comments" };

            var ticketComment = new DTO.TicketComment() { Comment = comment };
            var data = await CreateAsync(ticketComment);
            ticket.Comments.Add(data);
            return data;
        }

        public async Task<DTO.TicketComment> UpdateTicketComment(DTO.Ticket ticket, DTO.TicketComment ticketComment)
        {
            AdditionalUriParameters = new string[] { ticket.Number.ToString(), "ticket_comments" };

            var data = await UpdateAsync(ticketComment);
            //ticket.Comments.Single(c=> c.Id == ticketComment.Id) = data;
            return data;
        }
    }
}