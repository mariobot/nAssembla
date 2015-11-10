using Newtonsoft.Json;
using nAssembla.DTO.Enums;

namespace nAssembla.DTO
{
    [JsonObject("user-report")]
    public class UserReport : CustomReport
    {
        public override ReportType Type
        {
            get
            {
                return ReportType.User;
            }
        }
    }
}