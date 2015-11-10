using Newtonsoft.Json;
using nAssembla.DTO.Enums;

namespace nAssembla.DTO
{
    [JsonObject("team-report")]
    public class TeamReport : CustomReport
    {
        public override ReportType Type
        {
            get
            {
                return ReportType.Team;
            }
        }
    }
}