using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Newtonsoft.Json;
using nAssembla.DTO.Interfaces;

namespace nAssembla.DTO
{ 
    public class CustomStatus : DTOBase, IStatus
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("space_id_tool")]
        public string SpaceToolId { get; set; }

        [JsonProperty("state")]
        public bool IsOpen { get; set; }

        [JsonProperty("list_order")]
        public int? Order { get; set; }
      
        internal override object KeyValue
        {
            get
            {
                return Id;
            }
        }
    }
}
