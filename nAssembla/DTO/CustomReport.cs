using Newtonsoft.Json;
using nAssembla.DTO.Enums;
using nAssembla.DTO.Interfaces;

namespace nAssembla.DTO
{
    public class CustomReport : DTOReadOnlyBase, IReport
    {
        public virtual ReportType Type
        {
            get
            {
                return ReportType.Standard;
            }
        }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }
}