using System;
using Newtonsoft.Json;

namespace Humidifier.Json
{
    internal class FnIfConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => objectType == typeof(FnIf);

        public override bool CanRead => false;
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) => throw new NotImplementedException();

        public override bool CanWrite => true;
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            // { "Fn::If": [ condition_name, value_if_true, value_if_false ] }

            var fn = (FnIf)value;

            writer.WriteStartObject();
            writer.WritePropertyName("Fn::If");
            writer.WriteStartArray();
            writer.WriteToken(JsonToken.String, fn.ConditionName);
            serializer.Serialize(writer, fn.ValueIfTrue);
            serializer.Serialize(writer, fn.ValueIfFalse);
            writer.WriteEndArray();
            writer.WriteEndObject();
        }
    }
}