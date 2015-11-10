using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Newtonsoft.Json;
using nAssembla.DTO.Enums;

namespace nAssembla.DTO
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Milestone : DTOBase
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("due_date")]
        public DateTime? DueDate { get; set; }
                
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("user_id")]
        public string ResponsibleUser { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("is_completed")]
        public bool IsCompleted { get; set; }

        [JsonProperty("completed_date")]
        public DateTime? CompletedDate { get; set; }

        [JsonProperty("release_level")]
        public int? ReleaseLevel { get; set; }

        [JsonProperty("release_notes")]
        public string ReleaseNotes { get; set; }

        [JsonProperty("planner_type")]
        public PlannerType PlannerType { get; set; }

        
        internal override object KeyValue
        {
            get { return Id; }
        }

    }
}
