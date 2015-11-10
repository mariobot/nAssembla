using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace nAssembla
{
    public class UpdatableContractResolver : DefaultContractResolver
    {
        public UpdatableContractResolver()
        {
        }

        protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
        {
            IList<JsonProperty> properties = base.CreateProperties(type, memberSerialization);

            var props = type.GetProperties().Where(p =>
            {
                var updatableAttr = p.GetCustomAttributes(typeof(IsUpdatableAttribute), true);
                return updatableAttr != null && updatableAttr.Length > 0;
            }).Select(p => p.Name).ToList();


            properties =
              properties.Where(p => props.Contains(p.UnderlyingName)).ToList();

            return properties;
        }
    }

}
