using System;
using Newtonsoft.Json;

namespace Humidifier.Json
{
    internal class FnImportValueConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => objectType == typeof(FnImportValue);

        public override bool CanRead => false;
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) => throw new NotImplementedException();

        public override bool CanWrite => true;
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            // { 'Fn::ImportValue' : { 'Fn::Sub': '${AutomationStack}-DeploymentBucket' } }

            var fn = (FnImportValue)value;
            writer.WriteStartObject();
            writer.WritePropertyName("Fn::ImportValue");
            serializer.Serialize(writer, fn.SharedValueToImport);
            writer.WriteEndObject();
        }
    }
}