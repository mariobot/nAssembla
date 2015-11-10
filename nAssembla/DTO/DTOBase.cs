using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.ComponentModel;
using System.Runtime.Serialization;
using nAssembla.DTO.Enums;

namespace nAssembla.DTO
{

    /// <summary>
    /// Represents an Assembla entity, which supports update operations
    /// </summary>
    public abstract class DTOBase : DTOReadOnlyBase
    {
        /// <summary>
        /// The 'primary key' of an updatable entity
        /// </summary>
        internal abstract object KeyValue { get; }
    }
   
}
