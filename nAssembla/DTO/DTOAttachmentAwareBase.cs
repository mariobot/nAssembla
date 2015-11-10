using System.Collections.Generic;
using System.Runtime.Serialization;
using nAssembla.DTO.Enums;

namespace nAssembla.DTO
{
    /// <summary>
    /// Represents an Assembla DTO object, which supports document attachments
    /// </summary>    
    public abstract class DTOAttachmentAwareBase : DTOBase
    {
        private List<Document> _attachments = new List<Document>();

        public IList<Document> Attachments
        {
            get
            {
                return _attachments;
            }
        }

        internal abstract AttachableType AttachableType { get; }
    }
}