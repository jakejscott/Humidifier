using System;
using Newtonsoft.Json;

namespace Humidifier.Json
{
    internal class FnGetAZsConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => objectType == typeof(FnGetAZs);

        public override bool CanRead => false;
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) => throw new NotImplementedException();

        public override bool CanWrite => true;
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            // { "Fn::GetAZs" : "" }
            // { "Fn::GetAZs" : { "Ref" : "AWS::Region" } }
            // { "Fn::GetAZs" : "us-east-2" }

            var fn = (FnGetAZs)value;
            writer.WriteStartObject();
            writer.WritePropertyName("Fn::GetAZs");
            serializer.Serialize(writer, fn.Region);
            writer.WriteEndObject();
        }
    }
}