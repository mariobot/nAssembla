using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace nAssembla.Support
{
    class CustomFieldsConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var dict = value as Dictionary<string, object>;
            if (dict != null)
            {
               // writer.WriteStartArray();
                writer.WriteStartObject();
                
                foreach (var e in dict)
                {
                    writer.WritePropertyName(e.Key.Replace(" ", "_"));
                    writer.WriteValue(e.Value.ToString());

                }
                writer.WriteEndObject();
                // writer.WriteEndArray();

            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var ret = new Dictionary<string, object>();
            var currentKey = "";
            var endDo = false;
            do
            {
                switch (reader.TokenType)
                {
                    case JsonToken.EndObject:
                        endDo = true;
                        break;
                    case JsonToken.PropertyName:
                        currentKey = reader.Value.ToString();
                        ret.Add(currentKey, null);
                        break;
                    case JsonToken.String:
                        ret[currentKey] = reader.Value;
                        break;
                    default:
                        break;
                }
                
            } while (!endDo && reader.Read());
            


            return ret;
        }

        public override bool CanConvert(Type objectType)
        {
            return true;

        }
    }
}
