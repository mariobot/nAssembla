using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace nAssembla.DTO
{
    public class User : DTOBase
    {        
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("login")]
        public string LoginName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("organization")]
        public string Organization { get; set; }

        [JsonProperty("im")]
        public object IM1 { get; set; }

        [JsonProperty("im2")]
        public object IM2 { get; set; }

        internal override object KeyValue
        {
            get { return Id; }
        }
    }
}