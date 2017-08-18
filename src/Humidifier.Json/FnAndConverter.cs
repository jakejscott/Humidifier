using System;
using Newtonsoft.Json;

namespace Humidifier.Json
{
    internal class FnAndConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => objectType == typeof(FnAnd);
        public override bool CanRead => false;
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) => throw new NotImplementedException();
        public override bool CanWrite => true;
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            // { "Fn::And": [{condition}, {...}] }

            var fn = (FnAnd)value;
            writer.WriteStartObject();
            writer.WritePropertyName("Fn::And");
            writer.WriteStartArray();
            foreach (var condition in fn.Conditions)
            {
                serializer.Serialize(writer, condition);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }
    }
}