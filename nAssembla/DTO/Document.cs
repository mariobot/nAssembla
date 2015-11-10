using System;
using System.Collections.Generic;
using System.Xml.Linq;
using nAssembla.DTO.Enums;

namespace nAssembla.DTO
{
    public class Document : DTOBase
    {

        public string Id { get; private set; }
        public string AttachableId { get; private set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public Guid AttachableGuid { get; set; }
        public int Position { get; set; }
        public string ContentType { get; set; }
        public int? TicketId { get; set; }
        public int Version { get; set; }
        public string FileName { get; set; }
        public int FileSize { get; private set; }
        public string ImageFileName { get; set; }
        public string IndexableText { get; set; }
        public bool? UseAs { get; set; }
        public AttachableType AttachableType { get; set; }
        public string UpdatedBy { get; private set; }
        public string CreatedBy { get; private set; }


        internal override object KeyValue
        {
            get { return Id; }
        }


    }
}