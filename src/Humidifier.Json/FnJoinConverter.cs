using System;
using Newtonsoft.Json;

namespace Humidifier.Json
{
    internal class FnJoinConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => objectType == typeof(FnJoin);

        public override bool CanRead => false;
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) => throw new NotImplementedException();

        public override bool CanWrite => true;
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            // { "Fn::Join" : [ "", ["arn:aws:s3:::", { "Ref" : "DeploymentBucket" } ] ] }

            var fn = (FnJoin)value;
            writer.WriteStartObject();
            writer.WritePropertyName("Fn::Join");
            writer.WriteStartArray();
            writer.WriteToken(JsonToken.String, fn.Seperator);
            serializer.Serialize(writer, fn.Parameters);
            writer.WriteEndArray();
            writer.WriteEndObject();
        }
    }
}