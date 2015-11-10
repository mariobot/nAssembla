using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Newtonsoft.Json;
using nAssembla.DTO.Enums;

namespace nAssembla.DTO
{
    [JsonObject(Title="space-tools")]
    public class SpaceTool : DTOBase
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
        
        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("settings")]
        public object Settings { get; set; }

        [JsonProperty("watcher_permissions")]
        public SpaceToolPermission? WatcherPermissions { get; set; }

        [JsonProperty("team_permissions")]
        public SpaceToolPermission? TeamPermissions { get; set; }

        [JsonProperty("public_permissions")]
        public SpaceToolPermission? PublicPermissions { get; set; }
        
        [JsonProperty("tool_id")]
        public ToolId? ToolId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("parent_id")]
        public string ParentId { get; set; }

        [JsonProperty("menu_name")]
        public string MenuName { get; set; }
        
        internal override object KeyValue
        {
            get { return Id; }
        }
    }   

}