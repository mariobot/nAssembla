using System;

namespace nAssembla.Proxy.Enums
{
    [Flags]
    public enum CachableDataTypes
    {
        Components = 1,
        Milestones = 2,
        Users = 4,
        Tools = 8,
        CustomStatuses = 16,
        CustomFields = 32,

        All = Components | Milestones | Users | Tools | CustomStatuses | CustomFields
    }
}