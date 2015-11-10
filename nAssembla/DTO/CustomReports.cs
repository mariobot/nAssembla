using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace nAssembla.DTO
{
    public class CustomReports
    {
        [JsonProperty("user_reports")]
        public IEnumerable<UserReport> UserReports { get; set; }       

        [JsonProperty("team_reports")]
        public IEnumerable<TeamReport> TeamReports { get; set; }
    }
}
