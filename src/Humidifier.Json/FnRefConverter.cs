using System;
using Newtonsoft.Json;

namespace Humidifier.Json
{
    internal class FnRefConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => objectType == typeof(FnRef);

        public override bool CanRead => false;
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) => throw new NotImplementedException();

        public override bool CanWrite => true;
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            // { "Ref" : "AWS::StackName }

            var fn = (FnRef)value;
            writer.WriteStartObject();
            writer.WritePropertyName("Ref");
            writer.WriteToken(JsonToken.String, fn.Reference);
            writer.WriteEndObject();
        }
    }
}