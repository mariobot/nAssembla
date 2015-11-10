using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using nAssembla;
using nAssembla.DTO.Enums;

namespace nAssembla.DTO.Interfaces
{
    public interface IReport
    {
        ReportType Type { get; }

        string Name { get; }

        int Id { get; }
    }
}