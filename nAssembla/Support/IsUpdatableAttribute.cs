using System;

namespace nAssembla
{
    /// <summary>
    /// Indicates that this property can be written to Assembla
    /// </summary>
    public class IsUpdatableAttribute : Attribute
    {
        public IsUpdatableAttribute()
        {
        }
    }
}