using System;
using Newtonsoft.Json;

namespace Humidifier.Json
{
    internal class FnSelectConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => objectType == typeof(FnSelect);

        public override bool CanRead => false;
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) => throw new NotImplementedException();

        public override bool CanWrite => true;
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            // { "Fn::Select" : [ "1", [ "apples", "grapes", "oranges", "mangoes" ] ] }

            var fn = (FnSelect)value;
            writer.WriteStartObject();
            writer.WritePropertyName("Fn::Select");
            writer.WriteStartArray();
            writer.WriteToken(JsonToken.String, fn.Index);
            serializer.Serialize(writer, fn.ListOfObjects);
            writer.WriteEndArray();
            writer.WriteEndObject();
        }
    }
}