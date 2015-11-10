using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using nAssembla.DTO.Enums;

namespace nAssembla.DTO
{
    public class UserRole : DTOBase
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        public User User { get; set; }

        [JsonProperty("role"), JsonConverter(typeof(StringEnumConverter)), IsUpdatable]
        public UserRoleType Role { get; set; }

        [JsonProperty("status")]
        public UserRoleStatus Status { get; set; }

        [JsonProperty("invited_time")]
        public DateTime InvitedTime { get; set; }

        [JsonProperty("agreed_time")]
        public DateTime? AgreedTime { get; set; }

        [JsonProperty("title"), IsUpdatable]
        public string Title { get; set; }

        [JsonProperty("invited_by_id")]
        public string InvitedById { get; set; }

        public User InvitedBy { get; set; }

        [JsonProperty("message"), IsUpdatable]
        public string Message { get; set; }

        internal override object KeyValue
        {
            get { return Id; }
        }
    }

}