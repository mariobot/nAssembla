using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Newtonsoft.Json;
using nAssembla.DTO.Enums;

namespace nAssembla.DTO
{ 
    public class CustomField : DTOBase
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("type"), IsUpdatable]
        public FieldType Type { get; set; }

        [JsonProperty("title"), IsUpdatable]
        public string Title { get; set; }

        public string SeralizableTitle
        {
            get { return Title.Replace(" ", "-"); }
        }

        [JsonProperty("space_id_tool")]
        public string SpaceToolId { get; set; }

        [JsonProperty("order"), IsUpdatable]
        public int? Order { get; set; }

        [JsonProperty("required"), IsUpdatable]
        public bool Required { get; set; }

        [JsonProperty("hide"), IsUpdatable]
        public bool Hide { get; set; }

        [JsonProperty("default_value"), IsUpdatable]
        public string Defaultvalue { get; set; }

        [JsonProperty("list_options"), IsUpdatable]
        public string[] ListOptions { get; set; }

        internal override object KeyValue
        {
            get
            {
                return Id;
            }
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }
}
