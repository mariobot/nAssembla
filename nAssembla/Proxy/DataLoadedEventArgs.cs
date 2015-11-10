using System;

namespace nAssembla.Proxy
{
    public class DataLoadedEventArgs : EventArgs
    {
        public DataLoadedEventArgs(string item, int records)
        {
            Records = records;
            Item = item;
        }

        public int Records { get; private set; }

        public string Item { get; private set; }
    }
}