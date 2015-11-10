using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.IO;
using Newtonsoft.Json;
using nAssembla.DTO.Enums;
using nAssembla.Support;
using System.ComponentModel;

namespace nAssembla.DTO
{

    [JsonObject(MemberSerialization.OptIn, Title = "ticket")]
    public class Ticket : DTOAttachmentAwareBase
    {
        public Ticket() 
        { 
            Priority = Enums.Priority.Normal; 
        }

        #region Properties

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("number"), IsUpdatable]
        public int Number { get; set; }

        [JsonProperty("description"), IsUpdatable]
        public string Description { get; set; }

        [JsonProperty("summary"), IsUpdatable]
        public string Summary { get; set; }

        [JsonProperty("status"), IsUpdatable]
        public string StatusName { get; set; }

        [JsonProperty("importance")]
        public float Importance { get; set; }

        [JsonProperty("story_importance"), IsUpdatable]
        public float? StoryImportance { get; set; }

        [JsonProperty("priority"), IsUpdatable]
        public Priority Priority { get; set; }

        [JsonProperty("permission_type"), IsUpdatable]
        public PermissionType? PermissionType  { get; set; }

        [JsonProperty("milestone_id"), IsUpdatable]
        public int? MilestoneId { get; set; }

        public Milestone Milestone { get; set; }

        [JsonProperty("component_id"), IsUpdatable]
        public int? ComponentId { get; set; }

        public TicketComponent Component { get; set; }

        [JsonProperty("is_story"), JsonConverter(typeof(BooleanBitConverter)), IsUpdatable]
        public bool IsStory { get; set; }

        [JsonProperty("reporter_id"), IsUpdatable]
        public string ReporterId { get; set; }

        public User Reporter { get; set; }

        [JsonProperty("completed_date")]
        public DateTime? CompletedDate { get; set; }

        [JsonProperty("followers"), IsUpdatable]
        public IList<string> Followers { get; set; }

        [JsonProperty("notification_list"), IsUpdatable]
        public string NotificationList { get; set; }

        [JsonProperty("assigned_to_id"), IsUpdatable]
        public string AssignedTo { get; set; }

        public User Assignee { get; set; }

        [JsonProperty("estimate")]
        public float? Estimate { get; set; }

        [JsonProperty("total_estimate")]
        public float? TotalEstimate { get; set; }

        [JsonProperty("total_invested_hours")]
        public float? TotalInvestedHours { get; set; }

        [JsonProperty("total_working_hours")]
        public float? TotalWorkingHours { get; set; }

        [JsonProperty("state")]
        public bool IsOpen { get; set; }

        public IList<TicketComment> Comments { get; set; }

        public IEnumerable<TicketAssociation> Associations { get; set; }

        [JsonProperty("custom_fields"), 
        JsonConverter(typeof(CustomFieldsConverter)), 
        IsUpdatable]
        public Dictionary<string, object> CustomFields { get; set; }


        #endregion

        internal override AttachableType AttachableType
        {
            get
            {
                return nAssembla.DTO.Enums.AttachableType.Ticket;
            }
        }

        internal override object KeyValue
        {
            get { return Number; }
        }
    }

}
