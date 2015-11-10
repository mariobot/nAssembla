using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace nAssembla.DTO.Interfaces
{
    public interface IStatus
    {
        bool IsOpen { get; }

        string Name { get; }

        int Id { get; }

        int? Order { get; }
    }
}