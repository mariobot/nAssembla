using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace nAssembla.DTO
{ 
    /// <summary>
    /// An activity stream event
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Event : DTOReadOnlyBase
    {
       
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("operation")]
        public string Operation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("object_id")]
        public string ObjectId { get; set; }

        [JsonProperty("whatchanged")]
        public string WhatChanged { get; set; }

        [JsonProperty("comment_or_description")]
        public string CommentOrDescription { get; set; }

        [JsonProperty("space_name")]
        public string SpaceName { get; set; }
       
        [JsonProperty("space_id")]
        public string SpaceId { get; set; }

        [JsonProperty("author_name")]
        public string AuthorName { get; set; }

        [JsonProperty("ticket")]
        public Ticket Ticket { get; set; }

    }
}
