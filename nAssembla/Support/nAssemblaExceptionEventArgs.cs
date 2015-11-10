using System;

namespace nAssembla
{
    public class nAssemblaExceptionEventArgs : EventArgs
    {
        public nAssemblaExceptionEventArgs(Exception ex)
        {
            Exception = ex;
        }

        public Exception Exception { get; private set; }
    }
}