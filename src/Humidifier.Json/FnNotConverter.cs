using System;
using Newtonsoft.Json;

namespace Humidifier.Json
{
    internal class FnNotConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => objectType == typeof(FnNot);

        public override bool CanRead => false;
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) => throw new NotImplementedException();

        public override bool CanWrite => true;
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            // { "Fn::Not": [{condition}] }

            var fn = (FnNot)value;

            writer.WriteStartObject();
            writer.WritePropertyName("Fn::Not");
            writer.WriteStartArray();
            serializer.Serialize(writer, fn.Condition);
            writer.WriteEndArray();
            writer.WriteEndObject();
        }
    }
}