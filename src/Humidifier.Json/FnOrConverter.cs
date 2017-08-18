using System;
using Newtonsoft.Json;

namespace Humidifier.Json
{
    internal class FnOrConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => objectType == typeof(FnOr);
        public override bool CanRead => false;
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) => throw new NotImplementedException();
        public override bool CanWrite => true;
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            // { "Fn::Or": [{condition}, {...}] }

            var fn = (FnOr)value;
            writer.WriteStartObject();
            writer.WritePropertyName("Fn::Or");
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