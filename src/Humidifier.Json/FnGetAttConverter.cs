using System;
using Newtonsoft.Json;

namespace Humidifier.Json
{
    internal class FnGetAttConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => objectType == typeof(FnGetAtt);

        public override bool CanRead => false;
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) => throw new NotImplementedException();

        public override bool CanWrite => true;
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            // { "Fn::GetAtt" : [ "logicalNameOfResource", "attributeName" ] }

            var fn = (FnGetAtt)value;
            writer.WriteStartObject();
            writer.WritePropertyName("Fn::GetAtt");
            writer.WriteStartArray();
            writer.WriteToken(JsonToken.String, fn.LogicalNameOfResource);
            writer.WriteToken(JsonToken.String, fn.AttributeName);
            writer.WriteEndArray();
            writer.WriteEndObject();
        }
    }
}