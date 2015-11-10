using System;

namespace nAssembla.Proxy
{
    public class CreateEntityException : Exception
    {
        public CreateEntityException(string message)
        : base(message)
        {
        }
    }
}