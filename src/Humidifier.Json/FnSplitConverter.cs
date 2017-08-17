using System;
using Newtonsoft.Json;

namespace Humidifier.Json
{
    internal class FnSplitConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => objectType == typeof(FnSplit);

        public override bool CanRead => false;
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) => throw new NotImplementedException();

        public override bool CanWrite => true;
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            // { "Fn::Split": [ "," , { "Fn::ImportValue": "AccountSubnetIDs"} ] }

            var fn = (FnSplit)value;
            writer.WriteStartObject();
            writer.WritePropertyName("Fn::Split");
            writer.WriteStartArray();
            writer.WriteToken(JsonToken.String, fn.Delimiter);
            serializer.Serialize(writer, fn.SourceString);
            writer.WriteEndArray();
            writer.WriteEndObject();
        }
    }
}