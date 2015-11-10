using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace nAssembla.DTO
{
    [JsonObject(MemberSerialization.OptIn)]
    public class TicketComponent : DTOBase
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }

        internal override object KeyValue
        {
            get { return Id; }
        }
    }
}
