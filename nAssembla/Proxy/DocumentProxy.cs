using System;

namespace nAssembla.Proxy
{
    public class DocumentProxy : ProxyReadOnlyBase<DTO.Document>
    {
        protected override string[] BaseUriParameters
        {
            get
            {
                return new string[] { SpacesUriPath, "documents"};
            }
        }      
    }
}