using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace nAssembla.DTO
{
    [JsonObject(MemberSerialization.OptIn, Title = "ticket_comment")]
    public class TicketComment : DTOBase
    {        
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("comment"), IsUpdatable]
        public string Comment { get; set; }

        [JsonProperty("ticket_id")]
        public int TicketId { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("ticket_changes")]
        public string TicketChanges { get; set; }
        
        public User User { get; set; }


        internal override object KeyValue
        {
            get { return Id; }
        }


    }
}