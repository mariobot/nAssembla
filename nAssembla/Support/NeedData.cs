using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nAssembla
{
    public class NeedDataEventArgs<T, TKey> : EventArgs
        where T : DTO.DTOReadOnlyBase, new()
    {
        public T Item { get; set; }
        public TKey Key{ get; private set; }

        public NeedDataEventArgs(TKey key)
        {
            Key = key;
        }

    }
}
