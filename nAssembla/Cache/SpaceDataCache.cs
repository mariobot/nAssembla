using System.Collections.Generic;
using Newtonsoft.Json;
using nAssembla.DTO;

namespace nAssembla.Cache
{
    /// <summary>
    /// All data which is considered to be cachable
    /// </summary>
    [JsonObject(MemberSerialization.OptOut)]
    public class SpaceDataCache
    {
        public Space Space { get; set; }

        public IEnumerable<TicketComponent> Components { get; set; }

        public IEnumerable<Milestone> Milestones { get; set; }

        public IEnumerable<User> Users { get; set; }

        public IEnumerable<UserRole> UserRoles { get; set; }

        public IEnumerable<SpaceTool> Tools { get; set; }

        public IEnumerable<CustomStatus> CustomStatuses { get; set; }

        public IEnumerable<CustomField> CustomFields { get; set; }

        public IEnumerable<CustomReport> CustomReports { get; set; }
    }
}