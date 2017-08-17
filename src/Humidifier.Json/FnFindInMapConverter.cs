using System;
using Newtonsoft.Json;

namespace Humidifier.Json
{
    internal class FnFindInMapConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => objectType == typeof(FnFindInMap);

        public override bool CanRead => false;
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) => throw new NotImplementedException();

        public override bool CanWrite => true;
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            // { "Fn::FindInMap" : [ "RegionMap", { "Ref" : "AWS::Region" }, "32"]}

            var fn = (FnFindInMap)value;
            writer.WriteStartObject();
            writer.WritePropertyName("Fn::FindInMap");
            writer.WriteStartArray();
            writer.WriteToken(JsonToken.String, fn.MapName);
            serializer.Serialize(writer, fn.TopLevelKey);
            serializer.Serialize(writer, fn.SecondLevelKey);
            writer.WriteEndArray();
            writer.WriteEndObject();
        }
    }
}