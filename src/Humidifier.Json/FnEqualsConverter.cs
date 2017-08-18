using System;
using Newtonsoft.Json;

namespace Humidifier.Json
{
    internal class FnEqualsConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => objectType == typeof(FnEquals);

        public override bool CanRead => false;
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) => throw new NotImplementedException();

        public override bool CanWrite => true;
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            // { "Fn::Equals" : ["value_1", "value_2"] }

            var fn = (FnEquals)value;

            writer.WriteStartObject();
            writer.WritePropertyName("Fn::Equals");
            writer.WriteStartArray();

            serializer.Serialize(writer, fn.Value1);
            serializer.Serialize(writer, fn.Value2);

            writer.WriteEndArray();
            writer.WriteEndObject();
        }
    }
}