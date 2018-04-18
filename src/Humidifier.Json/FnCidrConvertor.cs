using System;
using Newtonsoft.Json;

namespace Humidifier.Json
{
    internal class FnCidrConvertor : JsonConverter
    {
        public override bool CanConvert(Type objectType) => objectType == typeof(FnCidr);
        public override bool CanRead => false;
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) => throw new NotImplementedException();
        public override bool CanWrite => true;
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            // { "Fn::Cidr": [ "ipBlock", "count", "sizeMask"] }

            var fn = (FnCidr)value;
            writer.WriteStartObject();
            writer.WritePropertyName("Fn::Cidr");
            writer.WriteStartArray();
            writer.WriteToken(JsonToken.String, fn.IpBlock);
            writer.WriteToken(JsonToken.String, fn.Count);
            writer.WriteToken(JsonToken.String, fn.SizeMask);
            writer.WriteEndArray();
            writer.WriteEndObject();
        }
    }
}