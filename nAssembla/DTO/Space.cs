using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace nAssembla.DTO
{
    [JsonObject(MemberSerialization.OptIn, Title="space")]
    public class Space : DTOBase
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("wiki_name"), IsUpdatable]
        public string WikiName { get; set; }

        [JsonProperty("wiki_format"), IsUpdatable]
        public WikiFormat WikiFormat { get; set; }

        [JsonProperty("team_permissions"), IsUpdatable]
        public TeamPermission TeamPermissions { get; set; }

        [JsonProperty("public_permissions"), IsUpdatable]
        public PublicPermission PublicPermissions { get; set; }

        [JsonProperty("description"), IsUpdatable]
        public string Description { get; set; }

        [JsonProperty("can_join")]
        public bool CanJoin { get; set; }

        [JsonProperty("default_showpage"), IsUpdatable]
        public string DefaultShowpage { get; set; }

        public List<string> Tags { get; set; }


        [JsonProperty("parent_id")]
        public string ParentId { get; set; }

        [JsonProperty("is_volunteer")]
        public bool IsVolunteer { get; set; }

        [JsonProperty("is_commercial")]
        public bool IsCommercial { get; set; }

        [JsonProperty("is_manager")]
        public bool IsManager { get; set; }


        internal override object KeyValue
        {
            get { return Id; }
        }

        
    }

    public enum WikiFormat
    {
        Text = 0,
        Markdown = 1,
        Textile = 2,
        WYSIWYG = 3
    }

    public enum TeamPermission
    {
        None = 0,
        View = 1,
        Edit = 2,
        All = 3
    }

    public enum PublicPermission
    {
        None = 0,
        View = 1,
        Edit = 2
    }

    public enum SpaceToolType
    {
        Chat = 1,
        Forum = 2,
        Hello = 3,
        Image = 4,
        Imap = 5,
        PortfolioManager = 6,
        PortfolioMember = 7,
        Mephisto = 8,
        Milestone = 9,
        Scrum = 10,
        Staffing = 11,
        Subversion = 12,
        Ticket = 13,
        Time = 14,
        Trac = 15,
        TracAndMercurial = 16,
        Typo = 17
    }

}