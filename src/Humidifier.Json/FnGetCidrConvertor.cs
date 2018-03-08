using System;
using Newtonsoft.Json;

namespace Humidifier.Json
{
    internal class FnGetCidrConvertor : JsonConverter
    {
        public override bool CanConvert(Type objectType) => objectType == typeof(FnGetCidr);
        public override bool CanRead => false;
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) => throw new NotImplementedException();
        public override bool CanWrite => true;
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            // { "Fn::GetCidr": [ "ipBlock", "count", "sizeMask"] }

            var fn = (FnGetCidr)value;
            writer.WriteStartObject();
            writer.WritePropertyName("Fn::GetCidr");
            writer.WriteStartArray();
            writer.WriteToken(JsonToken.String, fn.IpBlock);
            writer.WriteToken(JsonToken.String, fn.Count);
            writer.WriteToken(JsonToken.String, fn.SizeMask);
            writer.WriteEndArray();
            writer.WriteEndObject();
        }
    }
}