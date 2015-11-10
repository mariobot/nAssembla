using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace nAssembla.DTO
{
    [JsonObject(MemberSerialization.OptIn, Title = "ticket_assoication")]
    public class TicketAssociation : DTOBase
    {        
        [JsonProperty("id")]
        public int Id { get; private set; }

        [JsonProperty("comment"), IsUpdatable]
        public string Comment { get; set; }

        [JsonProperty("ticket_id")]
        public int TicketId { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; private set; }

        [JsonProperty("ticket_changes")]
        public string TicketChanges { get; private set; }
        
        public User User { get; set; }


        internal override object KeyValue
        {
            get { return Id; }
        }
    }
}